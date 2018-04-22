using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public static class DateMath
  {
    public static DateTime[] GetWeek(DateTime start)
    {
      return new DateTime[]
      {
        start,
        start.AddDays(1),
        start.AddDays(2),
        start.AddDays(3),
        start.AddDays(4),
        start.AddDays(5),
        start.AddDays(6),
      };
    }

    public static DateTime GetDate(int day, DateTime seed)
    {
      var days = DateTime.DaysInMonth(seed.Year, seed.Month);
      return new DateTime(seed.Year, seed.Month, Math.Min(day, days));
    }
  }
}
