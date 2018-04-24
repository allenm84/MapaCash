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
  public partial class SimulationAccountTransactionsControl : DevExpress.XtraEditors.XtraUserControl
  {
    private IList<SimulationAccountTransaction> _transactions;

    public SimulationAccountTransactionsControl()
    {
      InitializeComponent();
    }

    public IList<SimulationAccountTransaction> Transactions
    {
      get => _transactions;
      set
      {
        _transactions = value;
        simulationAccountTransactionBindingSource.DataSource = _transactions;
      }
    }

    public Dictionary<string, SimulationAccount> Accounts { get; set; }

    private void gridViewTransactions_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
      if (Accounts != null && e.Column == colSourceId && e.Value is string id && Accounts.TryGetValue(id, out SimulationAccount account))
      {
        e.DisplayText = account.Name;
      }
    }
  }
}
