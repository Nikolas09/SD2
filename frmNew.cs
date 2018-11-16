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
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace MDI_Payroll
{
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-43RRQ63\\SQLEXPRESS;Initial Catalog=sd2;Integrated Security=True";
    

        public void LinkReport(CrystalDecisions.CrystalReports.Engine.ReportDocument cr)
        {
            crystalReportViewer.ReportSource = cr;
        }
        private void frmNew_Load(object sender, EventArgs e)
        {
            //ReportSalaryTest rpt = new ReportSalaryTest();
            //crystalReportViewer.ReportSource = rpt;
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string sql = "select fname, lname from tbl_user; select working_hours, hourly_rate, salary_amount = working_hours * hourly_rate + flat_amount  from tbl_user, tbl_salary where tbl_user.user_id = tbl_salary.user_id and tbl_salary.user_id like '" + user_txt.Text + "' or fname like '" + user_txt.Text + "%'";

           
            SalaryDatasetTest testds = new SalaryDatasetTest();
            SqlConnection cnn = new SqlConnection(conString);
            SqlCommand testcmd = new SqlCommand(sql, cnn);
            testcmd.CommandType = CommandType.Text;
            SqlDataAdapter testda = new SqlDataAdapter(testcmd);
            testda.Fill(testds, "tbl_user");
            cnn.Open();
            ReportSalaryTest myReportDocument;
            myReportDocument = new ReportSalaryTest();
           // myReportDocument.Load(@"D:\Reports\rptitemintrans.rpt");
            myReportDocument.SetDataSource(testds);
            //myReportDocument.SetDatabaseLogon("username", "pwd");
            crystalReportViewer.ReportSource = myReportDocument;
            crystalReportViewer.DisplayToolbar = true;



        }
    }
}
   