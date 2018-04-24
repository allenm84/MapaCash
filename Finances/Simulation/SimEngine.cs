using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Finances
{
  public static class SimEngine
  {
    public static SimulationAccount[] RunSimulation(DateTime start, int years, string json)
    {
      var max = start.AddYears(years).AddDays(1);
      var data = JsonConvert.DeserializeObject<SaveData>(json);

      // create a simulation account for the all of the accounts
      var accounts = data.Accounts.Select(a => new SimulationAccount(a)).ToArray();
      var lookup = accounts.ToDictionary(a => a.Id);

      // for this to be valid, the transactions need to be in order
      var transactions = from t in data.Transactions
                         let seed = t.GetNextDate(out bool _)
                         from date in t.GenerateDates(seed, max).SkipWhile(d => d < start)
                         orderby date
                         select (date, t);
      foreach (var (date, t) in transactions)
      {
        AddTransaction(date, t);
      }

      // get all of the root nodes
      CalculateBalance(null, accounts, out _);
      return accounts;

      void AddTransaction(DateTime date, RecurringTransaction t)
      {
        var from = lookup[t.FromAccountId];
        var to = lookup[t.ToAccountId];
        if (from.Type == AccountType.Group || to.Type == AccountType.Group)
        {
          return;
        }

        var amount = t.Amount;
        if (t.ValueType == RecurringValueType.Interest)
        {
          // the amount is actually a percentage of the current balance
          amount = (t.Interest / 12m) * from.Balance;

          // interest should not be below 0
          amount = Math.Max(amount, 0);
        }

        if (from.Type == AccountType.Income)
        {
          // if we're going from income to anything, then it is a good thing
          from.Increase(date, t.Name, to.Id, amount);

          switch (to.Type)
          {
            case AccountType.Income:
            case AccountType.Savings:
            case AccountType.Checking:
              to.Increase(date, t.Name, from.Id, amount);
              break;
            case AccountType.CreditCard:
            case AccountType.Expense:
            case AccountType.Liability:
              to.Decrease(date, t.Name, from.Id, amount);
              break;
          }
        }
        else if (from.Type == AccountType.Checking || from.Type == AccountType.Savings)
        {
          // if we're going from checking/savings, it is a bad thing (taking money out),
          // but its a good thing for everything else
          from.Decrease(date, t.Name, to.Id, amount);
          switch (to.Type)
          {
            case AccountType.Income:
            case AccountType.Savings:
            case AccountType.Checking:
              to.Increase(date, t.Name, from.Id, amount);
              break;
            case AccountType.CreditCard:
            case AccountType.Expense:
            case AccountType.Liability:
              to.Decrease(date, t.Name, from.Id, amount);
              break;
          }
        }
        else
        {
          from.Increase(date, t.Name, to.Id, amount);
          to.Increase(date, t.Name, from.Id, amount);
        }
      }
    }

    private static void CalculateBalance(string parentId, SimulationAccount[] accounts, out SimulationAccount[] children)
    {
      children = accounts
        .Where(a => string.Equals(a.ParentId, parentId))
        .ToArray();

      foreach (var child in children)
      {
        if (child.Type == AccountType.Group)
        {
          // this is a group account, so calculate the balance
          CalculateBalance(child.Id, accounts, out SimulationAccount[] values);
          child.Balance = values.Sum(v => v.Balance);
        }
        else
        {
          // the balance is already calculated; move on
        }
      }
    }

    public static async void Run(IWin32Window window, DateTime start, int years, string json)
    {
      var accounts = await Task.Run(() => RunSimulation(start, years, json));
      var dlg = new SimulationResultsDialog(accounts);
      dlg.Show(window);
    }
  }
}
