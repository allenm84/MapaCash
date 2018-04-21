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
  public partial class RecurringEndTypeControl : DevExpress.XtraEditors.XtraUserControl
  {
    public RecurringEndTypeControl()
    {
      InitializeComponent();

      numFor.Properties.MinValue = 1;
      numFor.Properties.MaxValue = decimal.MaxValue;

      dtUntil.DataBindings.Add("Enabled", optUntil, "Checked");
      numFor.DataBindings.Add("Enabled", optFor, "Checked");
      optForever.Checked = true;

      optForever.CheckedChanged += optEndType_CheckedChanged;
      optUntil.CheckedChanged += optEndType_CheckedChanged;
      optFor.CheckedChanged += optEndType_CheckedChanged;

      dtUntil.DateTime = DateTime.Today.Date;
      dtUntil.DateTimeChanged += dtUntil_DateTimeChanged;

      numFor.ValueChanged += numFor_ValueChanged;
    }

    public RecurringEndType EndType
    {
      get
      {
        if (optUntil.Checked)
          return RecurringEndType.ByDate;

        if (optFor.Checked)
          return RecurringEndType.ByCount;

        return RecurringEndType.Never;
      }
      set
      {
        optForever.Checked = (value == RecurringEndType.Never);
        optUntil.Checked = (value == RecurringEndType.ByDate);
        optFor.Checked = (value == RecurringEndType.ByCount);
      }
    }

    [Browsable(false)]
    public DateTime UntilDate
    {
      get => dtUntil.DateTime.Date;
      set => dtUntil.DateTime = value.Date;
    }

    public int MaxOccurrences
    {
      get => (int)numFor.Value;
      set => numFor.Value = value;
    }

    public event EventHandler EndTypeChanged;
    public event EventHandler UntilDateChanged;
    public event EventHandler MaxOccurrencesChanged;

    private void optEndType_CheckedChanged(object sender, EventArgs e)
    {
      EndTypeChanged?.Invoke(this, e);
    }

    private void dtUntil_DateTimeChanged(object sender, EventArgs e)
    {
      UntilDateChanged?.Invoke(this, e);
    }

    private void numFor_ValueChanged(object sender, EventArgs e)
    {
      MaxOccurrencesChanged?.Invoke(this, e);
    }
  }
}
