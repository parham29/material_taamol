using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taamol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("server=.\\PTSSQLSERVER; database = Gyms_Managment; uid = zahra; pwd = zahra5312");
            // SqlCommand com = new SqlCommand("exec addamin", con);
            DataSet ds = new DataSet();
          //  SqlDataAdapter da = new SqlDataAdapter(com);

            con.Open();
            //da.Fill(ds);
            
            con.Close();


            //SqlCommand com = new SqlCommand("getinfo", con);

            // TODO: This line of code loads data into the 'gyms_ManagmentDataSet2.addadmin' table. You can move, or remove it, as needed.
            // this.addadminTableAdapter.Fill(this.gyms_ManagmentDataSet2.addadmin);

        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void lbltab1_Click(object sender, EventArgs e)
        {
            line.Width = lbltab1.Width;
            line.Left = lbltab1.Left;
            tab11.Visible = false;
            tab11.BringToFront();
            bunifuTransition1.ShowSync(tab11);
           
        }

        private void lbltab2_Click(object sender, EventArgs e)
        {
            line.Width = lbltab2.Width;
            line.Left = lbltab2.Left;
            financials1.Visible = false;
            financials1.BringToFront();
            bunifuTransition1.ShowSync(financials1);

        }

        private void lbltab3_Click(object sender, EventArgs e)
        {
            line.Width = lbltab3.Width;
            line.Left = lbltab3.Left;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tab11_Load(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void financials1_Load(object sender, EventArgs e)
        {

        }
    }
}
