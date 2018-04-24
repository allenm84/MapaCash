using System;
using System.Collections.Generic;

namespace Finances
{
  public class SimulationAccount
  {
    private readonly List<SimulationAccountTransaction> _transactions;

    public SimulationAccount(AccountNode model)
    {
      _transactions = new List<SimulationAccountTransaction>();
      Model = model;
      Balance = model.Balance;
    }

    public AccountNode Model { get; }

    public string Name => Model.Name;
    public string Description => Model.Description;
    public AccountType Type => Model.Type;
    public string Id => Model.Id;
    public string ParentId => Model.ParentId;

    public decimal Balance { get; set; }

    public IList<SimulationAccountTransaction> Transactions => _transactions;

    public void Sort()
    {
      _transactions.Sort((a, b) => DateTime.Compare(a.Date, b.Date));
    }

    public void Increase(DateTime date, string name, string sourceId, decimal amount)
    {
      Balance += amount;
      _transactions.Add(new SimulationAccountTransaction(date, name, sourceId, amount, 0, Balance));
    }

    public void Decrease(DateTime date, string name, string sourceId, decimal amount)
    {
      Balance -= amount;
      _transactions.Add(new SimulationAccountTransaction(date, name, sourceId, 0, amount, Balance));
    }
  }
}