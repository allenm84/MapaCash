using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class AccountNode : BaseTreeListNode
  {
    private string _name;
    public string Name
    {
      get => _name;
      set
      {
        _name = value;
        FirePropertyChanged();
      }
    }

    private string _description;
    public string Description
    {
      get => _description;
      set
      {
        _description = value;
        FirePropertyChanged();
      }
    }

    private decimal _balance;
    public virtual decimal Balance
    {
      get => _balance;
      set
      {
        _balance = value;
        FirePropertyChanged();
      }
    }

    private AccountType _type;
    public virtual AccountType Type
    {
      get => _type;
      set
      {
        _type = value;
        FirePropertyChanged();
      }
    }
  }
}
