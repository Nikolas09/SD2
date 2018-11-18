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
    public partial class RegistationForm : Form
    {
        public RegistationForm()
        {
            InitializeComponent();
        }

        string conString = "Data Source=DESKTOP-43RRQ63\\SQLEXPRESS;Initial Catalog=sd2;Integrated Security=True";

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string s = "SELECT IDENT_CURRENT('tbl_salary')+1";
            //SqlCommand cmd = new SqlCommand(s, obj.con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //int i = Convert.ToInt16(dr["Id"].ToString());
            //txtId.Text = (i + 1).ToString();

            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_user(fname, lname,address,contact_no,email,blood_type,title,username,password) values ('" + txtName.Text + "','" + txtSur.Text + "','" + txtaddress.Text + "','" + txtMoNo.Text + "','" + txtEmail.Text + "','" + txtBG.Text + "','" + txtTitle.Text + "','" + txtUsername.Text + "','" + txtPass.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i!=0)
            {
                MessageBox.Show("Details Saved \nProceeding with Salary Registration Form...");
                salaryRegistrationForm sal = new salaryRegistrationForm();
                sal.Show();
            }
            else
            {
                MessageBox.Show("Error..Please try again!");
            }
            con.Close();
        }

        private void ViewRecord_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
