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
        Managment managment;
        public ExtendMember()
        {
            InitializeComponent();
        }

        private void ExtendMember_Load(object sender, EventArgs e)
        {
            managment = new Managment();
            MemberModel m = managment.extendData(6,2);
            Lbl_Name_2.Text = m.Name;
            Lbl_Family_2.Text = m.Family;
            Lbl_meliCode_2.Text = m.Melicode;
            Lbl_GymName_2.Text = m.Gym_name;
        }


        private void img_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_extendMember_Click(object sender, EventArgs e)
        {

        }
    }
}
