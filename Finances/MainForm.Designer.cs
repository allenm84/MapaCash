namespace Finances
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.btnNewGroup = new DevExpress.XtraBars.BarButtonItem();
      this.btnNewAccount = new DevExpress.XtraBars.BarButtonItem();
      this.bar2 = new DevExpress.XtraBars.Bar();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
      this.treeAccounts = new DevExpress.XtraTreeList.TreeList();
      this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.colBalance = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.nodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
      this.btnRecurringTransactions = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.xtraTabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.treeAccounts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nodeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
      this.SuspendLayout();
      // 
      // barManager1
      // 
      this.barManager1.AllowCustomization = false;
      this.barManager1.AllowMoveBarOnToolbar = false;
      this.barManager1.AllowQuickCustomization = false;
      this.barManager1.AllowShowToolbarsPopup = false;
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNewAccount,
            this.btnNewGroup,
            this.btnRecurringTransactions});
      this.barManager1.MainMenu = this.bar2;
      this.barManager1.MaxItemId = 3;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 1;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNewGroup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNewAccount, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRecurringTransactions)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DrawBorder = false;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // btnNewGroup
      // 
      this.btnNewGroup.Caption = "New Group";
      this.btnNewGroup.Id = 1;
      this.btnNewGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGroup.ImageOptions.Image")));
      this.btnNewGroup.Name = "btnNewGroup";
      this.btnNewGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewGroup_ItemClick);
      // 
      // btnNewAccount
      // 
      this.btnNewAccount.Caption = "New Account";
      this.btnNewAccount.Id = 0;
      this.btnNewAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAccount.ImageOptions.Image")));
      this.btnNewAccount.Name = "btnNewAccount";
      this.btnNewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewAccount_ItemClick);
      // 
      // bar2
      // 
      this.bar2.BarName = "Main menu";
      this.bar2.DockCol = 0;
      this.bar2.DockRow = 0;
      this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar2.OptionsBar.MultiLine = true;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Main menu";
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(710, 51);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new System.Drawing.Size(710, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 387);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(710, 51);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 387);
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.xtraTabControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 51);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(882, 143, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(710, 387);
      this.layoutControl1.TabIndex = 4;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // xtraTabControl1
      // 
      this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
      this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
      this.xtraTabControl1.Size = new System.Drawing.Size(686, 363);
      this.xtraTabControl1.TabIndex = 9;
      this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
      // 
      // xtraTabPage1
      // 
      this.xtraTabPage1.Controls.Add(this.treeAccounts);
      this.xtraTabPage1.Name = "xtraTabPage1";
      this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
      this.xtraTabPage1.Size = new System.Drawing.Size(680, 335);
      this.xtraTabPage1.Text = "Accounts";
      // 
      // treeAccounts
      // 
      this.treeAccounts.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colDescription,
            this.colBalance});
      this.treeAccounts.Cursor = System.Windows.Forms.Cursors.Default;
      this.treeAccounts.DataSource = this.nodeBindingSource;
      this.treeAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeAccounts.KeyFieldName = "Id";
      this.treeAccounts.Location = new System.Drawing.Point(3, 3);
      this.treeAccounts.Name = "treeAccounts";
      this.treeAccounts.OptionsMenu.EnableColumnMenu = false;
      this.treeAccounts.OptionsMenu.EnableFooterMenu = false;
      this.treeAccounts.OptionsSelection.SelectNodesOnRightClick = true;
      this.treeAccounts.OptionsView.ShowIndicator = false;
      this.treeAccounts.ParentFieldName = "ParentId";
      this.treeAccounts.Size = new System.Drawing.Size(674, 329);
      this.treeAccounts.StateImageList = this.imageCollection1;
      this.treeAccounts.TabIndex = 4;
      this.treeAccounts.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeAccounts_GetStateImage);
      this.treeAccounts.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeAccounts_FocusedNodeChanged);
      this.treeAccounts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeAccounts_MouseUp);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colDescription
      // 
      this.colDescription.FieldName = "Description";
      this.colDescription.Name = "colDescription";
      this.colDescription.Visible = true;
      this.colDescription.VisibleIndex = 1;
      // 
      // colBalance
      // 
      this.colBalance.FieldName = "Balance";
      this.colBalance.Format.FormatString = "c2";
      this.colBalance.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colBalance.Name = "colBalance";
      this.colBalance.OptionsColumn.AllowEdit = false;
      this.colBalance.OptionsColumn.ReadOnly = true;
      this.colBalance.Visible = true;
      this.colBalance.VisibleIndex = 2;
      // 
      // nodeBindingSource
      // 
      this.nodeBindingSource.DataSource = typeof(Finances.AccountNode);
      // 
      // imageCollection1
      // 
      this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
      this.imageCollection1.Images.SetKeyName(0, "folder-horizontal.png");
      this.imageCollection1.Images.SetKeyName(1, "folder-horizontal-open.png");
      this.imageCollection1.Images.SetKeyName(2, "credit-card.png");
      this.imageCollection1.Images.SetKeyName(3, "piggy-bank.png");
      this.imageCollection1.Images.SetKeyName(4, "bank.png");
      this.imageCollection1.Images.SetKeyName(5, "currency-dollar-usd.png");
      this.imageCollection1.Images.SetKeyName(6, "receipt-share.png");
      this.imageCollection1.Images.SetKeyName(7, "cheque-sign.png");
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(710, 387);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.xtraTabControl1;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(690, 367);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // popupMenu1
      // 
      this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewGroup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewAccount)});
      this.popupMenu1.Manager = this.barManager1;
      this.popupMenu1.Name = "popupMenu1";
      // 
      // btnRecurringTransactions
      // 
      this.btnRecurringTransactions.Caption = "Recurring Transactions";
      this.btnRecurringTransactions.Id = 2;
      this.btnRecurringTransactions.Name = "btnRecurringTransactions";
      this.btnRecurringTransactions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecurringTransactions_ItemClick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(710, 438);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Finances";
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      this.xtraTabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.treeAccounts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nodeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.Bar bar2;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraTreeList.TreeList treeAccounts;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colBalance;
    private System.Windows.Forms.BindingSource nodeBindingSource;
    private DevExpress.XtraBars.BarButtonItem btnNewGroup;
    private DevExpress.XtraBars.BarButtonItem btnNewAccount;
    private DevExpress.XtraBars.PopupMenu popupMenu1;
    private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.Utils.ImageCollection imageCollection1;
    private DevExpress.XtraBars.BarButtonItem btnRecurringTransactions;
  }
}

