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
  public partial class RecurringPeriodControl : DevExpress.XtraEditors.XtraUserControl
  {
    public RecurringPeriodControl()
    {
      InitializeComponent();

      numAmount.Properties.MinValue = 1;
      numAmount.Properties.MaxValue = decimal.MaxValue;

      numAmount.ValueChanged += numAmount_ValueChanged;
    }

    public int Period
    {
      get => (int)numAmount.Value;
      set => numAmount.Value = value;
    }

    public string Units
    {
      get => lblUnits.Text;
      set => lblUnits.Text = value;
    }

    public event EventHandler PeriodChanged;

    private void numAmount_ValueChanged(object sender, EventArgs e)
    {
      PeriodChanged?.Invoke(this, e);
    }
  }
}
