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
    public partial class salaryRegistrationForm : Form
    {
        public salaryRegistrationForm()
        {
            InitializeComponent();
        }
        string conString = "Data Source=DESKTOP-QLP0JCN;Initial Catalog=sd2;Integrated Security=True";

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void salaryRegistrationForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            string selectSql = "SELECT salary_id from tbl_salary";
            string selectSq2 = "select user_id from tbl_user";
            SqlCommand com = new SqlCommand(selectSql, con);
            SqlCommand com2 = new SqlCommand(selectSq2, con);
            try
            {
                con.Open();

                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtSalID.Text = reader["salary_id"].ToString();
                        int val = 0,aa=0;
                        Int32.TryParse(txtSalID.Text, out val);
                        aa = 1 + Convert.ToInt32(txtSalID.Text);
                        txtSalID.Text = aa.ToString();

                       
                        
                    }
                }

                using (SqlDataReader reader2 = com2.ExecuteReader())
                {
                    while(reader2.Read())
                    {
                        txtUserID.Text = reader2["user_id"].ToString();
                        int val2 = 0;
                        Int32.TryParse(txtUserID.Text, out val2);
                        //aa2 = 1 + Convert.ToInt32(txtUserID.Text);
                        //txtUserID.Text = aa2.ToString();
                    }
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_salary(user_id,hourly_rate,overtime_rate,working_hours,flat_amount) values ('" + txtUserID.Text + "','" + txtrate.Text + "','" + txtOver.Text + "','" + txthours.Text + "','" + txtFlat.Text + "')", con);
            SqlCommand cm2 = new SqlCommand("update tbl_user set salary_id ='" + txtSalID.Text + "' where user_id = '" + txtUserID.Text + "'" , con);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Registration has been Completed");
            }
            else
            {
                MessageBox.Show("Error..please try again!");
            }
            cm2.ExecuteNonQuery();
            con.Close();
        }

        private void ViewRecord_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
