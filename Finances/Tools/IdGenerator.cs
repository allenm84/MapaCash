using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Finances
{
  public static class IdGenerator
  {
    private static long sValue = long.MinValue;
    public static string Next => Generate();
    private static string Generate()
    {
      return $"{Interlocked.Increment(ref sValue)}";
    }
  }
}
