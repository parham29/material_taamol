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
    public partial class main : Form
    {
         int id;
        public main(int id)
        {   
            InitializeComponent();
            this.id = id;
        }
        SqlConnection con;
        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();

        private void main_Load(object sender, EventArgs e)
        {
            line.Width = lbltab1.Width;
            line.Left = lbltab1.Left;

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
            if (line.Left != lbltab1.Left)
            {
                line.Width = lbltab1.Width;
                line.Left = lbltab1.Left;
                gyms_tab.Visible = false;
                gyms_tab.BringToFront();
                bunifuTransition1.ShowSync(gyms_tab);
            }
          
            
           
        }

        private void lbltab2_Click(object sender, EventArgs e)
        {   if(line.Left!= lbltab2.Left) {
                line.Width = lbltab2.Width;
                line.Left = lbltab2.Left;
                members_tab.Visible = false;
                members_tab.BringToFront();
                bunifuTransition1.ShowSync(members_tab);
            }
           

        }

        private void lbltab3_Click(object sender, EventArgs e)
        {
            if (line.Left != lbltab3.Left)
            {
                line.Width = lbltab3.Width;
                line.Left = lbltab3.Left;
                financials_tab.Visible = false;
                financials_tab.BringToFront();
                bunifuTransition1.ShowSync(financials_tab);
            }
        }

        private void img_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gyms_tab_Load(object sender, EventArgs e)
        {
           
            gyms_tab.setid(id);
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void financials1_Load(object sender, EventArgs e)
        {

        }
      
       
    }
}
