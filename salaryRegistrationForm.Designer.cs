namespace MDI_Payroll
{
    partial class salaryRegistrationForm
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
            this.Save = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txthours = new System.Windows.Forms.TextBox();
            this.txtOver = new System.Windows.Forms.MaskedTextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFlat = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.ViewRecord);
            this.GroupBox2.Controls.Add(this.Save);
            this.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox2.Location = new System.Drawing.Point(658, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(134, 147);
            this.GroupBox2.TabIndex = 56;
            this.GroupBox2.TabStop = false;
            // 
            // ViewRecord
            // 
            this.ViewRecord.BackColor = System.Drawing.Color.Transparent;
            this.ViewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecord.ForeColor = System.Drawing.Color.DarkBlue;
            this.ViewRecord.Location = new System.Drawing.Point(19, 84);
            this.ViewRecord.Name = "ViewRecord";
            this.ViewRecord.Size = new System.Drawing.Size(99, 29);
            this.ViewRecord.TabIndex = 4;
            this.ViewRecord.Text = "Exit";
            this.ViewRecord.UseVisualStyleBackColor = false;
            this.ViewRecord.Click += new System.EventHandler(this.ViewRecord_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.DarkBlue;
            this.Save.Location = new System.Drawing.Point(19, 41);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 29);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.BackgroundImage = global::MDI_Payroll.Properties.Resources.background0;
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.txtFlat);
            this.GroupBox1.Controls.Add(this.txtSalID);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.txtUserID);
            this.GroupBox1.Controls.Add(this.txthours);
            this.GroupBox1.Controls.Add(this.txtOver);
            this.GroupBox1.Controls.Add(this.txtrate);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.SkyBlue;
            this.GroupBox1.Location = new System.Drawing.Point(71, 63);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(792, 433);
            this.GroupBox1.TabIndex = 55;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Salary Registration Form:";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtSalID
            // 
            this.txtSalID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalID.Location = new System.Drawing.Point(232, 66);
            this.txtSalID.Name = "txtSalID";
            this.txtSalID.Size = new System.Drawing.Size(67, 24);
            this.txtSalID.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Salary Id";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(232, 102);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(67, 24);
            this.txtUserID.TabIndex = 1;
            // 
            // txthours
            // 
            this.txthours.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txthours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthours.Location = new System.Drawing.Point(232, 217);
            this.txthours.Multiline = true;
            this.txthours.Name = "txthours";
            this.txthours.Size = new System.Drawing.Size(67, 23);
            this.txthours.TabIndex = 4;
            // 
            // txtOver
            // 
            this.txtOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOver.Location = new System.Drawing.Point(232, 176);
            this.txtOver.Name = "txtOver";
            this.txtOver.Size = new System.Drawing.Size(67, 24);
            this.txtOver.TabIndex = 3;
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(232, 137);
            this.txtrate.Multiline = true;
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(67, 23);
            this.txtrate.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label10.Location = new System.Drawing.Point(26, 267);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(97, 18);
            this.Label10.TabIndex = 9;
            this.Label10.Text = "Flat amount";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label5.Location = new System.Drawing.Point(26, 222);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(122, 18);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Working Hours";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label4.Location = new System.Drawing.Point(26, 137);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 18);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Rate/Hour";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label3.Location = new System.Drawing.Point(26, 175);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 18);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Overtime rate";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label1.Location = new System.Drawing.Point(26, 100);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 18);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "user id";
            // 
            // txtFlat
            // 
            this.txtFlat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlat.Location = new System.Drawing.Point(232, 262);
            this.txtFlat.Multiline = true;
            this.txtFlat.Name = "txtFlat";
            this.txtFlat.Size = new System.Drawing.Size(67, 23);
            this.txtFlat.TabIndex = 34;
            // 
            // salaryRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDI_Payroll.Properties.Resources.background0;
            this.ClientSize = new System.Drawing.Size(936, 555);
            this.Controls.Add(this.GroupBox1);
            this.IsMdiContainer = true;
            this.Name = "salaryRegistrationForm";
            this.Text = "salaryRegistrationForm";
            this.Load += new System.EventHandler(this.salaryRegistrationForm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button ViewRecord;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtSalID;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.TextBox txthours;
        internal System.Windows.Forms.MaskedTextBox txtOver;
        internal System.Windows.Forms.TextBox txtrate;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtFlat;
    }
}