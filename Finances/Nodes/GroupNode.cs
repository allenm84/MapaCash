using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class GroupNode : AccountNode
  {
    public override AccountType Type => AccountType.Group;
    public override decimal Balance => Children
      .OfType<AccountNode>()
      .Sum(n => n.Balance);

    private void NodePropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      if (e.PropertyName == nameof(AccountNode.Balance))
      {
        FirePropertyChanged(e.PropertyName);
      }
    }

    protected override void OnNodeAdded(BaseTreeListNode node)
    {
      base.OnNodeAdded(node);
      node.PropertyChanged -= NodePropertyChanged;
      node.PropertyChanged += NodePropertyChanged;
    }

    protected override void OnNodeRemoved(BaseTreeListNode node)
    {
      base.OnNodeRemoved(node);
      node.PropertyChanged -= NodePropertyChanged;
    }
  }
}
