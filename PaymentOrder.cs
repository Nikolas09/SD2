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
    public partial class PaymentOrder : Form
    {
        public PaymentOrder()
        {
            InitializeComponent();
        }

        private void PaymentOrder_Load(object sender, EventArgs e)
        {
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PaymentOrderDataset.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.PaymentOrderDataset.DataTable1, startDate.Value.ToString(), endDate.Value.ToString());
            this.reportViewer1.RefreshReport();

        }
    }
}
