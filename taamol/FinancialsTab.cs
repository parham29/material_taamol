using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taamol
{
    public partial class FinancialsTab : UserControl
    {
        public FinancialsTab()
        {
            InitializeComponent();
        }

        public void getfinancials(int manager_id) {

            Managment.getInstance().getFinancials(manager_id, 1, Dgv_register_income); 
            Managment.getInstance().getFinancials(manager_id, 2, Dgv_extend_income);
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
