namespace Finances
{
  partial class SimulationAccountTransactionsControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.gridTransactions = new DevExpress.XtraGrid.GridControl();
      this.simulationAccountTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSourceId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIncrease = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDecrease = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.simulationAccountTransactionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).BeginInit();
      this.SuspendLayout();
      // 
      // gridTransactions
      // 
      this.gridTransactions.DataSource = this.simulationAccountTransactionBindingSource;
      this.gridTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridTransactions.Location = new System.Drawing.Point(0, 0);
      this.gridTransactions.MainView = this.gridViewTransactions;
      this.gridTransactions.Name = "gridTransactions";
      this.gridTransactions.Size = new System.Drawing.Size(510, 268);
      this.gridTransactions.TabIndex = 0;
      this.gridTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactions});
      // 
      // simulationAccountTransactionBindingSource
      // 
      this.simulationAccountTransactionBindingSource.DataSource = typeof(Finances.SimulationAccountTransaction);
      // 
      // gridViewTransactions
      // 
      this.gridViewTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colDescription,
            this.colSourceId,
            this.colIncrease,
            this.colDecrease,
            this.colBalance});
      this.gridViewTransactions.GridControl = this.gridTransactions;
      this.gridViewTransactions.Name = "gridViewTransactions";
      this.gridViewTransactions.OptionsBehavior.Editable = false;
      this.gridViewTransactions.OptionsBehavior.ReadOnly = true;
      this.gridViewTransactions.OptionsView.ShowGroupPanel = false;
      this.gridViewTransactions.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewTransactions_CustomColumnDisplayText);
      // 
      // colDate
      // 
      this.colDate.FieldName = "Date";
      this.colDate.Name = "colDate";
      this.colDate.OptionsColumn.ReadOnly = true;
      this.colDate.Visible = true;
      this.colDate.VisibleIndex = 0;
      // 
      // colDescription
      // 
      this.colDescription.FieldName = "Description";
      this.colDescription.Name = "colDescription";
      this.colDescription.OptionsColumn.ReadOnly = true;
      this.colDescription.Visible = true;
      this.colDescription.VisibleIndex = 1;
      // 
      // colSourceId
      // 
      this.colSourceId.Caption = "Account";
      this.colSourceId.FieldName = "SourceId";
      this.colSourceId.Name = "colSourceId";
      this.colSourceId.OptionsColumn.ReadOnly = true;
      this.colSourceId.Visible = true;
      this.colSourceId.VisibleIndex = 2;
      // 
      // colIncrease
      // 
      this.colIncrease.DisplayFormat.FormatString = "c2";
      this.colIncrease.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colIncrease.FieldName = "Increase";
      this.colIncrease.Name = "colIncrease";
      this.colIncrease.OptionsColumn.ReadOnly = true;
      this.colIncrease.Visible = true;
      this.colIncrease.VisibleIndex = 3;
      // 
      // colDecrease
      // 
      this.colDecrease.DisplayFormat.FormatString = "c2";
      this.colDecrease.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colDecrease.FieldName = "Decrease";
      this.colDecrease.Name = "colDecrease";
      this.colDecrease.OptionsColumn.ReadOnly = true;
      this.colDecrease.Visible = true;
      this.colDecrease.VisibleIndex = 4;
      // 
      // colBalance
      // 
      this.colBalance.DisplayFormat.FormatString = "c2";
      this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colBalance.FieldName = "Balance";
      this.colBalance.Name = "colBalance";
      this.colBalance.Visible = true;
      this.colBalance.VisibleIndex = 5;
      // 
      // SimulationAccountTransactionsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridTransactions);
      this.Name = "SimulationAccountTransactionsControl";
      this.Size = new System.Drawing.Size(510, 268);
      ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.simulationAccountTransactionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridTransactions;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactions;
    private System.Windows.Forms.BindingSource simulationAccountTransactionBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colDate;
    private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    private DevExpress.XtraGrid.Columns.GridColumn colSourceId;
    private DevExpress.XtraGrid.Columns.GridColumn colIncrease;
    private DevExpress.XtraGrid.Columns.GridColumn colDecrease;
    private DevExpress.XtraGrid.Columns.GridColumn colBalance;
  }
}
