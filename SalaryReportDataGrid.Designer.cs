namespace MDI_Payroll
{
    partial class SalaryReportDataGrid
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
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newDataGridView = new System.Windows.Forms.DataGridView();
            this.salaryDataSet = new MDI_Payroll.salaryDataSet();
            this.salaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(404, 36);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(153, 49);
            this.id_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(241, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter ID";
            // 
            // newDataGridView
            // 
            this.newDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newDataGridView.Location = new System.Drawing.Point(-3, 135);
            this.newDataGridView.Name = "newDataGridView";
            this.newDataGridView.RowTemplate.Height = 24;
            this.newDataGridView.Size = new System.Drawing.Size(1243, 376);
            this.newDataGridView.TabIndex = 3;
            // 
            // salaryDataSet
            // 
            this.salaryDataSet.DataSetName = "salaryDataSet";
            this.salaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryDataSetBindingSource
            // 
            this.salaryDataSetBindingSource.DataSource = this.salaryDataSet;
            this.salaryDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalaryReportDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_txt);
            this.IsMdiContainer = true;
            this.Name = "SalaryReportDataGrid";
            this.Text = "SalaryReportDataGrid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalaryReportDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView newDataGridView;
        private System.Windows.Forms.BindingSource salaryDataSetBindingSource;
        private salaryDataSet salaryDataSet;
        private System.Windows.Forms.Button button1;
    }
}