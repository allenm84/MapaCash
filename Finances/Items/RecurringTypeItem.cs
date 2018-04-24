using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class RecurringTypeItem
  {
    static readonly Dictionary<RecurringType, string> RecurringTypeText = new Dictionary<RecurringType, string>
    {
      { RecurringType.Once, "Once" },
      { RecurringType.Daily, "Daily" },
      { RecurringType.Weekly, "Weekly" },
      { RecurringType.SemiMonthly, "Semi-Monthly" },
      { RecurringType.Monthly, "Monthly" },
    };

    static readonly Dictionary<RecurringType, RecurringTypeItem> RecurringTypeItems;
    static RecurringTypeItem()
    {
      RecurringTypeItems = RecurringTypeText.Keys
        .Select(t => new RecurringTypeItem(t))
        .ToDictionary(i => i.Value);
    }

    public static IEnumerable<RecurringTypeItem> Items => RecurringTypeItems.Values;

    public static bool TryGetItem(RecurringType type, out RecurringTypeItem item)
    {
      return RecurringTypeItems.TryGetValue(type, out item);
    }

    private RecurringTypeItem(RecurringType type)
    {
      Value = type;
      Text = RecurringTypeText[type];
    }

    public RecurringType Value { get; }
    public string Text { get; }

    public override string ToString() => Text;
  }
}
