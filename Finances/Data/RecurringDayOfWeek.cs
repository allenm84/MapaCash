using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [Flags]
  public enum RecurringDayOfWeek : int
  {
    None = 0,
    Sunday = 1 << 0,
    Monday = 1 << 1,
    Tuesday = 1 << 2,
    Wednesday = 1 << 3,
    Thursday = 1 << 4,
    Friday = 1 << 5,
    Saturday = 1 << 6,
    Weekdays = Monday | Tuesday| Wednesday | Thursday | Friday,
    Weekends = Sunday | Saturday,
    All = Weekdays | Weekends,
  }
}
