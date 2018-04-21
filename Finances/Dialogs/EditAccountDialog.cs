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
    public EditAccountDialog()
    {
      InitializeComponent();
      cboType.Properties.Items.AddRange(AccountTypeItem.Items.AsArray());
      cboType.SelectedIndex = 0;
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
  }
}