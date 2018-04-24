namespace Finances
{
  partial class RecurringTransactionsControl
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
      this.recurringTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFrequency = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colNext = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFromAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colToAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.recurringTransactionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).BeginInit();
      this.SuspendLayout();
      // 
      // gridTransactions
      // 
      this.gridTransactions.DataSource = this.recurringTransactionBindingSource;
      this.gridTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridTransactions.Location = new System.Drawing.Point(3, 3);
      this.gridTransactions.MainView = this.gridViewTransactions;
      this.gridTransactions.Name = "gridTransactions";
      this.gridTransactions.Size = new System.Drawing.Size(623, 359);
      this.gridTransactions.TabIndex = 0;
      this.gridTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactions});
      this.gridTransactions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridTransactions_MouseDoubleClick);
      // 
      // recurringTransactionBindingSource
      // 
      this.recurringTransactionBindingSource.DataSource = typeof(Finances.RecurringTransaction);
      // 
      // gridViewTransactions
      // 
      this.gridViewTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colFrequency,
            this.colNext,
            this.colValue,
            this.colFromAccountId,
            this.colToAccountId});
      this.gridViewTransactions.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridViewTransactions.GridControl = this.gridTransactions;
      this.gridViewTransactions.Name = "gridViewTransactions";
      this.gridViewTransactions.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewTransactions.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewTransactions.OptionsBehavior.Editable = false;
      this.gridViewTransactions.OptionsBehavior.ReadOnly = true;
      this.gridViewTransactions.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewTransactions.OptionsSelection.MultiSelect = true;
      this.gridViewTransactions.OptionsSelection.UseIndicatorForSelection = false;
      this.gridViewTransactions.OptionsView.ShowGroupPanel = false;
      this.gridViewTransactions.OptionsView.ShowIndicator = false;
      this.gridViewTransactions.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewTransactions_CustomUnboundColumnData);
      this.gridViewTransactions.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewTransactions_CustomColumnDisplayText);
      this.gridViewTransactions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewTransactions_KeyDown);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colFrequency
      // 
      this.colFrequency.Caption = "Frequency";
      this.colFrequency.FieldName = "colFrequency";
      this.colFrequency.Name = "colFrequency";
      this.colFrequency.UnboundType = DevExpress.Data.UnboundColumnType.String;
      this.colFrequency.Visible = true;
      this.colFrequency.VisibleIndex = 1;
      // 
      // colNext
      // 
      this.colNext.Caption = "Next";
      this.colNext.FieldName = "colNext";
      this.colNext.Name = "colNext";
      this.colNext.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
      this.colNext.Visible = true;
      this.colNext.VisibleIndex = 2;
      // 
      // colValue
      // 
      this.colValue.Caption = "Value";
      this.colValue.FieldName = "colValue";
      this.colValue.Name = "colValue";
      this.colValue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
      this.colValue.Visible = true;
      this.colValue.VisibleIndex = 3;
      // 
      // colFromAccountId
      // 
      this.colFromAccountId.Caption = "From";
      this.colFromAccountId.FieldName = "FromAccountId";
      this.colFromAccountId.Name = "colFromAccountId";
      this.colFromAccountId.Visible = true;
      this.colFromAccountId.VisibleIndex = 4;
      // 
      // colToAccountId
      // 
      this.colToAccountId.Caption = "To";
      this.colToAccountId.FieldName = "ToAccountId";
      this.colToAccountId.Name = "colToAccountId";
      this.colToAccountId.Visible = true;
      this.colToAccountId.VisibleIndex = 5;
      // 
      // RecurringTransactionsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridTransactions);
      this.Name = "RecurringTransactionsControl";
      this.Padding = new System.Windows.Forms.Padding(3);
      this.Size = new System.Drawing.Size(629, 365);
      ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.recurringTransactionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridTransactions;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactions;
    private System.Windows.Forms.BindingSource recurringTransactionBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colFromAccountId;
    private DevExpress.XtraGrid.Columns.GridColumn colToAccountId;
    private DevExpress.XtraGrid.Columns.GridColumn colFrequency;
    private DevExpress.XtraGrid.Columns.GridColumn colNext;
    private DevExpress.XtraGrid.Columns.GridColumn colValue;
  }
}
