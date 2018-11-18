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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        string conString = "Data Source=DESKTOP-43RRQ63\\SQLEXPRESS;Initial Catalog=sd2;Integrated Security=True";
        private void Search_butt_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbl_user where user_id = '" + Convert.ToInt32(id_box.Text) + "' ";
            //string sql = "select * from tbl_user where user_id = @id or fname = @name ";
            //sqlcommand. com = new sqlcommand
            SqlConnection connection = new SqlConnection(conString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            SqlCommand com = new SqlCommand(sql, connection);
            com.Parameters.Clear();
            //  com.Parameters.AddWithValue("@id", id);
            //  com.Parameters.AddWithValue("@name", id);

            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tbl_user");
            connection.Close();
            dataGridView.DataSource = ds;
            dataGridView.DataMember = "tbl_user";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sql = "Delete  tbl_user where user_id = '" + Convert.ToInt32(id_box.Text) + "' ";
            //SqlConnection connection = new SqlConnection(conString);
            //connection.Open();
            //SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            //SqlCommand com = new SqlCommand(sql, connection);
            //dataadapter.DeleteCommand = new SqlCommand(sql, connection);
            //dataadapter.DeleteCommand.ExecuteNonQuery();

            
            //com.Dispose();
            //connection.Close();
            //id_box.Clear();
            MessageBox.Show("Record has been deleted!");
        }

        private void exit_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
