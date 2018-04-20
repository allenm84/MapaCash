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
  public partial class MainForm : BaseForm
  {
    private TreeListNode _targetNode;

    public MainForm()
    {
      InitializeComponent();
    }

    private bool TryGetTarget(out AccountTreeNode target)
    {
      target = null;

      var row = treeAccounts.GetDataRecordByNode(_targetNode);
      if (row is GroupTreeNode node)
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
      var group = new GroupTreeNode();
      group.Name = "<New Group>";
      if (TryGetTarget(out AccountTreeNode parent))
      {
        parent.Add(group);
      }

      nodeBindingSource.Add(group);
    }

    private void btnNewAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      using (var dlg = new CreateAccountDialog())
      {
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          var node = dlg.CreateNode();
          if (TryGetTarget(out AccountTreeNode parent))
          {
            parent.Add(node);
          }
          nodeBindingSource.Add(node);
        }
      }
    }

    private void treeAccounts_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
    {
      _targetNode = e.Node;
    }

    private void treeAccounts_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
    {
      var data = treeAccounts.GetDataRecordByNode(e.Node);
      if (data is AccountTreeNode node)
      {
        switch (node)
        {
          case CheckingAccountNode checking:
            {
              e.NodeImageIndex = 4;
              break;
            }
          case CreditCardAccountNode creditCard:
            {
              e.NodeImageIndex = 2;
              break;
            }
          case ExpenseAccountNode expense:
            {
              e.NodeImageIndex = 5;
              break;
            }
          case GroupTreeNode group:
            {
              e.NodeImageIndex = e.Node.Expanded ? 1 : 0;
              break;
            }
          case LoanAccountNode loan:
            {
              e.NodeImageIndex = 6;
              break;
            }
          case PaycheckAccountNode paycheck:
            {
              e.NodeImageIndex = 7;
              break;
            }
          case SavingsAccountNode savings:
            {
              e.NodeImageIndex = 4;
              break;
            }
        }
      }
    }
  }
}
