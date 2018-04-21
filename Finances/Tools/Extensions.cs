using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraScheduler;

namespace Finances
{
  public static class Extensions
  {
    public static WeekDays ToWeekDays(this RecurringDayOfWeek days)
    {
      var list = new List<WeekDays>();
      if ((days & RecurringDayOfWeek.Sunday) != 0)
      {
        list.Add(WeekDays.Sunday);
      }
      if ((days & RecurringDayOfWeek.Monday) != 0)
      {
        list.Add(WeekDays.Monday);
      }
      if ((days & RecurringDayOfWeek.Tuesday) != 0)
      {
        list.Add(WeekDays.Tuesday);
      }
      if ((days & RecurringDayOfWeek.Wednesday) != 0)
      {
        list.Add(WeekDays.Wednesday);
      }
      if ((days & RecurringDayOfWeek.Thursday) != 0)
      {
        list.Add(WeekDays.Thursday);
      }
      if ((days & RecurringDayOfWeek.Friday) != 0)
      {
        list.Add(WeekDays.Friday);
      }
      if ((days & RecurringDayOfWeek.Saturday) != 0)
      {
        list.Add(WeekDays.Saturday);
      }
      return list.Aggregate((a, b) => a | b);
    }

    public static object[] AsArray<T>(this IEnumerable<T> items)
    {
      return items.Cast<object>().ToArray();
    }
  }
}
