using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;

namespace Finances
{
  public partial class MainForm : BaseForm, IAccountProvider
  {
    private Dictionary<AccountType, int> _accountImageIndex = new Dictionary<AccountType, int>
    {
      { AccountType.Checking, 4 },
      { AccountType.CreditCard, 2 },
      { AccountType.Expense, 5 },
      { AccountType.Liability, 6 },
      { AccountType.Income, 7 },
      { AccountType.Savings, 3 },
    };

    private TreeListNode _targetNode;

    public MainForm()
    {
      InitializeComponent();
    }

    IEnumerable<AccountNode> IAccountProvider.Accounts => nodeBindingSource
      .OfType<AccountNode>()
      .Where(n => !(n is GroupNode));

    private bool TryGetTarget(out AccountNode target)
    {
      target = null;

      var row = treeAccounts.GetDataRecordByNode(_targetNode);
      if (row is GroupNode node)
      {
        target = node;
      }

      return (target != null);
    }

    private void treeAccounts_MouseUp(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Right) != 0)
      {
        _targetNode = treeAccounts.GetNodeAt(e.Location);
        popupMenu1.ShowPopup(Cursor.Position);
      }
    }

    private void btnNewGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      var group = new GroupNode();
      group.Name = "<New Group>";
      if (TryGetTarget(out AccountNode parent))
      {
        parent.Add(group);
      }

      nodeBindingSource.Add(group);
    }

    private void btnNewAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      using (var dlg = new EditAccountDialog())
      {
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          var node = new AccountNode
          {
            Balance = dlg.Balance,
            Description = dlg.Description,
            Name = dlg.AccountName,
            Type = dlg.Type
          };

          if (TryGetTarget(out AccountNode parent))
          {
            parent.Add(node);
          }

          nodeBindingSource.Add(node);
        }
      }
    }

    private void btnRecurringTransactions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      
    }

    private void treeAccounts_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
    {
      _targetNode = e.Node;
    }

    private void treeAccounts_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
    {
      var data = treeAccounts.GetDataRecordByNode(e.Node);
      if (data is AccountNode node)
      {
        if (node is GroupNode)
        {
          e.NodeImageIndex = e.Node.Expanded ? 1 : 0;
        }
        else
        {
          e.NodeImageIndex = _accountImageIndex[node.Type];
        }
      }
    }
  }
}
