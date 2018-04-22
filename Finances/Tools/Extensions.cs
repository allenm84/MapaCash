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
    public static bool Contains(this RecurringDayOfWeek days, DayOfWeek day)
    {
      var shifts = (int)day;
      var value = (RecurringDayOfWeek)(1 << shifts);
      return days.HasFlag(value);
    }

    public static DateTime FirstOfMonth(this DateTime date)
    {
      return new DateTime(date.Year, date.Month, 1);
    }

    public static DateTime EndOfMonth(this DateTime date)
    {
      var days = DateTime.DaysInMonth(date.Year, date.Month);
      return new DateTime(date.Year, date.Month, days);
    }

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
