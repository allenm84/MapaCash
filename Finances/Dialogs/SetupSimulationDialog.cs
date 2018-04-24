using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Finances
{
  public partial class SetupSimulationDialog : BaseForm
  {
    public SetupSimulationDialog()
    {
      InitializeComponent();
      Start = DateTime.Today;
      Years = 10;
    }

    public DateTime Start
    {
      get => dtStart.DateTime;
      set => dtStart.DateTime = value.Date;
    }

    public int Years
    {
      get => (int)numYears.Value;
      set => numYears.Value = value;
    }
  }
}