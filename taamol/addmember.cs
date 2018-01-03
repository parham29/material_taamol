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
    public partial class addmember : Form
    {
        int manager_id;
        public addmember(int manager_id)
        {
            InitializeComponent();
            this.manager_id = manager_id;
        }
       
        






        private void Btn_addmember_Click(object sender, EventArgs e)
        {
            if (Txt_name.Text.Length < 2)
            {
                MessageBox.Show("Name must be at least 3 charachters");
            }
            else if (Txt_family.Text.Length < 3)
            {
                MessageBox.Show("Family must be at least 3 charachters");

            }
            else if (txt_mellicode.Text.Length < 10 || txt_mellicode.Text.Length >10)
            {

                MessageBox.Show("melicode must be 10 charachters");
            }

            else if (Txt_Address.Text.Length < 10)
            {

                MessageBox.Show("Address must be at least 10 charachters");
            }
            else if (Txt_telephone.Text.Length > 11 || Txt_telephone.Text.Length <7)
            {

                MessageBox.Show("telephone must be between 7 and 11 charachters");
            }

            else if (Txt_mobile.Text.Length !=11)
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
                model.DOB = Datepicker_DOB.Value;
                model.Melicode = txt_mellicode.Text.ToString();
                model.Address = Txt_Address.Text.ToString();
                model.Phone = Txt_telephone.Text.ToString();
                model.Registration_date = now;
                model.Mobile = Txt_mobile.Text.ToString();
                model.Expire_date = DateTime.Now.AddDays(((Cmb_period.SelectedIndex + 1) * 30));
                model.Gymid = Convert.ToInt32(Cmb_gyms.SelectedValue);
                // Txt_price.Text;

                Managment.getInstance().addmember(model,Convert.ToInt64(Txt_price.Text.ToString()));
                MessageBox.Show("successfully added");
                Managment.getInstance().refreshmembersgrid(Convert.ToInt32(Cmb_gyms.SelectedValue));
                Close();


            }

            }

            private void addmember_Load(object sender, EventArgs e)
        {
            
            
            Managment.getInstance().getgymsnames(Cmb_gyms, manager_id);
            Cmb_period.SelectedIndex = 0;


        }

        private void img_exit_Click(object sender, EventArgs e)
        {
            Close();
          
        }

       

        private void txt_mellicode_OnValueChanged(object sender, EventArgs e)
        {
            checkLenght(txt_mellicode, 10);


        }

        private void Txt_telephone_OnValueChanged(object sender, EventArgs e)
        {
            checkLenght(Txt_telephone,11);
          
        }


        private void Txt_mobile_OnValueChanged(object sender, EventArgs e)
        {
            checkLenght(Txt_mobile, 11);
        }


        private void txt_mellicode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                )
            {

                

                e.Handled = true;
                MessageBox.Show("meli code must be numeric");
            }


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
        private void Txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
              && !char.IsDigit(e.KeyChar)
              )
            {
                e.Handled = true;
                MessageBox.Show("price must be numeric");
            }
        }
        public void checkLenght(Bunifu.Framework.UI.BunifuMetroTextbox txt,int maxlenght) {

            if (txt.Text.Length >= maxlenght)
            {

                txt.Enabled = false;
                txt.Enabled = true;

            }
        }

        
    }
   
}
