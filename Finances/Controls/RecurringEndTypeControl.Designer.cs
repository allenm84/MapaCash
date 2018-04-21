namespace Finances
{
  partial class RecurringEndTypeControl
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
      DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.numFor = new DevExpress.XtraEditors.SpinEdit();
      this.optFor = new DevExpress.XtraEditors.CheckEdit();
      this.dtUntil = new DevExpress.XtraEditors.DateEdit();
      this.optUntil = new DevExpress.XtraEditors.CheckEdit();
      this.optForever = new DevExpress.XtraEditors.CheckEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numFor.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.optFor.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtUntil.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtUntil.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.optUntil.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.optForever.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.numFor);
      this.layoutControl1.Controls.Add(this.optFor);
      this.layoutControl1.Controls.Add(this.dtUntil);
      this.layoutControl1.Controls.Add(this.optUntil);
      this.layoutControl1.Controls.Add(this.optForever);
      this.layoutControl1.Controls.Add(this.labelControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(711, 141, 650, 409);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(150, 150);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // numFor
      // 
      this.numFor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numFor.Location = new System.Drawing.Point(57, 66);
      this.numFor.Name = "numFor";
      this.numFor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numFor.Properties.IsFloatValue = false;
      this.numFor.Properties.Mask.EditMask = "N00";
      this.numFor.Size = new System.Drawing.Size(91, 20);
      this.numFor.StyleController = this.layoutControl1;
      this.numFor.TabIndex = 9;
      // 
      // optFor
      // 
      this.optFor.Location = new System.Drawing.Point(6, 66);
      this.optFor.Name = "optFor";
      this.optFor.Properties.Caption = "For:";
      this.optFor.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
      this.optFor.Properties.RadioGroupIndex = 1;
      this.optFor.Size = new System.Drawing.Size(47, 19);
      this.optFor.StyleController = this.layoutControl1;
      this.optFor.TabIndex = 8;
      this.optFor.TabStop = false;
      // 
      // dtUntil
      // 
      this.dtUntil.EditValue = null;
      this.dtUntil.Location = new System.Drawing.Point(57, 42);
      this.dtUntil.Name = "dtUntil";
      this.dtUntil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtUntil.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtUntil.Size = new System.Drawing.Size(91, 20);
      this.dtUntil.StyleController = this.layoutControl1;
      this.dtUntil.TabIndex = 7;
      // 
      // optUntil
      // 
      this.optUntil.Location = new System.Drawing.Point(6, 42);
      this.optUntil.Name = "optUntil";
      this.optUntil.Properties.Caption = "Until:";
      this.optUntil.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
      this.optUntil.Properties.RadioGroupIndex = 1;
      this.optUntil.Size = new System.Drawing.Size(47, 19);
      this.optUntil.StyleController = this.layoutControl1;
      this.optUntil.TabIndex = 6;
      this.optUntil.TabStop = false;
      // 
      // optForever
      // 
      this.optForever.Location = new System.Drawing.Point(6, 19);
      this.optForever.Name = "optForever";
      this.optForever.Properties.Caption = "Forever";
      this.optForever.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
      this.optForever.Properties.RadioGroupIndex = 1;
      this.optForever.Size = new System.Drawing.Size(142, 19);
      this.optForever.StyleController = this.layoutControl1;
      this.optForever.TabIndex = 5;
      this.optForever.TabStop = false;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(2, 2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(44, 13);
      this.labelControl1.StyleController = this.layoutControl1;
      this.labelControl1.TabIndex = 4;
      this.labelControl1.Text = "Repeats:";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
      this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
      this.layoutControlGroup1.Name = "Root";
      columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition1.Width = 55D;
      columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
      columnDefinition2.Width = 100D;
      this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
      rowDefinition1.Height = 17D;
      rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition2.Height = 23D;
      rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition3.Height = 24D;
      rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition4.Height = 86D;
      rowDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize;
      this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
      this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup1.Size = new System.Drawing.Size(150, 150);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.labelControl1;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
      this.layoutControlItem1.Size = new System.Drawing.Size(150, 17);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.optForever;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 17);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 2;
      this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
      this.layoutControlItem2.Size = new System.Drawing.Size(150, 23);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.optUntil;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
      this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
      this.layoutControlItem3.Size = new System.Drawing.Size(55, 24);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.dtUntil;
      this.layoutControlItem4.Location = new System.Drawing.Point(55, 40);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
      this.layoutControlItem4.Size = new System.Drawing.Size(95, 24);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.optFor;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 64);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
      this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
      this.layoutControlItem5.Size = new System.Drawing.Size(55, 86);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.numFor;
      this.layoutControlItem6.Location = new System.Drawing.Point(55, 64);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
      this.layoutControlItem6.Size = new System.Drawing.Size(95, 86);
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      // 
      // RecurringEndTypeControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "RecurringEndTypeControl";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numFor.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.optFor.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtUntil.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtUntil.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.optUntil.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.optForever.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.CheckEdit optForever;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SpinEdit numFor;
    private DevExpress.XtraEditors.CheckEdit optFor;
    private DevExpress.XtraEditors.DateEdit dtUntil;
    private DevExpress.XtraEditors.CheckEdit optUntil;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
  }
}
