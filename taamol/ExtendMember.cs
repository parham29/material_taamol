using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taamol
{
    public partial class ExtendMember : Form
    {
        
        int member_id, gym_id;
        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();
        public ExtendMember(int member_id,int gym_id)
        {
            InitializeComponent();
            this.member_id = member_id;
            this.gym_id = gym_id;

        }

        private void ExtendMember_Load(object sender, EventArgs e)
        {
            
            MemberModel m = Managment.getInstance().extendData(member_id,gym_id);
            Lbl_Name_2.Text = m.Name;
            Lbl_Family_2.Text = m.Family;
            Lbl_meliCode_2.Text = m.Melicode;
            Lbl_GymName_2.Text = m.Gym_name;
            comboB_period.SelectedIndex = 0;
        }


        private void img_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExtendMember_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void ExtendMember_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();

        }

        private void ExtendMember_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void Btn_extendMember_Click(object sender, EventArgs e)
        {

          int x = ((comboB_period.SelectedIndex + 1) * 30) ;
            
           Managment.getInstance().extendmember(member_id, gym_id, Convert.ToInt64(txt_price.Text.ToString()), x);
            Managment.getInstance().refreshmembersgrid(gym_id);
        }
    }
}
