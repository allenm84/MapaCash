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
  public partial class EditAccountDialog : BaseForm
  {
    private readonly IAccountProvider _provider;

    public EditAccountDialog(IAccountProvider provider)
    {
      _provider = provider;
      InitializeComponent();
      cboType.Properties.Items.AddRange(AccountTypeItem.Items.AsArray());
      cboType.SelectedIndex = 0;
      cboType.SelectedIndexChanged += cboType_SelectedIndexChanged;
      accountNodeBindingSource.DataSource = provider.Accounts;
    }

    public string AccountName
    {
      get => txtName.Text;
      set => txtName.Text = value;
    }

    public string Description
    {
      get => txtDescription.Text;
      set => txtDescription.Text = value;
    }

    public AccountTypeItem SelectedItem
    {
      get => cboType.SelectedItem as AccountTypeItem;
      set => cboType.SelectedItem = value;
    }

    public AccountType Type
    {
      get => SelectedItem?.Value ?? AccountType.Checking;
      set
      {
        if (AccountTypeItem.TryGetItem(value, out AccountTypeItem item))
        {
          cboType.EditValue = item;
        }
      }
    }

    public decimal Balance
    {
      get => numBalance.Value;
      set => numBalance.Value = value;
    }

    public string ParentId
    {
      get => cboParentAccount.EditValue as string;
      set => cboParentAccount.EditValue = value;
    }

    private void cboType_SelectedIndexChanged(object sender, EventArgs e)
    {
      numBalance.Enabled = (Type != AccountType.Group);
    }

    private void gridViewParentAccount_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
    {
      var index = e.ListSourceRow;
      var row = gridViewParentAccount.GetRowHandle(index);
      if (gridViewParentAccount.GetRow(row) is AccountNode node && node.Type != AccountType.Group)
      {
        e.Visible = false;
        e.Handled = true;
      }
    }
  }
}