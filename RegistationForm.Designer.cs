namespace MDI_Payroll
{
    partial class RegistationForm
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
            this.txtTitle = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSur = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtBG = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMoNo = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
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
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.ViewRecord);
            this.GroupBox2.Controls.Add(this.Save);
            this.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox2.Location = new System.Drawing.Point(658, 1);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(134, 119);
            this.GroupBox2.TabIndex = 54;
            this.GroupBox2.TabStop = false;
            // 
            // ViewRecord
            // 
            this.ViewRecord.BackColor = System.Drawing.Color.Transparent;
            this.ViewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecord.ForeColor = System.Drawing.Color.DarkBlue;
            this.ViewRecord.Location = new System.Drawing.Point(16, 60);
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
            this.Save.Location = new System.Drawing.Point(16, 25);
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
            this.GroupBox1.Controls.Add(this.txtTitle);
            this.GroupBox1.Controls.Add(this.txtUsername);
            this.GroupBox1.Controls.Add(this.txtName);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.txtSur);
            this.GroupBox1.Controls.Add(this.txtPass);
            this.GroupBox1.Controls.Add(this.txtBG);
            this.GroupBox1.Controls.Add(this.txtEmail);
            this.GroupBox1.Controls.Add(this.txtMoNo);
            this.GroupBox1.Controls.Add(this.txtaddress);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.SkyBlue;
            this.GroupBox1.Location = new System.Drawing.Point(72, 97);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(792, 433);
            this.GroupBox1.TabIndex = 53;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Employee Registration Form:";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.FormattingEnabled = true;
            this.txtTitle.Items.AddRange(new object[] {
            "Mr",
            "Miss"});
            this.txtTitle.Location = new System.Drawing.Point(232, 263);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(52, 25);
            this.txtTitle.TabIndex = 32;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(232, 297);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(81, 23);
            this.txtUsername.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(232, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(383, 24);
            this.txtName.TabIndex = 29;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSur
            // 
            this.txtSur.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSur.Location = new System.Drawing.Point(232, 96);
            this.txtSur.Name = "txtSur";
            this.txtSur.Size = new System.Drawing.Size(383, 24);
            this.txtSur.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(232, 333);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(81, 23);
            this.txtPass.TabIndex = 9;
            // 
            // txtBG
            // 
            this.txtBG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBG.FormattingEnabled = true;
            this.txtBG.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.txtBG.Location = new System.Drawing.Point(232, 223);
            this.txtBG.Name = "txtBG";
            this.txtBG.Size = new System.Drawing.Size(52, 25);
            this.txtBG.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(232, 187);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtMoNo
            // 
            this.txtMoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoNo.Location = new System.Drawing.Point(232, 159);
            this.txtMoNo.Name = "txtMoNo";
            this.txtMoNo.Size = new System.Drawing.Size(96, 24);
            this.txtMoNo.TabIndex = 3;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(232, 128);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(383, 23);
            this.txtaddress.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label10.Location = new System.Drawing.Point(26, 187);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(61, 18);
            this.Label10.TabIndex = 9;
            this.Label10.Text = " E-Mail";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label8.Location = new System.Drawing.Point(26, 334);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(83, 18);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Password";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label7.Location = new System.Drawing.Point(26, 302);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(85, 18);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Username";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label6.Location = new System.Drawing.Point(26, 270);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(40, 18);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Title";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label5.Location = new System.Drawing.Point(26, 225);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(109, 18);
            this.Label5.TabIndex = 4;
            this.Label5.Text = " Blood Group";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label4.Location = new System.Drawing.Point(26, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 18);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "*Address";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label3.Location = new System.Drawing.Point(26, 158);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(106, 18);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "*Contact No.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label1.Location = new System.Drawing.Point(26, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 18);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Surname";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // RegistationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDI_Payroll.Properties.Resources.background0;
            this.ClientSize = new System.Drawing.Size(937, 578);
            this.Controls.Add(this.GroupBox1);
            this.IsMdiContainer = true;
            this.Name = "RegistationForm";
            this.Text = "RegistationForm";
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
        internal System.Windows.Forms.TextBox txtSur;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.ComboBox txtBG;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.MaskedTextBox txtMoNo;
        internal System.Windows.Forms.TextBox txtaddress;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox txtTitle;
        internal System.Windows.Forms.TextBox txtUsername;
    }
}