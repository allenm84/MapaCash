using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class AccountTreeNode : BaseTreeListNode
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

    public virtual decimal Balance
    {
      get => 0;
      set { }
    }
  }
}
