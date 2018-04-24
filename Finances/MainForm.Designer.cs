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
      this.btnSave = new DevExpress.XtraBars.BarButtonItem();
      this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
      this.btnCloseCurrent = new DevExpress.XtraBars.BarButtonItem();
      this.btnNewGroup = new DevExpress.XtraBars.BarButtonItem();
      this.btnNewAccount = new DevExpress.XtraBars.BarButtonItem();
      this.btnRecurringTransactions = new DevExpress.XtraBars.BarButtonItem();
      this.btnNewTransaction = new DevExpress.XtraBars.BarButtonItem();
      this.btnDuplicateTransaction = new DevExpress.XtraBars.BarButtonItem();
      this.btnEditTransaction = new DevExpress.XtraBars.BarButtonItem();
      this.btnDeleteTransaction = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.pageAccounts = new DevExpress.XtraTab.XtraTabPage();
      this.treeAccounts = new DevExpress.XtraTreeList.TreeList();
      this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.colBalance = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.nodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
      this.btnSimulate = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.pageAccounts.SuspendLayout();
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
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNewAccount,
            this.btnNewGroup,
            this.btnRecurringTransactions,
            this.btnNewTransaction,
            this.btnSave,
            this.btnCloseCurrent,
            this.btnEditTransaction,
            this.btnDeleteTransaction,
            this.btnLoad,
            this.btnDuplicateTransaction,
            this.btnSimulate});
      this.barManager1.MaxItemId = 11;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLoad, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCloseCurrent, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNewGroup, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNewAccount, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRecurringTransactions, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewTransaction, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDuplicateTransaction),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditTransaction),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteTransaction),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSimulate, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DrawBorder = false;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // btnSave
      // 
      this.btnSave.Caption = "Save";
      this.btnSave.Id = 4;
      this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
      this.btnSave.Name = "btnSave";
      this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
      // 
      // btnLoad
      // 
      this.btnLoad.Caption = "Load";
      this.btnLoad.Id = 8;
      this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
      // 
      // btnCloseCurrent
      // 
      this.btnCloseCurrent.Caption = "Close";
      this.btnCloseCurrent.Id = 5;
      this.btnCloseCurrent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseCurrent.ImageOptions.Image")));
      this.btnCloseCurrent.Name = "btnCloseCurrent";
      this.btnCloseCurrent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCloseCurrent_ItemClick);
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
      // btnRecurringTransactions
      // 
      this.btnRecurringTransactions.Caption = "Recurring Transactions";
      this.btnRecurringTransactions.Id = 2;
      this.btnRecurringTransactions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRecurringTransactions.ImageOptions.Image")));
      this.btnRecurringTransactions.Name = "btnRecurringTransactions";
      this.btnRecurringTransactions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecurringTransactions_ItemClick);
      // 
      // btnNewTransaction
      // 
      this.btnNewTransaction.Caption = "New Transaction";
      this.btnNewTransaction.Id = 3;
      this.btnNewTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransaction.ImageOptions.Image")));
      this.btnNewTransaction.Name = "btnNewTransaction";
      this.btnNewTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewTransaction_ItemClick);
      // 
      // btnDuplicateTransaction
      // 
      this.btnDuplicateTransaction.Caption = "Duplicate Transaction";
      this.btnDuplicateTransaction.Id = 9;
      this.btnDuplicateTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuplicateTransaction.ImageOptions.Image")));
      this.btnDuplicateTransaction.Name = "btnDuplicateTransaction";
      this.btnDuplicateTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDuplicateTransaction_ItemClick);
      // 
      // btnEditTransaction
      // 
      this.btnEditTransaction.Caption = "Edit Transaction";
      this.btnEditTransaction.Id = 6;
      this.btnEditTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTransaction.ImageOptions.Image")));
      this.btnEditTransaction.Name = "btnEditTransaction";
      this.btnEditTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditTransaction_ItemClick);
      // 
      // btnDeleteTransaction
      // 
      this.btnDeleteTransaction.Caption = "Delete Transaction";
      this.btnDeleteTransaction.Id = 7;
      this.btnDeleteTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTransaction.ImageOptions.Image")));
      this.btnDeleteTransaction.Name = "btnDeleteTransaction";
      this.btnDeleteTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteTransaction_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(710, 31);
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
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 407);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(710, 31);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 407);
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.xtraTabControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 31);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(882, 143, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(710, 407);
      this.layoutControl1.TabIndex = 4;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // xtraTabControl1
      // 
      this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
      this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.pageAccounts;
      this.xtraTabControl1.Size = new System.Drawing.Size(686, 383);
      this.xtraTabControl1.TabIndex = 9;
      this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageAccounts});
      this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
      this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
      // 
      // pageAccounts
      // 
      this.pageAccounts.Controls.Add(this.treeAccounts);
      this.pageAccounts.Name = "pageAccounts";
      this.pageAccounts.Padding = new System.Windows.Forms.Padding(3);
      this.pageAccounts.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
      this.pageAccounts.Size = new System.Drawing.Size(680, 355);
      this.pageAccounts.Text = "Accounts";
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
      this.treeAccounts.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single;
      this.treeAccounts.OptionsMenu.EnableColumnMenu = false;
      this.treeAccounts.OptionsMenu.EnableFooterMenu = false;
      this.treeAccounts.OptionsSelection.SelectNodesOnRightClick = true;
      this.treeAccounts.OptionsView.ShowIndicator = false;
      this.treeAccounts.ParentFieldName = "ParentId";
      this.treeAccounts.Size = new System.Drawing.Size(674, 349);
      this.treeAccounts.StateImageList = this.imageCollection1;
      this.treeAccounts.TabIndex = 4;
      this.treeAccounts.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeAccounts_GetStateImage);
      this.treeAccounts.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeAccounts_FocusedNodeChanged);
      this.treeAccounts.BeforeDropNode += new DevExpress.XtraTreeList.BeforeDropNodeEventHandler(this.treeAccounts_BeforeDropNode);
      this.treeAccounts.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.treeAccounts_ShowingEditor);
      this.treeAccounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeAccounts_KeyDown);
      this.treeAccounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeAccounts_MouseDoubleClick);
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
      this.imageCollection1.Images.SetKeyName(7, "money-coin.png");
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(710, 407);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.xtraTabControl1;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(690, 387);
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
      // btnSimulate
      // 
      this.btnSimulate.Caption = "Simulate";
      this.btnSimulate.Id = 10;
      this.btnSimulate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSimulate.ImageOptions.Image")));
      this.btnSimulate.Name = "btnSimulate";
      this.btnSimulate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSimulate_ItemClick);
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
      this.pageAccounts.ResumeLayout(false);
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
    private DevExpress.XtraTab.XtraTabPage pageAccounts;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.Utils.ImageCollection imageCollection1;
    private DevExpress.XtraBars.BarButtonItem btnRecurringTransactions;
    private DevExpress.XtraBars.BarButtonItem btnNewTransaction;
    private DevExpress.XtraBars.BarButtonItem btnSave;
    private DevExpress.XtraBars.BarButtonItem btnCloseCurrent;
    private DevExpress.XtraBars.BarButtonItem btnEditTransaction;
    private DevExpress.XtraBars.BarButtonItem btnDeleteTransaction;
    private DevExpress.XtraBars.BarButtonItem btnLoad;
    private DevExpress.XtraBars.BarButtonItem btnDuplicateTransaction;
    private DevExpress.XtraBars.BarButtonItem btnSimulate;
  }
}

