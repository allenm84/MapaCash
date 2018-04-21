namespace Finances
{
  partial class RecurringFrequencyControl
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
      DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.dtStart = new DevExpress.XtraEditors.DateEdit();
      this.cboFrequency = new DevExpress.XtraEditors.ComboBoxEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboFrequency.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.labelControl2);
      this.layoutControl1.Controls.Add(this.labelControl1);
      this.layoutControl1.Controls.Add(this.dtStart);
      this.layoutControl1.Controls.Add(this.cboFrequency);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(666, 203, 532, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(301, 29);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // dtStart
      // 
      this.dtStart.EditValue = null;
      this.dtStart.Location = new System.Drawing.Point(203, 4);
      this.dtStart.Name = "dtStart";
      this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtStart.Size = new System.Drawing.Size(91, 20);
      this.dtStart.StyleController = this.layoutControl1;
      this.dtStart.TabIndex = 5;
      // 
      // cboFrequency
      // 
      this.cboFrequency.Location = new System.Drawing.Point(61, 4);
      this.cboFrequency.Name = "cboFrequency";
      this.cboFrequency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboFrequency.Size = new System.Drawing.Size(106, 20);
      this.cboFrequency.StyleController = this.layoutControl1;
      this.cboFrequency.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
      this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
      this.layoutControlGroup1.Name = "Root";
      columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition1.Width = 59D;
      columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition2.Width = 110D;
      columnDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition3.Width = 32D;
      columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition4.Width = 95D;
      columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
      columnDefinition5.Width = 100D;
      this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5});
      rowDefinition1.Height = 50D;
      rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
      rowDefinition2.Height = 24D;
      rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition3.Height = 50D;
      rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
      this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
      this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup1.Size = new System.Drawing.Size(301, 29);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboFrequency;
      this.layoutControlItem1.Location = new System.Drawing.Point(59, 2);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem1.Size = new System.Drawing.Size(110, 24);
      this.layoutControlItem1.Text = "Frequency:";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.dtStart;
      this.layoutControlItem2.Location = new System.Drawing.Point(201, 2);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 3;
      this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem2.Size = new System.Drawing.Size(95, 24);
      this.layoutControlItem2.Text = "Start:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(2, 7);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(55, 13);
      this.labelControl1.StyleController = this.layoutControl1;
      this.labelControl1.TabIndex = 6;
      this.labelControl1.Text = "Frequency:";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.labelControl1;
      this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 2);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem3.Size = new System.Drawing.Size(59, 24);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem3.TrimClientAreaToControl = false;
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(171, 7);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(28, 13);
      this.labelControl2.StyleController = this.layoutControl1;
      this.labelControl2.TabIndex = 7;
      this.labelControl2.Text = "Start:";
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.labelControl2;
      this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
      this.layoutControlItem4.Location = new System.Drawing.Point(169, 2);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2;
      this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem4.Size = new System.Drawing.Size(32, 24);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      this.layoutControlItem4.TrimClientAreaToControl = false;
      // 
      // RecurringFrequencyControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "RecurringFrequencyControl";
      this.Size = new System.Drawing.Size(301, 29);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboFrequency.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.ComboBoxEdit cboFrequency;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.DateEdit dtStart;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
  }
}
