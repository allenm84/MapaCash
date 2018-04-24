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
    private IList<RecurringTransaction> _transactions;

    public RecurringTransactionsControl()
    {
      InitializeComponent();
    }

    public IAccountProvider AccountProvider { get; set; }

    public IList<RecurringTransaction> Transactions
    {
      get => _transactions;
      set
      {
        _transactions = value;
        recurringTransactionBindingSource.DataSource = _transactions;
      }
    }

    public void BeginUpdate()
    {
      gridViewTransactions.BeginDataUpdate();
    }

    public void EndUpdate()
    {
      gridViewTransactions.EndDataUpdate();
    }

    public void AddTransaction()
    {
      using (var dlg = new EditRecurringTransactionDialog(AccountProvider))
      {
        dlg.Text = "Add Transaction";
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          recurringTransactionBindingSource.Add(dlg.Transaction);
        }
      }
    }

    public void DuplicateTransaction()
    {
      var row = gridViewTransactions.FocusedRowHandle;
      if (gridViewTransactions.GetRow(row) is RecurringTransaction transaction)
      {
        var duplicated = new RecurringTransaction();
        duplicated.OverwriteWith(transaction);
        duplicated.Name = $"Copy of {transaction.Name}";
        recurringTransactionBindingSource.Add(duplicated);
      }
    }

    public void EditTransaction()
    {
      var row = gridViewTransactions.FocusedRowHandle;
      if (gridViewTransactions.GetRow(row) is RecurringTransaction transaction)
      {
        using (var dlg = new EditRecurringTransactionDialog(AccountProvider))
        {
          dlg.Text = "Edit Transaction";
          dlg.Transaction = transaction;
          if (dlg.ShowDialog(this) == DialogResult.OK)
          {
            transaction.OverwriteWith(dlg.Transaction);
            gridViewTransactions.RefreshRow(row);
          }
        }
      }
    }

    public void RemoveTransaction()
    {
      if (gridViewTransactions.SelectedRowsCount > 0 && this.Confirm("Are you sure you want to remove the selected transaction?", "Remove"))
      {
        gridViewTransactions.DeleteSelectedRows();
      }
    }

    private void gridViewTransactions_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    {
      if (e.IsGetData && e.Row is RecurringTransaction transaction)
      {
        if (e.Column == colFrequency)
        {
          e.Value = transaction.GetFrequency();
        }
        else if (e.Column == colNext)
        {
          e.Value = transaction.GetNextDate(out bool _);
        }
        else if (e.Column == colValue)
        {
          e.Value = transaction.GetValue();
        }
      }
    }

    private void gridViewTransactions_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
      if ((e.Column == colFromAccountId || e.Column == colToAccountId) && e.Value is string id)
      {
        foreach (var account in AccountProvider.Accounts)
        {
          if (string.Equals(account.Id, id))
          {
            e.DisplayText = account.Name;
          }
        }
      }
      else if (e.Column == colValue && e.Value is decimal value)
      {
        var index = e.ListSourceRowIndex;
        var row = gridViewTransactions.GetRowHandle(index);
        if (gridViewTransactions.GetRow(row) is RecurringTransaction transaction)
        {
          var format = transaction.ValueType == RecurringValueType.Amount
            ? "c2"
            : "p2";

          e.DisplayText = value.ToString(format);
        }
      }
    }

    private void gridTransactions_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != 0)
      {
        var info = gridViewTransactions.CalcHitInfo(e.Location);
        if (info.InRowCell)
        {
          EditTransaction();
        }
      }
    }

    private void gridViewTransactions_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        RemoveTransaction();
      }
    }
  }
}
