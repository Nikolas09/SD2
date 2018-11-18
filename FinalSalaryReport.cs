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
    public partial class FinalSalaryReport : Form
    {
        public FinalSalaryReport()
        {
            InitializeComponent();
        }

        private void FinalSalaryReport_Load(object sender, EventArgs e)
        {
           
          
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalSalaryDataset.DataTable1' table. You can move, or remove it, as needed.
           
            this.DataTable1TableAdapter.Fill(this.FinalSalaryDataset.DataTable1,Convert.ToInt32(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
