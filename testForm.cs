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
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }

        private void payroll_EmployeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payroll_EmployeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payrollDataSet_new);

        }

        private void testForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollDataSet_new.Payroll_Employee' table. You can move, or remove it, as needed.
            this.payroll_EmployeeTableAdapter.Fill(this.payrollDataSet_new.Payroll_Employee);

        }
    }
}
