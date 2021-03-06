﻿namespace Finances
{
  partial class EditAccountDialog
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.cboType = new DevExpress.XtraEditors.ComboBoxEdit();
      this.numBalance = new DevExpress.XtraEditors.SpinEdit();
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.txtDescription = new DevExpress.XtraEditors.TextEdit();
      this.cboParentAccount = new DevExpress.XtraEditors.GridLookUpEdit();
      this.accountNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewParentAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBalance.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboParentAccount.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.accountNodeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewParentAccount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.cboType);
      this.layoutControl1.Controls.Add(this.numBalance);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Controls.Add(this.txtDescription);
      this.layoutControl1.Controls.Add(this.cboParentAccount);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(628, 142, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(342, 167);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(174, 132);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(76, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 4;
      this.btnOK.Text = "OK";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(254, 132);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(76, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      // 
      // cboType
      // 
      this.cboType.Location = new System.Drawing.Point(72, 36);
      this.cboType.Name = "cboType";
      this.cboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboType.Properties.Sorted = true;
      this.cboType.Size = new System.Drawing.Size(258, 20);
      this.cboType.StyleController = this.layoutControl1;
      this.cboType.TabIndex = 1;
      // 
      // numBalance
      // 
      this.numBalance.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numBalance.Location = new System.Drawing.Point(72, 84);
      this.numBalance.Name = "numBalance";
      this.numBalance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numBalance.Properties.DisplayFormat.FormatString = "C2";
      this.numBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.numBalance.Size = new System.Drawing.Size(258, 20);
      this.numBalance.StyleController = this.layoutControl1;
      this.numBalance.TabIndex = 3;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(72, 12);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(258, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 0;
      // 
      // txtDescription
      // 
      this.txtDescription.Location = new System.Drawing.Point(72, 60);
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(258, 20);
      this.txtDescription.StyleController = this.layoutControl1;
      this.txtDescription.TabIndex = 2;
      // 
      // cboParentAccount
      // 
      this.cboParentAccount.Location = new System.Drawing.Point(72, 108);
      this.cboParentAccount.Name = "cboParentAccount";
      this.cboParentAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboParentAccount.Properties.DataSource = this.accountNodeBindingSource;
      this.cboParentAccount.Properties.DisplayMember = "Name";
      this.cboParentAccount.Properties.NullText = "[Select an account]";
      this.cboParentAccount.Properties.PopupView = this.gridViewParentAccount;
      this.cboParentAccount.Properties.ValueMember = "Id";
      this.cboParentAccount.Size = new System.Drawing.Size(258, 20);
      this.cboParentAccount.StyleController = this.layoutControl1;
      this.cboParentAccount.TabIndex = 6;
      // 
      // accountNodeBindingSource
      // 
      this.accountNodeBindingSource.DataSource = typeof(Finances.AccountNode);
      // 
      // gridViewParentAccount
      // 
      this.gridViewParentAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colType});
      this.gridViewParentAccount.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridViewParentAccount.Name = "gridViewParentAccount";
      this.gridViewParentAccount.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewParentAccount.OptionsView.ShowColumnHeaders = false;
      this.gridViewParentAccount.OptionsView.ShowGroupPanel = false;
      this.gridViewParentAccount.OptionsView.ShowIndicator = false;
      this.gridViewParentAccount.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.gridViewParentAccount.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridViewParentAccount_CustomRowFilter);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colType
      // 
      this.colType.FieldName = "Type";
      this.colType.Name = "colType";
      this.colType.Visible = true;
      this.colType.VisibleIndex = 1;
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
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(342, 167);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtName;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(322, 24);
      this.layoutControlItem1.Text = "Name:";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(57, 13);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.txtDescription;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(322, 24);
      this.layoutControlItem2.Text = "Description:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.numBalance;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(322, 24);
      this.layoutControlItem3.Text = "Balance:";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 13);
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.cboType;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(322, 24);
      this.layoutControlItem4.Text = "Type:";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(57, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnCancel;
      this.layoutControlItem5.Location = new System.Drawing.Point(242, 120);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(80, 27);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnOK;
      this.layoutControlItem6.Location = new System.Drawing.Point(162, 120);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(80, 27);
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(162, 27);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.cboParentAccount;
      this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(322, 24);
      this.layoutControlItem7.Text = "Parent:";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(57, 13);
      // 
      // EditAccountDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(342, 167);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "EditAccountDialog";
      this.Text = "Edit Account";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBalance.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboParentAccount.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.accountNodeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewParentAccount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.TextEdit txtName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.TextEdit txtDescription;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SpinEdit numBalance;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraEditors.ComboBoxEdit cboType;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private System.Windows.Forms.BindingSource accountNodeBindingSource;
    private DevExpress.XtraEditors.GridLookUpEdit cboParentAccount;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewParentAccount;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colType;
  }
}