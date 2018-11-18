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
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }
        public void LinkReport(CrystalDecisions.CrystalReports.Engine.ReportDocument cr)
        {
           // crystalReportViewer.ReportSource = cr;
        }
        string conString = "Data Source=DESKTOP-QLP0JCN;Initial Catalog=sd2;Integrated Security=True";

        private void frmNew_Load(object sender, EventArgs e)
        {
            //frmPayslip ne = new frmPayslip();


            //SalaryReportWithoutOver rpt = new SalaryReportWithoutOver(); //The report you created.
            //SqlConnection myCon;
            //SqlDataAdapter myAdapter;
            //SalaryWithoutOvertimeDataset myDataset = new SalaryWithoutOvertimeDataset(); //The DataSet you created.
            //myCon = new SqlConnection("Data Source = DESKTOP - QLP0JCN; Initial Catalog = sd2; Integrated Security = True");

            //myAdapter = new SqlDataAdapter("select fname, lname ,working_hours, hourly_rate,salary_amount = working_hours*hourly_rate+flat_amount  from tbl_user, tbl_salary where tbl_user.user_id = tbl_salary.user_id and tbl_user.user_id like '" + ne..Text + "' or fname like '" + user_ID.Text + "%'", myCon);
            //myAdapter.Fill(myDataset, "tbl_user");
            //rpt.SetDataSource(myDataset);
            //crystalReportViewer.ReportSource = rpt;
            //crystalReportViewer.Refresh();
        }
        

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            string selectSq1 = "select user_id,fname, lname,address,contact_no,email,blood_type,title,username,password,salary_id from tbl_user where user_id = '" + Convert.ToInt32(txtSearch.Text) + "'";
            
            string selectSq2 = "SELECT user_id,hourly_rate,overtime_rate,working_hours,flat_amount from tbl_salary where user_id = '" + Convert.ToInt32(txtSearch.Text) + "'";

            string selectSq3 = "SELECT user_id from tbl_user where user_id = '" + Convert.ToInt32(txtSearch.Text) + "'";
            con.Open();
            SqlCommand com = new SqlCommand(selectSq1, con);
            SqlCommand com2 = new SqlCommand(selectSq2, con);
            SqlCommand com3 = new SqlCommand(selectSq3, con);
            SqlDataReader reader3 = com3.ExecuteReader();
            
            //int i = com.ExecuteNonQuery();
            if (reader3.Read())
            {
                con.Close();
                try
                {

                    con.Open();

                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtName.Text = reader["fname"].ToString();
                            txtSur.Text = reader["lname"].ToString();
                            txtaddress.Text = reader["address"].ToString();
                            txtMoNo.Text = reader["contact_no"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtBG.Text = reader["blood_type"].ToString();
                            txtTitle.Text = reader["title"].ToString();
                            txtUsername.Text = reader["username"].ToString();
                            txtPass.Text = reader["password"].ToString();
                            txtSalID.Text = reader["salary_id"].ToString();


                        }
                    }

                    using (SqlDataReader reader2 = com2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            txtUserID.Text = reader2["user_id"].ToString();
                            txtrate.Text = reader2["hourly_rate"].ToString();
                            txtOver.Text = reader2["overtime_rate"].ToString();
                            txthours.Text = reader2["working_hours"].ToString();
                            txtFlat.Text = reader2["flat_amount"].ToString();

                            //int val2 = 0;
                            //Int32.TryParse(txtUserID.Text, out val2);


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
            else
            {
                MessageBox.Show("The User Id does not exist, please try again!");
            }
            }

        private void ViewRecord_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbl_user set fname ='" + txtName.Text + "',lname ='" + txtSur.Text + "',address ='" + txtaddress.Text + "', contact_no ='" + txtMoNo.Text + "',email ='" + txtEmail.Text + "', blood_type ='" + txtBG.Text + "', title ='" + txtTitle.Text + "', username ='" + txtUsername.Text + "', password ='" + txtPass.Text + "', salary_id ='" + Convert.ToInt32(txtSalID.Text) + "'where user_id = '" + Convert.ToInt32(txtSearch.Text) + "'", con);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change this record?", "Attention", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Changes saved successfully!");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            con.Close();
        }
    }
    
}
