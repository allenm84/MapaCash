using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class RecurringTransactionView
  {
    private readonly RecurringTransaction _model;

    public RecurringTransactionView(RecurringTransaction model)
    {
      _model = model;
      Frequency = GetFrequency(_model);
      Next = _model.GetNextDate(out bool _);
    }

    public string Name { get; }
    public string Frequency { get; }
    public DateTime Next { get; }

    public static string GetFrequency(RecurringTransaction transaction)
    {
      string frequency;
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
  }
}
