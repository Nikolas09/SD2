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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace MDI_Payroll
{
    public partial class SalarySlip : Form
    {
        public SalarySlip()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-QLP0JCN;Initial Catalog=sd2;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            bool temp = false;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Payroll_Employee where Emp_ID='" + empl_ID.Text.Trim() + "'", con);
           
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                EmployeeName.Text = dr.GetString(1);
                depart_box.Text = dr.GetString(6);
                start_work_box.Text = dr.GetString(7);
                salary_box.Text = dr.GetString(8);
                hours_box.Text = dr.GetString(9);

                temp = true;
            }
           
            
            
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();
            SqlConnection con2 = new SqlConnection(conString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Overtime_table where Emp_ID='" + empl_ID.Text.Trim() + "'", con2);

            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                rate_box.Text = dr2.GetString(1);
                over_hours.Text = dr2.GetString(3);
                

                temp = true;
            }



            if (temp == false)
                MessageBox.Show("not found");
            con2.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //SqlConnection cnn ;

            /*


             cnn = new SqlConnection(conString);
             cnn.Open();
             string sql = "SELECT * FROM Payroll_Employee  where Emp_ID like '%" + empl_ID.Text + "%' ";
             SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
             PayrollDataSet_new ds = new PayrollDataSet_new();
             dscmd.Fill(ds, "Payroll_Employee");
             MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
             cnn.Close();

             payslip objRpt = new payslip();
             objRpt.SetDataSource(ds.Tables[1]);
             frmPayslip ne = new frmPayslip();
             crystalReportViewer1.ReportSource = objRpt;
             crystalReportViewer1.Refresh();
             */



            frmPayslip pay = new frmPayslip();
            pay.Show();
        }

        private void SalarySlip_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
