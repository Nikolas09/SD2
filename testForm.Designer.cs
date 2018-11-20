namespace MDI_Payroll
{
    partial class testForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testForm));
            this.payrollDataSet_new = new MDI_Payroll.PayrollDataSet_new();
            this.payroll_EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payroll_EmployeeTableAdapter = new MDI_Payroll.PayrollDataSet_newTableAdapters.Payroll_EmployeeTableAdapter();
            this.tableAdapterManager = new MDI_Payroll.PayrollDataSet_newTableAdapters.TableAdapterManager();
            this.payroll_EmployeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.payroll_EmployeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.payroll_EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_EmployeeBindingNavigator)).BeginInit();
            this.payroll_EmployeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // payrollDataSet_new
            // 
            this.payrollDataSet_new.DataSetName = "PayrollDataSet_new";
            this.payrollDataSet_new.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payroll_EmployeeBindingSource
            // 
            this.payroll_EmployeeBindingSource.DataMember = "Payroll_Employee";
            this.payroll_EmployeeBindingSource.DataSource = this.payrollDataSet_new;
            // 
            // payroll_EmployeeTableAdapter
            // 
            this.payroll_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Overtime_tableTableAdapter = null;
            this.tableAdapterManager.Payroll_EmployeeTableAdapter = this.payroll_EmployeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = MDI_Payroll.PayrollDataSet_newTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // payroll_EmployeeBindingNavigator
            // 
            this.payroll_EmployeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.payroll_EmployeeBindingNavigator.BindingSource = this.payroll_EmployeeBindingSource;
            this.payroll_EmployeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.payroll_EmployeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.payroll_EmployeeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.payroll_EmployeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.payroll_EmployeeBindingNavigatorSaveItem});
            this.payroll_EmployeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.payroll_EmployeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.payroll_EmployeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.payroll_EmployeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.payroll_EmployeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.payroll_EmployeeBindingNavigator.Name = "payroll_EmployeeBindingNavigator";
            this.payroll_EmployeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.payroll_EmployeeBindingNavigator.Size = new System.Drawing.Size(1118, 27);
            this.payroll_EmployeeBindingNavigator.TabIndex = 0;
            this.payroll_EmployeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // payroll_EmployeeBindingNavigatorSaveItem
            // 
            this.payroll_EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.payroll_EmployeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("payroll_EmployeeBindingNavigatorSaveItem.Image")));
            this.payroll_EmployeeBindingNavigatorSaveItem.Name = "payroll_EmployeeBindingNavigatorSaveItem";
            this.payroll_EmployeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.payroll_EmployeeBindingNavigatorSaveItem.Text = "Save Data";
            this.payroll_EmployeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.payroll_EmployeeBindingNavigatorSaveItem_Click);
            // 
            // payroll_EmployeeDataGridView
            // 
            this.payroll_EmployeeDataGridView.AutoGenerateColumns = false;
            this.payroll_EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.payroll_EmployeeDataGridView.DataSource = this.payroll_EmployeeBindingSource;
            this.payroll_EmployeeDataGridView.Location = new System.Drawing.Point(12, 59);
            this.payroll_EmployeeDataGridView.Name = "payroll_EmployeeDataGridView";
            this.payroll_EmployeeDataGridView.RowTemplate.Height = 24;
            this.payroll_EmployeeDataGridView.Size = new System.Drawing.Size(1094, 275);
            this.payroll_EmployeeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Emp_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Emp_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Emp_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emp_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Emp_address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Emp_address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Emp_Tel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Emp_Tel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Emp_email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Emp_email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Emp_Blood";
            this.dataGridViewTextBoxColumn6.HeaderText = "Emp_Blood";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Emp_Department";
            this.dataGridViewTextBoxColumn7.HeaderText = "Emp_Department";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Emp_Start_Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Emp_Start_Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Emp_Salary";
            this.dataGridViewTextBoxColumn9.HeaderText = "Emp_Salary";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Emp_Basic_Hours";
            this.dataGridViewTextBoxColumn10.HeaderText = "Emp_Basic_Hours";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 627);
            this.Controls.Add(this.payroll_EmployeeDataGridView);
            this.Controls.Add(this.payroll_EmployeeBindingNavigator);
            this.Name = "testForm";
            this.Text = "testForm";
            this.Load += new System.EventHandler(this.testForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_EmployeeBindingNavigator)).EndInit();
            this.payroll_EmployeeBindingNavigator.ResumeLayout(false);
            this.payroll_EmployeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PayrollDataSet_new payrollDataSet_new;
        private System.Windows.Forms.BindingSource payroll_EmployeeBindingSource;
        private PayrollDataSet_newTableAdapters.Payroll_EmployeeTableAdapter payroll_EmployeeTableAdapter;
        private PayrollDataSet_newTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator payroll_EmployeeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton payroll_EmployeeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView payroll_EmployeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}