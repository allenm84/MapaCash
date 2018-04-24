using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class RecurringDayOfMonthItem
  {
    static readonly Dictionary<RecurringDayOfMonth, string> RecurringDayOfMonthText;
    static readonly Dictionary<RecurringDayOfMonth, RecurringDayOfMonthItem> RecurringDayOfMonthItems;
    static RecurringDayOfMonthItem()
    {
      RecurringDayOfMonthText = Enum
        .GetValues(typeof(RecurringDayOfMonth))
        .Cast<RecurringDayOfMonth>()
        .ToDictionary(k => k, v => $"{v}".Substring(1));

      RecurringDayOfMonthItems = RecurringDayOfMonthText.Keys
        .Select(t => new RecurringDayOfMonthItem(t))
        .ToDictionary(i => i.Value);
    }

    public static IEnumerable<RecurringDayOfMonthItem> Items => RecurringDayOfMonthItems.Values;

    public static bool TryGetItem(RecurringDayOfMonth type, out RecurringDayOfMonthItem item)
    {
      return RecurringDayOfMonthItems.TryGetValue(type, out item);
    }

    private RecurringDayOfMonthItem(RecurringDayOfMonth type)
    {
      Value = type;
      Text = RecurringDayOfMonthText[type];
    }

    public RecurringDayOfMonth Value { get; }
    public string Text { get; }

    public override string ToString() => Text;
  }
}
