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
  public partial class RecurringFrequencyControl : DevExpress.XtraEditors.XtraUserControl
  {
    public RecurringFrequencyControl()
    {
      InitializeComponent();

      cboFrequency.Properties.Items.AddRange(RecurringTypeItem.Items.Cast<object>().ToArray());
      cboFrequency.SelectedIndexChanged += cboFrequency_SelectedIndexChanged;

      dtStart.DateTime = DateTime.Today;
      dtStart.DateTimeChanged += dtStart_DateTimeChanged;
    }

    [Browsable(false)]
    public RecurringTypeItem SelectedFrequency
    {
      get => cboFrequency.SelectedItem as RecurringTypeItem;
      set => cboFrequency.SelectedItem = value;
    }

    public RecurringType Frequency
    {
      get => SelectedFrequency?.Value ?? RecurringType.Monthly;
      set
      {
        if (RecurringTypeItem.TryGetItem(value, out RecurringTypeItem item))
        {
          SelectedFrequency = item;
        }
      }
    }

    public DateTime StartDate
    {
      get => dtStart.DateTime.Date;
      set => dtStart.DateTime = value.Date;
    }

    public event EventHandler FrequencyChanged;
    public event EventHandler StartDateChanged;

    private void cboFrequency_SelectedIndexChanged(object sender, EventArgs e)
    {
      FrequencyChanged?.Invoke(this, e);
    }

    private void dtStart_DateTimeChanged(object sender, EventArgs e)
    {
      StartDateChanged?.Invoke(this, e);
    }
  }
}
