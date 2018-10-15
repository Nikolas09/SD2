using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            testReport pay = new testReport();
            crystalReportViewer.ReportSource = pay;
            crystalReportViewer.Refresh();
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
