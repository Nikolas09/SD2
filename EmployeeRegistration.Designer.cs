namespace MDI_Payroll
{
    partial class EmployeeRegistration
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewRecord = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.empl_ID = new System.Windows.Forms.TextBox();
            this.BasicWorkingTime = new System.Windows.Forms.MaskedTextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.DateOfJoining = new System.Windows.Forms.DateTimePicker();
            this.Salary = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.ComboBox();
            this.BloodGroup = new System.Windows.Forms.ComboBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.MobileNo = new System.Windows.Forms.MaskedTextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox2.Controls.Add(this.ViewRecord);
            this.GroupBox2.Controls.Add(this.Delete);
            this.GroupBox2.Controls.Add(this.Save);
            this.GroupBox2.Controls.Add(this.NewRecord);
            this.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox2.Location = new System.Drawing.Point(1145, 145);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(179, 236);
            this.GroupBox2.TabIndex = 52;
            this.GroupBox2.TabStop = false;
            // 
            // ViewRecord
            // 
            this.ViewRecord.BackColor = System.Drawing.Color.Transparent;
            this.ViewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecord.ForeColor = System.Drawing.Color.OliveDrab;
            this.ViewRecord.Location = new System.Drawing.Point(21, 165);
            this.ViewRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewRecord.Name = "ViewRecord";
            this.ViewRecord.Size = new System.Drawing.Size(132, 36);
            this.ViewRecord.TabIndex = 4;
            this.ViewRecord.Text = "Exit";
            this.ViewRecord.UseVisualStyleBackColor = false;
            this.ViewRecord.Click += new System.EventHandler(this.ViewRecord_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.OliveDrab;
            this.Delete.Location = new System.Drawing.Point(21, 122);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 36);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.OliveDrab;
            this.Save.Location = new System.Drawing.Point(21, 78);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(132, 36);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.BackColor = System.Drawing.Color.Transparent;
            this.NewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.ForeColor = System.Drawing.Color.OliveDrab;
            this.NewRecord.Location = new System.Drawing.Point(21, 34);
            this.NewRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(132, 36);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = false;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.Controls.Add(this.empl_ID);
            this.GroupBox1.Controls.Add(this.BasicWorkingTime);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.EmployeeName);
            this.GroupBox1.Controls.Add(this.DateOfJoining);
            this.GroupBox1.Controls.Add(this.Salary);
            this.GroupBox1.Controls.Add(this.Department);
            this.GroupBox1.Controls.Add(this.BloodGroup);
            this.GroupBox1.Controls.Add(this.Email);
            this.GroupBox1.Controls.Add(this.MobileNo);
            this.GroupBox1.Controls.Add(this.Address);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.OliveDrab;
            this.GroupBox1.Location = new System.Drawing.Point(268, 144);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(1056, 473);
            this.GroupBox1.TabIndex = 51;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Employee Registration Form:";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // empl_ID
            // 
            this.empl_ID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.empl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empl_ID.Location = new System.Drawing.Point(309, 73);
            this.empl_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empl_ID.Name = "empl_ID";
            this.empl_ID.Size = new System.Drawing.Size(181, 28);
            this.empl_ID.TabIndex = 29;
            // 
            // BasicWorkingTime
            // 
            this.BasicWorkingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicWorkingTime.Location = new System.Drawing.Point(309, 410);
            this.BasicWorkingTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BasicWorkingTime.Mask = "00:00";
            this.BasicWorkingTime.Name = "BasicWorkingTime";
            this.BasicWorkingTime.Size = new System.Drawing.Size(107, 28);
            this.BasicWorkingTime.TabIndex = 10;
            this.BasicWorkingTime.ValidatingType = typeof(System.DateTime);
            this.BasicWorkingTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.BasicWorkingTime_MaskInputRejected);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label12.Location = new System.Drawing.Point(35, 414);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(219, 24);
            this.Label12.TabIndex = 28;
            this.Label12.Text = "* Basic Working Hours";
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // EmployeeName
            // 
            this.EmployeeName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(309, 114);
            this.EmployeeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(509, 28);
            this.EmployeeName.TabIndex = 1;
            // 
            // DateOfJoining
            // 
            this.DateOfJoining.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfJoining.CustomFormat = "dd/MMM/yyyy";
            this.DateOfJoining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfJoining.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfJoining.Location = new System.Drawing.Point(309, 330);
            this.DateOfJoining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateOfJoining.Name = "DateOfJoining";
            this.DateOfJoining.Size = new System.Drawing.Size(181, 28);
            this.DateOfJoining.TabIndex = 8;
            this.DateOfJoining.ValueChanged += new System.EventHandler(this.DateOfJoining_ValueChanged);
            // 
            // Salary
            // 
            this.Salary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(309, 372);
            this.Salary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salary.Multiline = true;
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(107, 27);
            this.Salary.TabIndex = 9;
            this.Salary.Text = "Euro: ";
            this.Salary.TextChanged += new System.EventHandler(this.Salary_TextChanged);
            // 
            // Department
            // 
            this.Department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.FormattingEnabled = true;
            this.Department.Items.AddRange(new object[] {
            "Software Developer",
            "Web Developer",
            "Accounting"});
            this.Department.Location = new System.Drawing.Point(309, 290);
            this.Department.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(509, 30);
            this.Department.TabIndex = 6;
            // 
            // BloodGroup
            // 
            this.BloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.BloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroup.FormattingEnabled = true;
            this.BloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.BloodGroup.Location = new System.Drawing.Point(309, 256);
            this.BloodGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.Size = new System.Drawing.Size(68, 30);
            this.BloodGroup.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(309, 222);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(509, 27);
            this.Email.TabIndex = 4;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // MobileNo
            // 
            this.MobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(309, 187);
            this.MobileNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MobileNo.Mask = "(99) 000-000";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(127, 28);
            this.MobileNo.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(309, 149);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(509, 27);
            this.Address.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label10.Location = new System.Drawing.Point(35, 222);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(75, 24);
            this.Label10.TabIndex = 9;
            this.Label10.Text = " E-Mail";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label9.Location = new System.Drawing.Point(35, 78);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(137, 24);
            this.Label9.TabIndex = 8;
            this.Label9.Text = "*Employee ID";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label8.Location = new System.Drawing.Point(35, 373);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(137, 24);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "* Basic Salary";
            this.Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label7.Location = new System.Drawing.Point(35, 334);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(172, 24);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "*Start Working on";
            this.Label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label6.Location = new System.Drawing.Point(35, 294);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(125, 24);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "*Department";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label5.Location = new System.Drawing.Point(35, 258);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(134, 24);
            this.Label5.TabIndex = 4;
            this.Label5.Text = " Blood Group";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label4.Location = new System.Drawing.Point(35, 148);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(95, 24);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "*Address";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label3.Location = new System.Drawing.Point(35, 186);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(127, 24);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "*Contact No.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.Label1.Location = new System.Drawing.Point(35, 112);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(173, 24);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "*Employee Name";
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDI_Payroll.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 703);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeRegistration";
            this.Text = "EmployeeRegistration";
            this.Load += new System.EventHandler(this.EmployeeRegistration_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button ViewRecord;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.MaskedTextBox BasicWorkingTime;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox EmployeeName;
        internal System.Windows.Forms.DateTimePicker DateOfJoining;
        internal System.Windows.Forms.TextBox Salary;
        internal System.Windows.Forms.ComboBox Department;
        internal System.Windows.Forms.ComboBox BloodGroup;
        internal System.Windows.Forms.TextBox Email;
        internal System.Windows.Forms.MaskedTextBox MobileNo;
        internal System.Windows.Forms.TextBox Address;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox empl_ID;
    }
}