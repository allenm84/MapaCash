namespace Finances
{
  partial class RecurringDayOfMonthControl
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
      this.cboDayOfMonth2 = new DevExpress.XtraEditors.ComboBoxEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.cboDayOfMonth1 = new DevExpress.XtraEditors.ComboBoxEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboDayOfMonth2.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboDayOfMonth1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.cboDayOfMonth2);
      this.layoutControl1.Controls.Add(this.labelControl2);
      this.layoutControl1.Controls.Add(this.cboDayOfMonth1);
      this.layoutControl1.Controls.Add(this.labelControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(316, 31);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // cboDayOfMonth2
      // 
      this.cboDayOfMonth2.Location = new System.Drawing.Point(221, 5);
      this.cboDayOfMonth2.Name = "cboDayOfMonth2";
      this.cboDayOfMonth2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboDayOfMonth2.Size = new System.Drawing.Size(86, 20);
      this.cboDayOfMonth2.StyleController = this.layoutControl1;
      this.cboDayOfMonth2.TabIndex = 7;
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(155, 8);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(62, 13);
      this.labelControl2.StyleController = this.layoutControl1;
      this.labelControl2.TabIndex = 6;
      this.labelControl2.Text = "Then on the:";
      // 
      // cboDayOfMonth1
      // 
      this.cboDayOfMonth1.Location = new System.Drawing.Point(65, 5);
      this.cboDayOfMonth1.Name = "cboDayOfMonth1";
      this.cboDayOfMonth1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboDayOfMonth1.Size = new System.Drawing.Size(86, 20);
      this.cboDayOfMonth1.StyleController = this.layoutControl1;
      this.cboDayOfMonth1.TabIndex = 5;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(2, 8);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(59, 13);
      this.labelControl1.StyleController = this.layoutControl1;
      this.labelControl1.TabIndex = 4;
      this.labelControl1.Text = "First on the:";
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
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition1.Width = 63D;
      columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition2.Width = 90D;
      columnDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition3.Width = 66D;
      columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition4.Width = 90D;
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
      this.layoutControlGroup1.Size = new System.Drawing.Size(316, 31);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.labelControl1;
      this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 3);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem1.Size = new System.Drawing.Size(63, 24);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem1.TrimClientAreaToControl = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.cboDayOfMonth1;
      this.layoutControlItem2.Location = new System.Drawing.Point(63, 3);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem2.Size = new System.Drawing.Size(90, 24);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.labelControl2;
      this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
      this.layoutControlItem3.Location = new System.Drawing.Point(153, 3);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 2;
      this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem3.Size = new System.Drawing.Size(66, 24);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem3.TrimClientAreaToControl = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.cboDayOfMonth2;
      this.layoutControlItem4.Location = new System.Drawing.Point(219, 3);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 3;
      this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem4.Size = new System.Drawing.Size(90, 24);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // RecurringDayOfMonthControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "RecurringDayOfMonthControl";
      this.Size = new System.Drawing.Size(316, 31);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboDayOfMonth2.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboDayOfMonth1.Properties)).EndInit();
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
    private DevExpress.XtraEditors.ComboBoxEdit cboDayOfMonth2;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.ComboBoxEdit cboDayOfMonth1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
  }
}
