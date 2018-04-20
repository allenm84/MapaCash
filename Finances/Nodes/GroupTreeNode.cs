using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class GroupTreeNode : AccountTreeNode
  {
    public override decimal Balance => Children
      .OfType<AccountTreeNode>()
      .Sum(n => n.Balance);
  }
}
