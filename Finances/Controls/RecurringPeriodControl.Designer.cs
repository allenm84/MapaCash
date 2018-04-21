﻿namespace Finances
{
  partial class RecurringPeriodControl
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
      DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.lblUnits = new DevExpress.XtraEditors.LabelControl();
      this.numAmount = new DevExpress.XtraEditors.SpinEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numAmount.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.lblUnits);
      this.layoutControl1.Controls.Add(this.numAmount);
      this.layoutControl1.Controls.Add(this.labelControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(535, 172, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(211, 29);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // lblUnits
      // 
      this.lblUnits.Location = new System.Drawing.Point(186, 7);
      this.lblUnits.Name = "lblUnits";
      this.lblUnits.Size = new System.Drawing.Size(23, 13);
      this.lblUnits.StyleController = this.layoutControl1;
      this.lblUnits.TabIndex = 6;
      this.lblUnits.Text = "units";
      // 
      // numAmount
      // 
      this.numAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numAmount.Location = new System.Drawing.Point(38, 4);
      this.numAmount.Name = "numAmount";
      this.numAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numAmount.Properties.IsFloatValue = false;
      this.numAmount.Properties.Mask.EditMask = "N00";
      this.numAmount.Size = new System.Drawing.Size(144, 20);
      this.numAmount.StyleController = this.layoutControl1;
      this.numAmount.TabIndex = 5;
      // 
      // labelControl1
      // 
      this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.labelControl1.Location = new System.Drawing.Point(2, 7);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(32, 13);
      this.labelControl1.StyleController = this.layoutControl1;
      this.labelControl1.TabIndex = 4;
      this.labelControl1.Text = "Every:";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
      this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
      this.layoutControlGroup1.Name = "Root";
      columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition1.Width = 36D;
      columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
      columnDefinition2.Width = 100D;
      columnDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition3.Width = 27D;
      this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
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
      this.layoutControlGroup1.Size = new System.Drawing.Size(211, 29);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.labelControl1;
      this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 2);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem1.Size = new System.Drawing.Size(36, 24);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem1.TrimClientAreaToControl = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.numAmount;
      this.layoutControlItem2.Location = new System.Drawing.Point(36, 2);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem2.Size = new System.Drawing.Size(148, 24);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.lblUnits;
      this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      this.layoutControlItem3.Location = new System.Drawing.Point(184, 2);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 2;
      this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem3.Size = new System.Drawing.Size(27, 24);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem3.TrimClientAreaToControl = false;
      // 
      // RecurringPeriodControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "RecurringPeriodControl";
      this.Size = new System.Drawing.Size(211, 29);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numAmount.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.LabelControl lblUnits;
    private DevExpress.XtraEditors.SpinEdit numAmount;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
  }
}
