using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class AccountTypeItem
  {
    static readonly Dictionary<AccountType, string> AccountTypeText = new Dictionary<AccountType, string>
    {
      { AccountType.Checking, "Checking" },
      { AccountType.CreditCard, "Credit Card" },
      { AccountType.Expense, "Expense" },
      { AccountType.Income, "Income" },
      { AccountType.Liability, "Liability" },
      { AccountType.Savings, "Savings" },
      { AccountType.Group, "Group" },
    };

    static readonly Dictionary<AccountType, AccountTypeItem> AccountTypeItems;
    static AccountTypeItem()
    {
      AccountTypeItems = AccountTypeText.Keys
        .Select(t => new AccountTypeItem(t))
        .ToDictionary(i => i.Value);
    }

    public static IEnumerable<AccountTypeItem> Items => AccountTypeItems.Values;

    public static bool TryGetItem(AccountType type, out AccountTypeItem item)
    {
      return AccountTypeItems.TryGetValue(type, out item);
    }

    private AccountTypeItem(AccountType type)
    {
      Value = type;
      Text = AccountTypeText[type];
    }

    public AccountType Value { get; }
    public string Text { get; }

    public override string ToString() => Text;
  }
}
