using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace Finances
{
  public partial class SimulationResultsDialog : BaseForm
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

    private readonly Dictionary<string, XtraTabPage> _openAccounts;
    private readonly Dictionary<string, SimulationAccount> _accounts;

    public SimulationResultsDialog(SimulationAccount[] accounts)
    {
      _openAccounts = new Dictionary<string, XtraTabPage>();
      _accounts = accounts.ToDictionary(a => a.Id);

      InitializeComponent();
      simulationAccountBindingSource.DataSource = accounts;
    }

    private void ShowAccount(SimulationAccount account)
    {
      if (account.Type == AccountType.Group)
        return;

      if (!_openAccounts.TryGetValue(account.Id, out XtraTabPage page))
      {
        page = xtraTabControl1.TabPages.Add(account.Name);
        page.SuspendLayout();
        page.Padding = new Padding(3);
        page.Controls.Add(new SimulationAccountTransactionsControl
        {
           Dock = DockStyle.Fill,
           Transactions = account.Transactions,
           Accounts = _accounts,
        });
        page.ResumeLayout();
        _openAccounts[account.Id] = page;
        page.Tag = account.Id;
      }

      xtraTabControl1.SelectedTabPage = page;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      treeAccounts.ExpandAll();
    }

    private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
    {
      if (e is ClosePageButtonEventArgs args && args.Page is XtraTabPage page && page.Tag is string id)
      {
        _openAccounts.Remove(id);
        xtraTabControl1.TabPages.Remove(page, true);
      }
    }

    private void treeAccounts_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
    {
      var data = treeAccounts.GetDataRecordByNode(e.Node);
      if (data is SimulationAccount node)
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

    private void treeAccounts_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != 0)
      {
        var info = treeAccounts.CalcHitInfo(e.Location);
        if (info.Node != null && treeAccounts.GetDataRecordByNode(info.Node) is SimulationAccount account)
        {
          ShowAccount(account);
        }
      }
    }
  }
}
