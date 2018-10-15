namespace MDI_Payroll
{
    partial class EmployeeAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewRecord = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update_Record = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.BasicWorkingTime = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.OutTime = new System.Windows.Forms.DateTimePicker();
            this.InTime = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.Overtime = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeID = new System.Windows.Forms.ComboBox();
            this.WorkingDate = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(581, 28);
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.Size = new System.Drawing.Size(244, 417);
            this.DataGridView1.TabIndex = 12;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ViewRecord);
            this.GroupBox1.Controls.Add(this.Delete);
            this.GroupBox1.Controls.Add(this.Update_Record);
            this.GroupBox1.Controls.Add(this.Save);
            this.GroupBox1.Controls.Add(this.NewRecord);
            this.GroupBox1.Location = new System.Drawing.Point(843, 22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(134, 216);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            // 
            // ViewRecord
            // 
            this.ViewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecord.Location = new System.Drawing.Point(16, 168);
            this.ViewRecord.Name = "ViewRecord";
            this.ViewRecord.Size = new System.Drawing.Size(99, 29);
            this.ViewRecord.TabIndex = 4;
            this.ViewRecord.Text = "&View Record";
            this.ViewRecord.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(16, 133);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 29);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update_Record
            // 
            this.Update_Record.Enabled = false;
            this.Update_Record.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Record.Location = new System.Drawing.Point(16, 98);
            this.Update_Record.Name = "Update_Record";
            this.Update_Record.Size = new System.Drawing.Size(99, 29);
            this.Update_Record.TabIndex = 2;
            this.Update_Record.Text = "&Update";
            this.Update_Record.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(16, 63);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 29);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // NewRecord
            // 
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(16, 28);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(99, 29);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TextBox2);
            this.GroupBox2.Controls.Add(this.TextBox1);
            this.GroupBox2.Controls.Add(this.BasicWorkingTime);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Status);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.OutTime);
            this.GroupBox2.Controls.Add(this.InTime);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Overtime);
            this.GroupBox2.Controls.Add(this.Submit);
            this.GroupBox2.Controls.Add(this.EmployeeName);
            this.GroupBox2.Controls.Add(this.EmployeeID);
            this.GroupBox2.Controls.Add(this.WorkingDate);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(16, 21);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(547, 331);
            this.GroupBox2.TabIndex = 10;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Entry";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(216, 210);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(137, 24);
            this.TextBox2.TabIndex = 19;
            this.TextBox2.Visible = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(216, 247);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(137, 24);
            this.TextBox1.TabIndex = 18;
            this.TextBox1.Visible = false;
            // 
            // BasicWorkingTime
            // 
            this.BasicWorkingTime.Location = new System.Drawing.Point(216, 136);
            this.BasicWorkingTime.Name = "BasicWorkingTime";
            this.BasicWorkingTime.ReadOnly = true;
            this.BasicWorkingTime.Size = new System.Drawing.Size(76, 24);
            this.BasicWorkingTime.TabIndex = 17;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(31, 140);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(152, 21);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "Basic Working Time";
            // 
            // Status
            // 
            this.Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "A",
            "P"});
            this.Status.Location = new System.Drawing.Point(216, 171);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(44, 25);
            this.Status.TabIndex = 15;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(31, 175);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(54, 21);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Status";
            // 
            // OutTime
            // 
            this.OutTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutTime.CustomFormat = "hh:mm tt";
            this.OutTime.Enabled = false;
            this.OutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OutTime.Location = new System.Drawing.Point(216, 246);
            this.OutTime.Name = "OutTime";
            this.OutTime.Size = new System.Drawing.Size(137, 22);
            this.OutTime.TabIndex = 4;
            // 
            // InTime
            // 
            this.InTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InTime.CustomFormat = "hh:mm tt";
            this.InTime.Enabled = false;
            this.InTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InTime.Location = new System.Drawing.Point(216, 209);
            this.InTime.Name = "InTime";
            this.InTime.Size = new System.Drawing.Size(137, 22);
            this.InTime.TabIndex = 3;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(31, 246);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 21);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Out Time";
            // 
            // Overtime
            // 
            this.Overtime.Location = new System.Drawing.Point(216, 284);
            this.Overtime.Name = "Overtime";
            this.Overtime.ReadOnly = true;
            this.Overtime.Size = new System.Drawing.Size(76, 24);
            this.Overtime.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(450, 34);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(69, 29);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "&Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(216, 102);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Size = new System.Drawing.Size(303, 24);
            this.EmployeeName.TabIndex = 2;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EmployeeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EmployeeID.FormattingEnabled = true;
            this.EmployeeID.Location = new System.Drawing.Point(216, 71);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(201, 25);
            this.EmployeeID.TabIndex = 1;
            // 
            // WorkingDate
            // 
            this.WorkingDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingDate.CustomFormat = "dd/MMM/yyyy";
            this.WorkingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WorkingDate.Location = new System.Drawing.Point(216, 38);
            this.WorkingDate.Name = "WorkingDate";
            this.WorkingDate.Size = new System.Drawing.Size(137, 22);
            this.WorkingDate.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(31, 73);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(99, 21);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Employee ID";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(31, 284);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 21);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Overtime";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(31, 210);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 21);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "In Time";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(31, 41);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 21);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Date";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(31, 105);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(122, 21);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Employee Name";
            // 
            // EmployeeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 571);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Name = "EmployeeAttendance";
            this.Text = "EmployeeAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button ViewRecord;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Update_Record;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox BasicWorkingTime;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox Status;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DateTimePicker OutTime;
        internal System.Windows.Forms.DateTimePicker InTime;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox Overtime;
        internal System.Windows.Forms.Button Submit;
        internal System.Windows.Forms.TextBox EmployeeName;
        internal System.Windows.Forms.ComboBox EmployeeID;
        internal System.Windows.Forms.DateTimePicker WorkingDate;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
    }
}