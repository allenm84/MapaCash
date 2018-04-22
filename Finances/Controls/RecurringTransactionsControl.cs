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
  public partial class RecurringTransactionsControl : DevExpress.XtraEditors.XtraUserControl
  {
    private IList<RecurringTransactionView> _transactions;

    public RecurringTransactionsControl()
    {
      InitializeComponent();
    }

    public IAccountProvider AccountProvider { get; set; }

    public IList<RecurringTransactionView> Transactions
    {
      get => _transactions;
      set
      {
        _transactions = value;
        recurringTransactionViewBindingSource.DataSource = _transactions;
      }
    }

    public void AddTransaction()
    {
      using (var dlg = new EditRecurringTransactionDialog(AccountProvider))
      {
        dlg.Text = "Add Transaction";
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          var view = dlg.View;
          recurringTransactionViewBindingSource.Add(view);
        }
      }
    }
  }
}
