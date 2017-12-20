using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace taamol
{
    public partial class tab1 : UserControl
    {
        SqlConnection con;
        public tab1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tab1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("server=.\\PTSSQLSERVER; database = Gyms_Managment; uid = zahra; pwd = zahra5312");
            // SqlCommand com = new SqlCommand("exec addamin", con);
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand("exec getGymsOfManager @manager_id", con);
            com.Parameters.Add("@manager_id", SqlDbType.Int, 4).Value = 1;
            SqlDataAdapter da = new SqlDataAdapter(com);

            con.Open();
            da.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            bunifuCustomDataGrid1.Columns[0].HeaderText = "Last Name";
            con.Close();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
