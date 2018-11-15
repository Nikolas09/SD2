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
            crystalReportViewer.ReportSource = cr;
        }

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
    }
}
