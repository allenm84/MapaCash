using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public struct DecimalValue : IEqualityComparer<DecimalValue>, IComparable<DecimalValue>
  {
    public decimal _value;
    public string _format;

    public DecimalValue(decimal value, string format)
    {
      _value = value;
      _format = format;
    }

    public static bool Equals(DecimalValue x, DecimalValue y)
    {
      return decimal.Equals(x._value, y._value);
    }

    public static int Compare(DecimalValue x, DecimalValue y)
    {
      return decimal.Compare(x._value, y._value);
    }

    public override int GetHashCode()
    {
      return _value.GetHashCode();
    }

    public override string ToString()
    {
      return _value.ToString(_format);
    }

    public override bool Equals(object obj)
    {
      if (obj is DecimalValue Interest)
      {
        return Equals(this, Interest);
      }
      return false;
    }

    bool IEqualityComparer<DecimalValue>.Equals(DecimalValue x, DecimalValue y)
    {
      return Equals(x, y);
    }

    int IEqualityComparer<DecimalValue>.GetHashCode(DecimalValue obj)
    {
      return obj.GetHashCode();
    }

    int IComparable<DecimalValue>.CompareTo(DecimalValue other)
    {
      return Compare(this, other);
    }
  }
}
