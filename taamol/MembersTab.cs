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
using System.Collections;
using System.Collections.Specialized;

namespace taamol
{
    public partial class MembersTab : UserControl
    {
        
        
        int index;
        int member_id;




        public MembersTab()
        {
            InitializeComponent();
        }

        private void MembersTab_Load(object sender, EventArgs e)
        {
            


        }
        public void getMembers(int id)
        {

            this.member_id = id;
            OrderedDictionary dic = Managment.getInstance().getgymsnamesAndid(id, panel1,line_member,Txt_search);
            Managment.getInstance().readAllmembers((int)dic[0], Dgv_allmembers);
        }

        

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {




        }



        private void Img_addmember_Click(object sender, EventArgs e)
        {
            addmember addmember = new addmember(member_id);


            addmember.ShowDialog();
            
        }

        private void Dgv_allmembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


            Managment.getInstance().DView.RowFilter = "member_meli_code like '" + Txt_search.text.ToString() + "%'";
        }

        private void Img_editmember_Click(object sender, EventArgs e)
        {
            try
            {   
                DataGridViewRow selectedRow = Dgv_allmembers.Rows[index];
                MessageBox.Show((int)selectedRow.Cells[10].Value+"");
                EditMember edit = new EditMember((int)selectedRow.Cells[10].Value, (int)selectedRow.Cells[11].Value);
                edit.ShowDialog();
                //managment.deletMember((int)selectedRow.Cells[10].Value);
            }
            catch (Exception s)
            {


            }


        }

        private void Img_deletemember_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = Dgv_allmembers.Rows[index];
                Managment.getInstance().deletMember((int)selectedRow.Cells[10].Value, (int)selectedRow.Cells[11].Value);
                Managment.getInstance().refreshmembersgrid((int)selectedRow.Cells[11].Value);
                //   ExtendMember extendMember = new ExtendMember((int)selectedRow.Cells[10].Value, (int)selectedRow.Cells[11].Value);


                // extendMember.ShowDialog();
            }
            catch (Exception s)
            {


            }
        }

        private void Img_extendmember_Click(object sender, EventArgs e)

        {

            try { DataGridViewRow selectedRow = Dgv_allmembers.Rows[index];
                if (selectedRow.Cells[12].Value.ToString() == "invalid")
                {
                    ExtendMember extendMember = new ExtendMember((int)selectedRow.Cells[10].Value, (int)selectedRow.Cells[11].Value);
                    extendMember.ShowDialog();
                }
                else {

                    MessageBox.Show("user is " + selectedRow.Cells[12].Value);
                }
           
            }
            catch (Exception s) {


            }

          

          
        }

       
    }
}
