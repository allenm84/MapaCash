using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Finances
{
  public partial class RecurringWeekDaysControl : DevExpress.XtraEditors.XtraUserControl
  {
    private readonly Dictionary<RecurringDayOfWeek, CheckEdit> _checkBoxLookUp;

    public RecurringWeekDaysControl()
    {
      InitializeComponent();
      _checkBoxLookUp = new Dictionary<RecurringDayOfWeek, CheckEdit>
      {
        { RecurringDayOfWeek.Sunday, chkSunday },
        { RecurringDayOfWeek.Monday, chkMonday },
        { RecurringDayOfWeek.Tuesday, chkTuesday },
        { RecurringDayOfWeek.Wednesday, chkWednesday },
        { RecurringDayOfWeek.Thursday, chkThursday },
        { RecurringDayOfWeek.Friday, chkFriday },
        { RecurringDayOfWeek.Saturday, chkSaturday },
      };

      foreach (var kvp in _checkBoxLookUp)
      {
        kvp.Value.CheckedChanged += chkDayOfWeek_CheckedChanged;
      }
    }

    public RecurringDayOfWeek Days
    {
      get
      {
        return _checkBoxLookUp
          .Where(k => k.Value.Checked)
          .Select(k => k.Key)
          .Aggregate(RecurringDayOfWeek.None, (a, b) => a | b);
      }
      set
      {
        foreach (var k in _checkBoxLookUp)
        {
          k.Value.Checked = value.HasFlag(k.Key);
        }
      }
    }

    public event EventHandler DaysChanged;

    private void chkDayOfWeek_CheckedChanged(object sender, EventArgs e)
    {
      DaysChanged?.Invoke(this, e);
    }
  }
}
