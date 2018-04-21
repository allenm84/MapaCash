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
using DevExpress.XtraLayout;

namespace Finances
{
  public partial class RecurringDayOfMonthControl : DevExpress.XtraEditors.XtraUserControl
  {
    const string DayOfMonth1SemiMonthlyText = "First on the:";
    const string DayOfMonth1MonthlyText = "On the:";

    private bool _isSemiMonthly = true;

    public RecurringDayOfMonthControl()
    {
      InitializeComponent();

      cboDayOfMonth1.Properties.Items.AddRange(RecurringDayOfMonthItem.Items.AsArray());
      cboDayOfMonth1.SelectedIndex = 0;
      cboDayOfMonth1.SelectedIndexChanged += cboDayOfMonth_SelectedIndexChanged;

      cboDayOfMonth2.Properties.Items.AddRange(RecurringDayOfMonthItem.Items.AsArray());
      cboDayOfMonth2.SelectedIndex = 0;
      cboDayOfMonth2.SelectedIndexChanged += cboDayOfMonth_SelectedIndexChanged;
    }

    public bool IsSemiMonthly
    {
      get => _isSemiMonthly;
      set => SetIsSemiMonthly(value);
    }

    [Browsable(false)]
    public RecurringDayOfMonthItem SelectedDayOfMonth1
    {
      get => cboDayOfMonth1.SelectedItem as RecurringDayOfMonthItem;
      set => cboDayOfMonth1.SelectedItem = value;
    }

    [Browsable(false)]
    public RecurringDayOfMonthItem SelectedDayOfMonth2
    {
      get => cboDayOfMonth2.SelectedItem as RecurringDayOfMonthItem;
      set => cboDayOfMonth2.SelectedItem = value;
    }

    public RecurringDayOfMonth DayOfMonth1
    {
      get => SelectedDayOfMonth1?.Value ?? RecurringDayOfMonth.d1st;
      set
      {
        if (RecurringDayOfMonthItem.TryGetItem(value, out RecurringDayOfMonthItem item))
        {
          SelectedDayOfMonth1 = item;
        }
      }
    }

    public RecurringDayOfMonth DayOfMonth2
    {
      get => SelectedDayOfMonth2?.Value ?? RecurringDayOfMonth.d1st;
      set
      {
        if (RecurringDayOfMonthItem.TryGetItem(value, out RecurringDayOfMonthItem item))
        {
          SelectedDayOfMonth2 = item;
        }
      }
    }

    public event EventHandler DayOfMonthChanged;
    public event EventHandler IsSemiMonthlyChanged;

    private void SetLayoutVisible(BaseLayoutItem item, bool visible)
    {
      item.Visibility = visible
        ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
    }

    private void SetIsSemiMonthly(bool value)
    {
      if (_isSemiMonthly != value)
      {
        _isSemiMonthly = value;
        SetLayoutVisible(layoutControlItem3, _isSemiMonthly);
        SetLayoutVisible(layoutControlItem4, _isSemiMonthly);
        labelControl1.Text = _isSemiMonthly
          ? DayOfMonth1SemiMonthlyText
          : DayOfMonth1MonthlyText;

        IsSemiMonthlyChanged?.Invoke(this, EventArgs.Empty);
      }
    }

    private void cboDayOfMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
      DayOfMonthChanged?.Invoke(this, e);
    }
  }
}
