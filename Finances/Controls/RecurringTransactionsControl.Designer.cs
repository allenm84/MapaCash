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
      this.gridViewTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.recurringTransactionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFrequency = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colNext = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.recurringTransactionViewBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridTransactions
      // 
      this.gridTransactions.DataSource = this.recurringTransactionViewBindingSource;
      this.gridTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridTransactions.Location = new System.Drawing.Point(0, 0);
      this.gridTransactions.MainView = this.gridViewTransactions;
      this.gridTransactions.Name = "gridTransactions";
      this.gridTransactions.Size = new System.Drawing.Size(629, 365);
      this.gridTransactions.TabIndex = 0;
      this.gridTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactions});
      // 
      // gridViewTransactions
      // 
      this.gridViewTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colFrequency,
            this.colNext});
      this.gridViewTransactions.GridControl = this.gridTransactions;
      this.gridViewTransactions.Name = "gridViewTransactions";
      this.gridViewTransactions.OptionsView.ShowGroupPanel = false;
      // 
      // recurringTransactionViewBindingSource
      // 
      this.recurringTransactionViewBindingSource.DataSource = typeof(Finances.RecurringTransactionView);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.OptionsColumn.ReadOnly = true;
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colFrequency
      // 
      this.colFrequency.FieldName = "Frequency";
      this.colFrequency.Name = "colFrequency";
      this.colFrequency.OptionsColumn.ReadOnly = true;
      this.colFrequency.Visible = true;
      this.colFrequency.VisibleIndex = 1;
      // 
      // colNext
      // 
      this.colNext.FieldName = "Next";
      this.colNext.Name = "colNext";
      this.colNext.OptionsColumn.ReadOnly = true;
      this.colNext.Visible = true;
      this.colNext.VisibleIndex = 2;
      // 
      // RecurringTransactionsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridTransactions);
      this.Name = "RecurringTransactionsControl";
      this.Size = new System.Drawing.Size(629, 365);
      ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.recurringTransactionViewBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridTransactions;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactions;
    private System.Windows.Forms.BindingSource recurringTransactionViewBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colFrequency;
    private DevExpress.XtraGrid.Columns.GridColumn colNext;
  }
}
