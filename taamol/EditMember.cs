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
    public partial class EditMember : Form
    {
        int member_id;
        int gym_id;
        public EditMember(int member_id, int gym_id)
        {   
            InitializeComponent();
            this.member_id = member_id;
            this.gym_id = gym_id;
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            MemberModel member = Managment.getInstance().geteditData(member_id);
            Txt_name.Text = member.Name;
            Txt_family.Text = member.Family;
            Txt_mobile.Text = member.Mobile;
            Txt_telephone.Text = member.Phone;
            if(member.Gender==1)
            {
                OSSwitch_Gender.Value = true;

            }
            else
            {
                OSSwitch_Gender.Value = false;

            }
            Txt_Address.Text = member.Address;
            Label_melicode.Text = member.Melicode;
            
        }

        

        private void Btn_editmember_Click(object sender, EventArgs e)
        {
            if (Txt_name.Text.Length < 2)
            {
                MessageBox.Show("Name must be at least 3 charachters");
            }
            else if (Txt_family.Text.Length < 3)
            {
                MessageBox.Show("Family must be at least 3 charachters");

            }
           

            else if (Txt_Address.Text.Length < 10)
            {

                MessageBox.Show("Address must be at least 10 charachters");
            }
            else if (Txt_telephone.Text.Length > 11 || Txt_telephone.Text.Length < 7)
            {

                MessageBox.Show("telephone must be between 7 and 11 charachters");
            }

            else if (Txt_mobile.Text.Length != 11)
            {

                MessageBox.Show("mobile must be 11 charachters");
            }
            else
            {
                MemberModel model = new MemberModel();
                DateTime now = DateTime.Now;

                model.Name = Txt_name.Text.ToString();
                model.Family = Txt_family.Text.ToString();
                model.Gender = OSSwitch_Gender.Value ? 1 : 0;
                model.Address = Txt_Address.Text.ToString();
                model.Phone = Txt_telephone.Text.ToString();
                model.Registration_date = now;
                model.Mobile = Txt_mobile.Text.ToString();
                Managment.getInstance().EditMember(member_id, Txt_name.Text.ToString(), Txt_family.Text.ToString(), OSSwitch_Gender.Value ? 1 : 0, Txt_Address.Text.ToString(), Txt_telephone.Text.ToString(), Txt_mobile.Text.ToString());
          

               
                MessageBox.Show("successfully eddited");
                Managment.getInstance().refreshmembersgrid(gym_id);
                Close();
                //Managment.getInstance().refreshmembersgrid(Convert.ToInt32(Cmb_gyms.SelectedValue));



            }
        }



        public void checkLenght(Bunifu.Framework.UI.BunifuMetroTextbox txt, int maxlenght)
        {

            if (txt.Text.Length >= maxlenght)
            {

                txt.Enabled = false;
                txt.Enabled = true;

            }
        }

        

        private void Txt_telephone_OnValueChanged(object sender, EventArgs e)
        {
            checkLenght(Txt_telephone, 11);
        }

        private void Txt_mobile_OnValueChanged(object sender, EventArgs e)
        {
            checkLenght(Txt_mobile, 11);
        }

        private void Txt_telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
             && !char.IsDigit(e.KeyChar)
             )
            {
                e.Handled = true;
                MessageBox.Show("telephone must be numeric");
            }
        }

        private void Txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                 && !char.IsDigit(e.KeyChar)
                 )
            {
                e.Handled = true;
                MessageBox.Show("mobile must be numeric");
            }

        }

        private void img_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
