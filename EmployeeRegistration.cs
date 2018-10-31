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
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-43RRQ63\\SQLEXPRESS;Initial Catalog=sd2;Integrated Security=True";

        private void Email_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress("xyz@blabla.com");
            }
            catch (FormatException ex)
            {
                // wrong e-mail address
            }
        }

        private void BasicWorkingTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void DateOfJoining_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
            empl_ID.Clear();
            EmployeeName.Clear();
            Address.Clear();
            MobileNo.Clear();
            Email.Clear();
            BloodGroup.ResetText();
            Department.ResetText();
            DateOfJoining.ResetText();
            Salary.Clear();
            BasicWorkingTime.Clear();
            //this.Close();
            //EmployeeRegistration emp_registration = new EmployeeRegistration();
            //emp_registration.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string quer = "INSERT INTO Payroll_Employee (Emp_ID, Emp_Name, Emp_address, Emp_Tel, Emp_email, Emp_Blood, Emp_Department, Emp_Start_Date, Emp_Salary, Emp_Basic_Hours)" +
               "VALUES ('" + this.empl_ID.Text + "','" + this.EmployeeName.Text + "','" + this.Address.Text + "','" + this.MobileNo.Text + "','" + this.Email.Text + "','" + this.BloodGroup.Text + "','" + this.Department.Text + "','" + this.DateOfJoining.Text + "','" + this.Salary.Text + "','" + this.BasicWorkingTime.Text + "');";

            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(quer, con);
            SqlDataReader sreader;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                sreader = cmd.ExecuteReader();
                MessageBox.Show("Saved!");
                while (sreader.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //string query = "INSERT INTO Payroll_Employee (Emp_ID, Emp_Name, Emp_address, Emp_Tel, Emp_email, Emp_Blood, Emp_Department, Emp_Start_Date, Emp_Salary, Emp_Basic_Hours)" +
            //   "VALUES (@id,@name, @address, @tel,@email,@blood,@depart,@startDate,@salary,@hours)";

            //SqlConnection con = new SqlConnection(conString);
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Connection = con;
            //cmd.Parameters.AddWithValue("@id", empl_ID.Text);
            //cmd.Parameters.AddWithValue("@name", EmployeeName.Text);
            //cmd.Parameters.AddWithValue("@address", Address.Text);
            //cmd.Parameters.AddWithValue("@tel", MobileNo.Text);
            //cmd.Parameters.AddWithValue("@email", Email.Text);
            //cmd.Parameters.AddWithValue("@blood", BloodGroup.Text);
            //cmd.Parameters.AddWithValue("@depart", Department.Text);
            //cmd.Parameters.AddWithValue("@startDate", DateOfJoining.Text);
            //cmd.Parameters.AddWithValue("@salary", Salary.Text);
            //cmd.Parameters.AddWithValue("@hours", BasicWorkingTime.Text);

            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}

            //cmd.ExecuteNonQuery();
            con.Close();

            //string id = empl_ID.Text;
            //string name = EmployeeName.Text;
            //System.Convert.ToInt32(id);
            //string address = Address.Text;
            //string tel = MobileNo.Text;
            //string email = Email.Text;
            //string blood = BloodGroup.Text;
            //string depart = Department.Text;
            //string startDate = DateOfJoining.Text;
            //string salary = Salary.Text;
            //string hours = BasicWorkingTime.Text;

            //string query = "INSERT INTO Payroll_Employee (Emp_ID, Emp_Name, Emp_address, Emp_Tel, Emp_email, Emp_Blood, Emp_Department, Emp_Start_Date, Emp_Salary, Emp_Basic_Hours)" +
            //    "VALUES (@id,@name, @address, @tel,@email,@blood,@depart,@startDate,@salary,@hours)";
            //SqlCommand cmd = new SqlCommand(query, con);

            //int id = Convert.ToInt32(empl_ID.Text);
            //cmd.Parameters.Add("@id", SqlDbType.Int).Value = Emp_ID;
            //cmd.Parameters.Add("@name", SqlDbType.Text).Value = EmployeeName.Text;
            //cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = Address.Text;
            //cmd.Parameters.Add("@tel", SqlDbType.Int).Value = MobileNo.Text;
            //cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = Email.Text;
            //cmd.Parameters.Add("@blood", SqlDbType.VarChar, 2).Value = BloodGroup.Text;
            //cmd.Parameters.Add("@depart", SqlDbType.VarChar, 50).Value = Department.Text;
            //cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = DateOfJoining.Text;
            //cmd.Parameters.Add("@salary", SqlDbType.Money).Value = Salary.Text;
            //cmd.Parameters.Add("@hours", SqlDbType.Time, 7).Value = BasicWorkingTime.Text;
            //cmd.Connection = con;
            //con.Open();



            //   }
            //   catch (SqlException ex)
            //   {
            //  Console.WriteLine(ex.Message);
            //     }

        }

        private void ViewRecord_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
