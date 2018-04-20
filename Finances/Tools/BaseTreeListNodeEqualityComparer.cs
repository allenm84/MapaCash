using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public sealed class BaseTreeListNodeEqualityComparer : IEqualityComparer<BaseTreeListNode>
  {
    private BaseTreeListNodeEqualityComparer() { }

    bool IEqualityComparer<BaseTreeListNode>.Equals(BaseTreeListNode x, BaseTreeListNode y)
    {
      return string.Equals(x?.Id, y?.Id);
    }

    int IEqualityComparer<BaseTreeListNode>.GetHashCode(BaseTreeListNode obj)
    {
      return obj?.Id.GetHashCode() ?? int.MinValue;
    }

    static readonly Lazy<BaseTreeListNodeEqualityComparer> sInstance;
    static BaseTreeListNodeEqualityComparer()
    {
      sInstance = new Lazy<BaseTreeListNodeEqualityComparer>(CreateNew, true);
      BaseTreeListNodeEqualityComparer CreateNew() => new BaseTreeListNodeEqualityComparer();
    }

    public static BaseTreeListNodeEqualityComparer Instance => sInstance.Value;
  }
}
