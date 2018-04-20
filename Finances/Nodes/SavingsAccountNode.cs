using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class SavingsAccountNode : AccountTreeNode
  {
    private decimal _balance = 0;

    public override decimal Balance
    {
      get => _balance;
      set
      {
        _balance = value;
        FirePropertyChanged();
      }
    }
  }
}
