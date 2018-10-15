namespace MDI_Payroll
{
    partial class LoginCheck
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
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login_Button = new System.Windows.Forms.Button();
            this.back_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.ForeColor = System.Drawing.Color.OliveDrab;
            this.password_box.Location = new System.Drawing.Point(1032, 532);
            this.password_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_box.Multiline = true;
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(269, 57);
            this.password_box.TabIndex = 2;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // username_box
            // 
            this.username_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.ForeColor = System.Drawing.Color.OliveDrab;
            this.username_box.Location = new System.Drawing.Point(1032, 335);
            this.username_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_box.Multiline = true;
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(269, 57);
            this.username_box.TabIndex = 1;
            this.username_box.TextChanged += new System.EventHandler(this.username_box_TextChanged);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.OliveDrab;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Username.Location = new System.Drawing.Point(462, 335);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(276, 57);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username:";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.OliveDrab;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password.Location = new System.Drawing.Point(462, 536);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(276, 54);
            this.password.TabIndex = 4;
            this.password.Text = "Password:";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_Button.Location = new System.Drawing.Point(550, 742);
            this.login_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(213, 78);
            this.login_Button.TabIndex = 5;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_Button.Location = new System.Drawing.Point(978, 742);
            this.back_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(213, 78);
            this.back_Button.TabIndex = 6;
            this.back_Button.Text = "Back";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Location = new System.Drawing.Point(380, 285);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1003, 560);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LoginCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDI_Payroll.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1892, 825);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginCheck";
            this.Text = "LoginCheck";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}