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
            payslipTestReport rpt = new payslipTestReport(); //The report you created.
            SqlConnection myCon;
            SqlDataAdapter myAdapter;
            salaryDataSet myDataset = new salaryDataSet(); //The DataSet you created.
            myCon = new SqlConnection("Data Source=DESKTOP-43RRQ63\\SQLEXPRESS;Initial Catalog=sd2;Integrated Security=True");

            myAdapter = new SqlDataAdapter("Select * FROM tbl_user where user_id like '" + user_ID.Text + "'", myCon);
            myAdapter.Fill(myDataset, "tbl_user");
            rpt.SetDataSource(myDataset);
            crystalReportViewer.ReportSource = rpt;
            crystalReportViewer.Refresh();
        }
    }
}
