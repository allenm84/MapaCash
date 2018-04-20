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
    private readonly HashSet<BaseTreeListNode> _children;
    private BaseTreeListNode _parent;

    public BaseTreeListNode()
    {
      _children = new HashSet<BaseTreeListNode>(BaseTreeListNodeEqualityComparer.Instance);
      Id = IdGenerator.Next;
    }

    public string Id { get; }
    public string ParentId => _parent?.Id;

    public BaseTreeListNode Parent => _parent;

    public IEnumerable<BaseTreeListNode> Children => _children;

    public void Add(BaseTreeListNode node)
    {
      if (_children.Add(node))
      {
        node._parent = this;
      }
    }

    public bool Remove(BaseTreeListNode node)
    {
      if (node == null || !string.Equals(node.ParentId, Id))
      {
        return false;
      }

      if (_children.Remove(node))
      {
        node._parent = null;
        return true;
      }

      return false;
    }
  }
}
