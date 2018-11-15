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
    public partial class SearchEmp : Form
    {
        public SearchEmp()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-QLP0JCN;Initial Catalog=sd2;Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_butt_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from tbl_user where user_id like '" + id_box.Text +"' or fname like '"+ id_box.Text+"%'";
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
            dataadapter.Fill(ds,"tbl_user");
            connection.Close();
            dataview.DataSource = ds;
            dataview.DataMember = "tbl_user";
        }
       

        private void exit_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
