using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Payroll
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void InitializeComponent()
        {
            this.login_options_box = new System.Windows.Forms.GroupBox();
            this.Admin = new System.Windows.Forms.Button();
            this.emp_Button = new System.Windows.Forms.Button();
            this.login_options_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_options_box
            // 
            this.login_options_box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_options_box.BackColor = System.Drawing.Color.OliveDrab;
            this.login_options_box.Controls.Add(this.Admin);
            this.login_options_box.Controls.Add(this.emp_Button);
            this.login_options_box.Dock = System.Windows.Forms.DockStyle.Right;
            this.login_options_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_options_box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_options_box.Location = new System.Drawing.Point(1239, 0);
            this.login_options_box.Name = "login_options_box";
            this.login_options_box.Size = new System.Drawing.Size(200, 623);
            this.login_options_box.TabIndex = 1;
            this.login_options_box.TabStop = false;
            this.login_options_box.Text = "Login As:";
            this.login_options_box.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Admin
            // 
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(31, 519);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(144, 54);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // emp_Button
            // 
            this.emp_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_Button.Location = new System.Drawing.Point(31, 319);
            this.emp_Button.Name = "emp_Button";
            this.emp_Button.Size = new System.Drawing.Size(144, 54);
            this.emp_Button.TabIndex = 0;
            this.emp_Button.Text = "Employee";
            this.emp_Button.UseVisualStyleBackColor = true;
            this.emp_Button.Click += new System.EventHandler(this.emp_Button_Click);
            // 
            // LoginPage
            // 
            this.BackgroundImage = global::MDI_Payroll.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1439, 623);
            this.Controls.Add(this.login_options_box);
            this.IsMdiContainer = true;
            this.Name = "LoginPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginPage_Load_1);
            this.login_options_box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void LoginPage_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void emp_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            LoginCheck login = new LoginCheck();
            login.Show();
        }
    }
}
