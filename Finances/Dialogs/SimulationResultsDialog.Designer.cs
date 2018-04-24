namespace Finances
{
  partial class SimulationResultsDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationResultsDialog));
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.tabPageAccounts = new DevExpress.XtraTab.XtraTabPage();
      this.treeAccounts = new DevExpress.XtraTreeList.TreeList();
      this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.colBalance = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.simulationAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.tabPageAccounts.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.treeAccounts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.simulationAccountBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.xtraTabControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(800, 450);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // xtraTabControl1
      // 
      this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
      this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.tabPageAccounts;
      this.xtraTabControl1.Size = new System.Drawing.Size(776, 426);
      this.xtraTabControl1.TabIndex = 4;
      this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageAccounts});
      this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
      // 
      // tabPageAccounts
      // 
      this.tabPageAccounts.Controls.Add(this.treeAccounts);
      this.tabPageAccounts.Name = "tabPageAccounts";
      this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageAccounts.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
      this.tabPageAccounts.Size = new System.Drawing.Size(770, 398);
      this.tabPageAccounts.Text = "Accounts";
      // 
      // treeAccounts
      // 
      this.treeAccounts.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colDescription,
            this.colBalance});
      this.treeAccounts.DataSource = this.simulationAccountBindingSource;
      this.treeAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeAccounts.KeyFieldName = "Id";
      this.treeAccounts.Location = new System.Drawing.Point(3, 3);
      this.treeAccounts.Name = "treeAccounts";
      this.treeAccounts.OptionsBehavior.Editable = false;
      this.treeAccounts.OptionsBehavior.ReadOnly = true;
      this.treeAccounts.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.treeAccounts.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
      this.treeAccounts.OptionsView.ShowIndicator = false;
      this.treeAccounts.ParentFieldName = "ParentId";
      this.treeAccounts.Size = new System.Drawing.Size(764, 392);
      this.treeAccounts.TabIndex = 0;
      this.treeAccounts.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeAccounts_GetStateImage);
      this.treeAccounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeAccounts_MouseDoubleClick);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.OptionsColumn.ReadOnly = true;
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colDescription
      // 
      this.colDescription.FieldName = "Description";
      this.colDescription.Name = "colDescription";
      this.colDescription.OptionsColumn.ReadOnly = true;
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
      // simulationAccountBindingSource
      // 
      this.simulationAccountBindingSource.DataSource = typeof(Finances.SimulationAccount);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.xtraTabControl1;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(780, 430);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
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
      // SimulationResultsDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.layoutControl1);
      this.Name = "SimulationResultsDialog";
      this.Text = "Results";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      this.tabPageAccounts.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.treeAccounts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.simulationAccountBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    private DevExpress.XtraTab.XtraTabPage tabPageAccounts;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraTreeList.TreeList treeAccounts;
    private DevExpress.Utils.ImageCollection imageCollection1;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colBalance;
    private System.Windows.Forms.BindingSource simulationAccountBindingSource;
  }
}