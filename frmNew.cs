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
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            SlipRep rpt = new SlipRep();
            crystalReportViewer.ReportSource = rpt;
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
