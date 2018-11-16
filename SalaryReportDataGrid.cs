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
    public partial class SalaryReportDataGrid : Form
    {
        public SalaryReportDataGrid()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-43RRQ63\\SQLEXPRESS;Initial Catalog=sd2;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            //string sql = "select fname, lname from tbl_user where user_id like '" + id_txt.Text + "' or fname like '" + id_txt.Text + "%'";
            string sql= "select fname, lname ,working_hours, hourly_rate,salary_amount = working_hours*hourly_rate+flat_amount  from tbl_user, tbl_salary where tbl_user.user_id = tbl_salary.user_id and tbl_user.user_id like '" + id_txt.Text + "' or fname like '" + id_txt.Text + "%'"; 
            SqlConnection connection = new SqlConnection(conString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            SqlCommand com = new SqlCommand(sql, connection);
            com.Parameters.Clear();
          

            SalaryDatasetTest ds = new SalaryDatasetTest();
            ds.EnforceConstraints = false;
          //  ds.EnforceConstraints = false;
            connection.Open();
            dataadapter.Fill(ds,"tbl_user");
            connection.Close();
            newDataGridView.DataSource = ds;
            newDataGridView.DataMember = "tbl_user";
        }

        private void SalaryReportDataGrid_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNew ne = new frmNew();
            ne.Show();
        }
    }
}
