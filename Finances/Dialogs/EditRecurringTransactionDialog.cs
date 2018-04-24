using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace Finances
{
  public partial class EditRecurringTransactionDialog : BaseForm
  {
    private readonly IAccountProvider _provider;
    private readonly RecurringTransaction _transaction;

    public EditRecurringTransactionDialog(IAccountProvider provider)
    {
      _provider = provider;
      _transaction = new RecurringTransaction();

      InitializeComponent();
      accountNodeBindingSource.DataSource = provider.Accounts;

      txtName.DataBindings.Add("Text", _transaction, "Name");
      numAmount.DataBindings.Add("Value", _transaction, "Amount");
      numInterest.DataBindings.Add("Value", _transaction, "Interest");
      cboFrom.DataBindings.Add("EditValue", _transaction, "FromAccountId");
      cboTo.DataBindings.Add("EditValue", _transaction, "ToAccountId");
    }

    public RecurringTransaction Transaction
    {
      get => _transaction;
      set => _transaction.OverwriteWith(value);
    }

    private void AddAccountTo(GridLookUpEdit cboAccount)
    {
      var account = _provider.AddNewAccount();
      if (account != null && account.Type != AccountType.Group)
      {
        cboAccount.EditValue = account.Id;
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      txtRecurrence.Text = _transaction.GetFrequency();

      optInterest.Checked = (_transaction.ValueType == RecurringValueType.Interest);
      optAmount.Checked = (_transaction.ValueType == RecurringValueType.Amount);
    }

    private void txtRecurrence_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      using (var dlg = new EditRecurrencePatternDialog(_transaction))
      {
        dlg.Text = "Edit Recurrence";
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          _transaction.OverwriteWith(dlg.Transaction);
          txtRecurrence.Text = _transaction.GetFrequency();
        }
      }
    }

    private void cboAccount_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Plus && sender is GridLookUpEdit cboAccount)
      {
        accountNodeBindingSource.ResetBindings(true);
        AddAccountTo(cboAccount);
      }
    }

    private void gridViewAccount_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
    {
      if (sender is GridView view)
      {
        var index = e.ListSourceRow;
        var row = view.GetRowHandle(index);
        if (view.GetRow(row) is AccountNode node && node.Type == AccountType.Group)
        {
          e.Visible = false;
          e.Handled = true;
        }
      }
    }

    private void optValueType_CheckedChanged(object sender, EventArgs e)
    {
      numAmount.Enabled = optAmount.Checked;
      numInterest.Enabled = optInterest.Checked;
      _transaction.ValueType = optInterest.Checked 
        ? RecurringValueType.Interest 
        : RecurringValueType.Amount;
    }
  }
}
