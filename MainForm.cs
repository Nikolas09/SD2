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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void loginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void w_Load(object sender, EventArgs e)
        {

        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salarySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SalarySlip payslip = new SalarySlip();
            //payslip.Show();
            frmPayslip pay = new frmPayslip();
            pay.Show();
        }

        private void paymentOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentOrder payOrder = new PaymentOrder();
            payOrder.Show();
        }

        private void newEmployeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EmployeeRegistration empl_registration = new EmployeeRegistration();
            //empl_registration.Show();

            RegistationForm re = new RegistationForm();
            re.Show();
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchEmp semp = new SearchEmp();
            semp.Show();
        }
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
        }

        class MenuColorTable : ProfessionalColorTable
        {
            public MenuColorTable()
            {
                base.UseSystemColors = false;
            }
            public override System.Drawing.Color MenuBorder
            {
                get { return Color.White; }
            }
            public override System.Drawing.Color MenuItemBorder
            {
                get { return Color.Blue; }
            }
            public override System.Drawing.Color MenuItemSelected
            {
                get { return Color.WhiteSmoke; }
            }
            public override System.Drawing.Color MenuItemSelectedGradientBegin
            {
                get { return Color.Blue; }
            }
            public override System.Drawing.Color MenuItemSelectedGradientEnd
            {
                get { return Color.WhiteSmoke; }
            }
            public override System.Drawing.Color MenuStripGradientBegin
            {
                get { return Color.Blue; }
            }
            public override System.Drawing.Color MenuStripGradientEnd
            {
                get { return Color.Pink; }
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewEmploeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew neo = new frmNew();
            neo.Show();
        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void loginPageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
