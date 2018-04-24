using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public abstract class BaseTreeListNode : BaseNotifyPropertyChanged
  {
    public string Id { get; set; } = $"{Guid.NewGuid():N}";
    public string ParentId { get; set; }

    public void Add(BaseTreeListNode node)
    {
      node.ParentId = Id;
    }

    public bool Remove(BaseTreeListNode node)
    {
      if (node == null || !string.Equals(node.ParentId, Id))
      {
        return false;
      }

      node.ParentId = null;
      return true;
    }
  }
}
