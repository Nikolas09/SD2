using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MDI_Payroll
{
    public partial class LoginCheck : Form
    {
        public LoginCheck()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-43RRQ63\\SQLEXPRESS;Initial Catalog=Payroll;Integrated Security=True";
        private void password_box_TextChanged(object sender, EventArgs e)
        {
            password_box.PasswordChar = '*';
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from Payroll_Login where username=@usr and password=@pwd", con);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", username_box.Text);
            scmd.Parameters.AddWithValue("@pwd", password_box.Text);
            //con.Open();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (scmd.ExecuteScalar().ToString()=="1")
            {
                MessageBox.Show("You have succesfully login in!!");
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("please enter valid username and password!");
                username_box.Clear();
                password_box.Clear();

            }
            con.Close();
            
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void LoginCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
