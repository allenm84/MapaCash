using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class RecurringTransaction
  {
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public decimal Interest { get; set; }
    public RecurringValueType ValueType { get; set; } = RecurringValueType.Amount;

    public string FromAccountId { get; set; }
    public string ToAccountId { get; set; }

    public DateTime StartDate { get; set; } = DateTime.Today;
    public DateTime EndDate { get; set; }
    public int Period { get; set; } = 1;
    public int MaxOccurrences { get; set; } = 0;
    public RecurringDayOfWeek Days { get; set; } = RecurringDayOfWeek.None;
    public RecurringEndType EndType { get; set; } = RecurringEndType.Never;
    public RecurringType Type { get; set; } = RecurringType.Once;
    public RecurringDayOfMonth DayOfMonth { get; set; } = RecurringDayOfMonth.d1st;
    public RecurringDayOfMonth DayOfMonth2 { get; set; } = RecurringDayOfMonth.d1st;
  }
}
