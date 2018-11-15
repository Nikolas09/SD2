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
    public partial class frmPayslip : Form
    {
        //public SalaryWithoutOvertimeDataset ds = new SalaryWithoutOvertimeDataset();
        public frmPayslip()
        {
            InitializeComponent();
        }

        private void frmPayslip_Load(object sender, EventArgs e)
        {
            
            //testReport pay = new testReport();
            //crystalReportViewer.ReportSource = pay;
            //crystalReportViewer.Refresh();
            
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //payslipTestReport rpt = new payslipTestReport(); //The report you created.
            //SqlConnection myCon;
            //SqlDataAdapter myAdapter;
            //salaryDataSet myDataset = new salaryDataSet(); //The DataSet you created.
            //myCon = new SqlConnection("Data Source=DESKTOP-QLP0JCN;Initial Catalog=sd2;Integrated Security=True");
            
            //myAdapter = new SqlDataAdapter("Select * FROM tbl_user where user_id like '" + user_ID.Text + "'", myCon);
            //myAdapter.Fill(myDataset, "tbl_user");
            //rpt.SetDataSource(myDataset);
            //crystalReportViewer.ReportSource = rpt;
            //crystalReportViewer.Refresh();


            string sql = "select fname, lname ,working_hours, hourly_rate,salary_amount = working_hours*hourly_rate+flat_amount  from tbl_user, tbl_salary where tbl_user.user_id = tbl_salary.user_id and tbl_user.user_id like '" + user_ID.Text + "' or fname like '" + user_ID.Text + "%'";
            //string sql = "select * from tbl_user where user_id = @id or fname = @name ";
            //sqlcommand. com = new sqlcommand
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QLP0JCN;Initial Catalog=sd2;Integrated Security=True");
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);

            SqlCommand com = new SqlCommand(sql, connection);
            com.Parameters.Clear();
            //  com.Parameters.AddWithValue("@id", id);
            //  com.Parameters.AddWithValue("@name", id);

            SalaryWithoutOvertimeDataset ds = new SalaryWithoutOvertimeDataset();
            ds.EnforceConstraints = false;
            connection.Open();
            dataadapter.Fill(ds, "tbl_user");
            connection.Close();
            dataGridView.DataSource = ds;
            dataGridView.DataMember = "tbl_user";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //SalaryReportWithoutOver cr = new SalaryReportWithoutOver();
            //cr.SetDataSource(ds);
            frmNew f = new frmNew();
            //f.LinkReport(cr);
            //f.Show();

            SalaryReportWithoutOver rpt = new SalaryReportWithoutOver();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QLP0JCN;Initial Catalog=sd2;Integrated Security=True");
            SqlDataAdapter myadapter;
            SalaryWithoutOvertimeDataset ds = new SalaryWithoutOvertimeDataset();
            ds.EnforceConstraints = false;
            myadapter = new SqlDataAdapter("select fname, lname from tbl_user; select working_hours, hourly_rate,salary_amount = working_hours*hourly_rate+flat_amount  from tbl_user, tbl_salary where tbl_user.user_id = tbl_salary.user_id and tbl_salary.user_id like '" + user_ID.Text + "' or fname like '" + user_ID.Text + "%'",con);
            myadapter.Fill(ds);
            ds.Tables(0).TableName = "tbl_user";

            rpt.SetDataSource(ds);
         
            f.LinkReport(rpt);
            f.Show();



        }
    }
}
