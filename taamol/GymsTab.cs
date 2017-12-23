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
    public partial class GymsTab : UserControl
    {
        SqlConnection con;
        
        public GymsTab()
        {
            InitializeComponent();
           
        }
        public void getGyms(int id) {

            con = new SqlConnection("server=.\\PTSSQLSERVER; database = Gyms_Managment; uid = fapzadmin; pwd = 13243546");
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand("exec getGymsOfManager @manager_id", con);
            com.Parameters.Add("@manager_id", SqlDbType.Int, 4).Value = id;
            
            SqlDataAdapter da = new SqlDataAdapter(com);

            con.Open();
            da.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            //ahmad changed some code
            con.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tab1_Load(object sender, EventArgs e)
        {
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
