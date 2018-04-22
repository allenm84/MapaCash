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
      AddAccounts(cboFrom);
      AddAccounts(cboTo);

      txtName.DataBindings.Add("Text", _transaction, "Name");
      numAmount.DataBindings.Add("Value", _transaction, "Amount");
      cboFrom.DataBindings.Add("EditValue", _transaction, "FromAccountId");
      cboTo.DataBindings.Add("EditValue", _transaction, "ToAccountId");
    }

    private void AddAccounts(LookUpEdit lookUpEdit)
    {
      var cbo = lookUpEdit.Properties;
      cbo.DataSource = _provider.Accounts
        .Select(a => new { Value = a.Id, Display = a.Name })
        .ToList();
      cbo.DisplayMember = "Display";
      cbo.ValueMember = "Value";
      cbo.Columns.Add(new LookUpColumnInfo("Display")
      {
        SortOrder = DevExpress.Data.ColumnSortOrder.Ascending,
        Visible = true,
      });
    }

    private void txtRecurrence_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      using (var dlg = new EditRecurrencePatternDialog())
      {
        dlg.Text = "Edit Recurrence";
        dlg.InitFrom(_transaction);
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          _transaction.OverwriteWith(dlg.Model);
          txtRecurrence.Text = RecurringTransactionView.GetFrequency(_transaction);
        }
      }
    }
  }
}
