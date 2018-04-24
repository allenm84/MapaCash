using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public static class Recurrence
  {
    public static object GetValue(this RecurringTransaction transaction)
    {
      if (transaction.ValueType == RecurringValueType.Interest)
      {
        return transaction.Interest;
      }
      else
      {
        return transaction.Amount;
      }
    }

    public static string GetFrequency(this RecurringTransaction transaction)
    {
      string frequency = string.Empty;
      switch (transaction.Type)
      {
        case RecurringType.Daily:
          frequency = $"Daily{GetPeriod()}";
          break;
        case RecurringType.Monthly:
          frequency = $"Monthly{GetPeriod()}: {(int)transaction.DayOfMonth}";
          break;
        case RecurringType.Once:
          frequency = "Once";
          break;
        case RecurringType.SemiMonthly:
          frequency = $"Semi-monthly{GetPeriod()}: {string.Join(", ", GetDays())}";
          break;
        case RecurringType.Weekly:
          frequency = $"Weekly{GetPeriod()}: {GetDaysOfWeek()}";
          break;
      }
      return frequency;

      string GetPeriod()
      {
        if (transaction.Period > 1)
          return $" (x{transaction.Period})";
        return string.Empty;
      }

      IEnumerable<int> GetDays()
      {
        yield return (int)transaction.DayOfMonth;
        yield return (int)transaction.DayOfMonth2;
      }

      string GetDaysOfWeek()
      {
        var days = new char[7];
        for (int i = 0; i < days.Length; ++i)
        {
          var day = (RecurringDayOfWeek)(1 << i);
          days[i] = transaction.Days.HasFlag(day)
            ? $"{day}"[0]
            : '-';
        }
        return new string(days);
      }
    }

    public static void OverwriteWith(this RecurringTransaction target, RecurringTransaction data)
    {
      target.Name = data.Name;
      target.Amount = data.Amount;
      target.Interest = data.Interest;
      target.ValueType = data.ValueType;

      target.FromAccountId = data.FromAccountId;
      target.ToAccountId = data.ToAccountId;
      
      target.DayOfMonth = data.DayOfMonth;
      target.DayOfMonth2 = data.DayOfMonth2;
      target.Days = data.Days;
      target.EndDate = data.EndDate;
      target.EndType = data.EndType;
      target.MaxOccurrences = data.MaxOccurrences;
      target.Period = data.Period;
      target.StartDate = data.StartDate;
      target.Type = data.Type;
    }

    public static bool Contains(this RecurringDayOfWeek days, DayOfWeek day)
    {
      var shifts = (int)day;
      var value = (RecurringDayOfWeek)(1 << shifts);
      return days.HasFlag(value);
    }

    public static DateTime GetNextDate(this RecurringTransaction model, out bool isValid)
    {
      var date = model.StartDate;
      isValid = true;

      switch (model.Type)
      {
        case RecurringType.Once:
        case RecurringType.Daily:
          {
            // the start date is the current date
            break;
          }
        case RecurringType.SemiMonthly:
        case RecurringType.Monthly:
          {
            // the start date is the minimum date to start
            var seed = date.FirstOfMonth();
            var day = (int)model.DayOfMonth;
            var desiredDate = DateTime.MinValue;
            do
            {
              desiredDate = DateMath.GetDate(day, seed);
              seed = seed.AddMonths(1);
            } while (model.StartDate > desiredDate);
            date = desiredDate;
            break;
          }
        case RecurringType.Weekly:
          {
            // the start date is the minimum date to start
            if (model.Days != RecurringDayOfWeek.None)
            {
              while (!model.Days.Contains(date.DayOfWeek))
              {
                date = date.AddDays(1);
              }
            }
            else
            {
              isValid = false;
            }
            break;
          }
      }

      return date;
    }

    public static IEnumerable<DateTime> GenerateDates(this RecurringTransaction model, DateTime date, DateTime max)
    {
      var isDay1 = true;

      var week = new Queue<DateTime>(DateMath.GetWeek(date));
      week.Dequeue();

      var dateCount = 0;
      while (date < max)
      {
        if (model.EndType == RecurringEndType.ByDate && date.Date >= model.EndDate)
        {
          break;
        }

        yield return date.Date;
        ++dateCount;

        if (model.Type == RecurringType.Once)
        {
          // that's it
          break;
        }

        if (model.EndType == RecurringEndType.ByCount && dateCount >= model.MaxOccurrences)
        {
          break;
        }

        switch (model.Type)
        {
          case RecurringType.Daily:
            {
              date = date.AddDays(model.Period);
              break;
            }
          case RecurringType.Monthly:
            {
              var seed = date.AddMonths(model.Period);
              date = DateMath.GetDate((int)model.DayOfMonth, seed);
              break;
            }
          case RecurringType.SemiMonthly:
            {
              if (isDay1)
              {
                // the current date is day1, so get day2
                date = DateMath.GetDate((int)model.DayOfMonth2, date);
                isDay1 = false;
              }
              else
              {
                // get day1 again
                var seed = date.AddMonths(model.Period);
                date = DateMath.GetDate((int)model.DayOfMonth, seed);
                isDay1 = true;
              }
              break;
            }
          case RecurringType.Weekly:
            {
              while (week.Count > 0)
              {
                date = week.Dequeue();
                if (model.Days.Contains(date.DayOfWeek))
                {
                  break;
                }
              }

              if (week.Count == 0 && !model.Days.Contains(date.DayOfWeek))
              {
                // we've gone through the week; no more dates left
                // so start over again at next week
                date = date.AddDays(-6).AddDays(7 * model.Period);
                while (!model.Days.Contains(date.DayOfWeek))
                {
                  date = date.AddDays(1);
                }

                week = new Queue<DateTime>(DateMath.GetWeek(date));
                week.Dequeue();
              }
              break;
            }
        }
      }
    }
  }
}
