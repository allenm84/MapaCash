using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTreeList.Nodes;
using Newtonsoft.Json;

namespace Finances
{
  public partial class MainForm : BaseForm, IAccountProvider
  {
    const string RecurringTransactionsId = "RecurringTransactionsId";

    private Dictionary<AccountType, int> _accountImageIndex = new Dictionary<AccountType, int>
    {
      { AccountType.Checking, 4 },
      { AccountType.CreditCard, 2 },
      { AccountType.Expense, 5 },
      { AccountType.Liability, 6 },
      { AccountType.Income, 7 },
      { AccountType.Savings, 3 },
    };
    
    private readonly Dictionary<string, XtraTabPage> _pages = new Dictionary<string, XtraTabPage>();
    private readonly RecurringTransactionsControl _currentTransactionsControl;

    private readonly BindingList<AccountNode> _accounts = new BindingList<AccountNode>();
    private readonly BindingList<RecurringTransaction> _transactions = new BindingList<RecurringTransaction>();

    private TreeListNode _targetNode;
    private string _currentData;
    private string _currentFilepath;
    private bool _potentiallyChanged = false;

    public MainForm()
    {
      InitializeComponent();

      nodeBindingSource.DataSource = _accounts;
      _currentTransactionsControl = new RecurringTransactionsControl
      {
        AccountProvider = this,
        Transactions = _transactions,
        Dock = DockStyle.Fill
      };

      _accounts.ListChanged += list_DataChanged;
      _transactions.ListChanged += list_DataChanged;

      UpdateToolBarButtons();
    }

    IList<AccountNode> IAccountProvider.Accounts => _accounts;
    AccountNode IAccountProvider.AddNewAccount() => AddAccount();

    private string DataAsJson()
    {
      // make sure the tree structure is up to date
      var accounts = new List<AccountNode>();
      UpdateParent(treeAccounts.Nodes, null, accounts);

      // write the data to json
      var data = new SaveData();
      data.Accounts = accounts.ToArray();
      data.Transactions = _transactions.ToArray();
      return JsonConvert.SerializeObject(data);
    }

    private void UpdateParent(TreeListNodes nodes, string parentId, List<AccountNode> accounts)
    {
      foreach (TreeListNode viewNode in nodes)
      {
        if (treeAccounts.GetDataRecordByNode(viewNode) is AccountNode node)
        {
          accounts.Add(node);
          node.ParentId = parentId;
          UpdateParent(viewNode.Nodes, node.Id, accounts);
        }
      }
    }

    private bool TryGetFilepath()
    {
      var succeeded = false;
      if (string.IsNullOrWhiteSpace(_currentFilepath) || !File.Exists(_currentFilepath))
      {
        using (var dlg = new XtraSaveFileDialog())
        {
          dlg.Filter = "Finance File (*.fjson)|*.fjson";
          dlg.RestoreDirectory = true;

          if (dlg.ShowDialog(this) == DialogResult.OK)
          {
            _currentFilepath = dlg.FileName;
            succeeded = true;
          }
        }
      }
      else
      {
        succeeded = true;
      }
      return succeeded;
    }

    private void UpdateTitle()
    {
      Text = $"Finances - {Path.GetFileName(_currentFilepath)}";
    }

    private bool DoSave()
    {
      if (TryGetFilepath())
      {
        UpdateTitle();
        _currentData = DataAsJson();
        File.WriteAllText(_currentFilepath, _currentData);
        return true;
      }

      return false;
    }

    private void DoLoad()
    {
      if (_potentiallyChanged && !string.Equals(DataAsJson(), _currentData))
      {
        if (this.Confirm("Do you want to save your changes?") && !DoSave())
        {
          // user chose to save their changes, but the
          // changes were not saved (load is cancelled)
          return;
        }
      }

      using (var dlg = new XtraOpenFileDialog())
      {
        dlg.CheckFileExists = true;
        dlg.CheckPathExists = true;
        dlg.Multiselect = false;
        dlg.Filter = "Finance File (*.fjson)|*.fjson";
        dlg.RestoreDirectory = true;

        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          _currentFilepath = dlg.FileName;
          UpdateTitle();

          _currentData = File.ReadAllText(_currentFilepath);
          var data = JsonConvert.DeserializeObject<SaveData>(_currentData);

          _currentTransactionsControl.BeginUpdate();
          _transactions.Clear();
          _transactions.AddRange(data.Transactions);
          _currentTransactionsControl.EndUpdate();

          treeAccounts.BeginUpdate();
          _accounts.Clear();
          _accounts.AddRange(data.Accounts);
          treeAccounts.EndUpdate();
        }
      }
    }

    private bool TryGetTarget(out AccountNode target)
    {
      target = null;

      var row = treeAccounts.GetDataRecordByNode(_targetNode);
      if (row is AccountNode node && node.Type == AccountType.Group)
      {
        target = node;
      }

      return (target != null);
    }

    private void ClosePage(XtraTabPage page)
    {
      if (page.Tag is string id && _pages.Remove(id))
      {
        xtraTabControl1.TabPages.Remove(page);
      }
    }

    private void SetBarItemVisibility(BarItem item, bool visible)
    {
      item.Visibility = visible 
        ? BarItemVisibility.Always
        : BarItemVisibility.Never;
    }

    private void UpdateToolBarButtons()
    {
      var page = xtraTabControl1.SelectedTabPage;

      SetBarItemVisibility(btnNewAccount, (page == pageAccounts));
      SetBarItemVisibility(btnNewGroup, (page == pageAccounts));

      var id = page.Tag as string;
      SetBarItemVisibility(btnNewTransaction, string.Equals(id, RecurringTransactionsId));
      SetBarItemVisibility(btnDuplicateTransaction, string.Equals(id, RecurringTransactionsId));
      SetBarItemVisibility(btnEditTransaction, string.Equals(id, RecurringTransactionsId));
      SetBarItemVisibility(btnDeleteTransaction, string.Equals(id, RecurringTransactionsId));
    }

    private AccountNode AddAccount()
    {
      using (var dlg = new EditAccountDialog(this))
      {
        if (TryGetTarget(out AccountNode parent))
        {
          dlg.ParentId = parent.Id;
        }

        dlg.Text = "Add Account";
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          var node = new AccountNode
          {
            Balance = dlg.Balance,
            Description = dlg.Description,
            Name = dlg.AccountName,
            Type = dlg.Type,
            ParentId = dlg.ParentId,
          };

          nodeBindingSource.Add(node);
          return node;
        }
      }

      return null;
    }

    private void EditAccount(AccountNode node)
    {
      using (var dlg = new EditAccountDialog(this))
      {
        dlg.Balance = node.Balance;
        dlg.Description = node.Description;
        dlg.AccountName = node.Name;
        dlg.Type = node.Type;
        dlg.ParentId = node.ParentId;
        dlg.Text = "Edit Account";

        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          treeAccounts.BeginUpdate();
          node.Balance = dlg.Balance;
          node.Description = dlg.Description;
          node.Name = dlg.AccountName;
          node.Type = dlg.Type;
          node.ParentId = dlg.ParentId;
          treeAccounts.EndUpdate();

          var index = nodeBindingSource.IndexOf(node);
          nodeBindingSource.ResetItem(index);
        }
      }
    }

    private void DeleteSelectedAccounts()
    {
      var selection = treeAccounts.Selection;
      if (selection.Count > 0 && this.Confirm("Are you sure you want to delete the selected accounts?"))
      {
        treeAccounts.DeleteSelectedNodes();
      }
    }

    private void list_DataChanged(object sender, ListChangedEventArgs e)
    {
      _potentiallyChanged = true;
    }

    private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      DoSave();
    }

    private void btnLoad_ItemClick(object sender, ItemClickEventArgs e)
    {
      DoLoad();
    }

    private void btnCloseCurrent_ItemClick(object sender, ItemClickEventArgs e)
    {
      ClosePage(xtraTabControl1.SelectedTabPage);
    }

    private void btnNewGroup_ItemClick(object sender, ItemClickEventArgs e)
    {
      var group = new AccountNode
      {
        Type = AccountType.Group,
        Name = "<New Group>"
      };

      if (TryGetTarget(out AccountNode parent))
      {
        parent.Add(group);
      }

      nodeBindingSource.Add(group);
    }

    private void btnNewAccount_ItemClick(object sender, ItemClickEventArgs e)
    {
      AddAccount();
    }

    private void btnRecurringTransactions_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (!_pages.TryGetValue(RecurringTransactionsId, out XtraTabPage page))
      {
        page = xtraTabControl1.TabPages.Add("Recurring Transactions");
        page.SuspendLayout();
        page.Controls.Add(_currentTransactionsControl);
        page.ResumeLayout();
        page.Tag = RecurringTransactionsId;
        _pages[RecurringTransactionsId] = page;
      }

      xtraTabControl1.SelectedTabPage = page;
    }

    private void btnNewTransaction_ItemClick(object sender, ItemClickEventArgs e)
    {
      _currentTransactionsControl.AddTransaction();
    }

    private void btnDuplicateTransaction_ItemClick(object sender, ItemClickEventArgs e)
    {
      _currentTransactionsControl.DuplicateTransaction();
    }

    private void btnEditTransaction_ItemClick(object sender, ItemClickEventArgs e)
    {
      _currentTransactionsControl.EditTransaction();
    }

    private void btnDeleteTransaction_ItemClick(object sender, ItemClickEventArgs e)
    {
      _currentTransactionsControl.RemoveTransaction();
    }

    private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
    {
      if (e is ClosePageButtonEventArgs args && args.Page is XtraTabPage page)
      {
        ClosePage(page);
      }
    }

    private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
    {
      UpdateToolBarButtons();
    }

    private void treeAccounts_MouseUp(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Right) != 0)
      {
        _targetNode = treeAccounts.GetNodeAt(e.Location);
        popupMenu1.ShowPopup(Cursor.Position);
      }
    }

    private void treeAccounts_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != 0)
      {
        var info = treeAccounts.CalcHitInfo(e.Location);
        if (info.Node != null && treeAccounts.GetDataRecordByNode(info.Node) is AccountNode node)
        {
          EditAccount(node);
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
      if (data is AccountNode node)
      {
        if (node.Type == AccountType.Group)
        {
          e.NodeImageIndex = e.Node.Expanded ? 1 : 0;
        }
        else
        {
          e.NodeImageIndex = _accountImageIndex[node.Type];
        }
      }
    }

    private void treeAccounts_BeforeDropNode(object sender, DevExpress.XtraTreeList.BeforeDropNodeEventArgs e)
    {
      var dest = treeAccounts.GetDataRecordByNode(e.DestinationNode);
      if (dest is AccountNode node && node.Type != AccountType.Group)
      {
        e.Cancel = true;
      }
    }

    private void treeAccounts_ShowingEditor(object sender, CancelEventArgs e)
    {
      if (treeAccounts.FocusedColumn == colBalance &&
        treeAccounts.GetDataRecordByNode(treeAccounts.FocusedNode) is AccountNode node &&
        node.Type == AccountType.Group)
      {
        e.Cancel = true;
      }
    }

    private void treeAccounts_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        DeleteSelectedAccounts();
      }
    }

    private void btnSimulate_ItemClick(object sender, ItemClickEventArgs e)
    {
      using (var dlg = new SetupSimulationDialog())
      {
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          SimEngine.Run(this, dlg.Start, dlg.Years, DataAsJson());
        }
      }
    }
  }
}
