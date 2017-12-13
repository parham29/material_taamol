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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();

        private void Form1_Load(object sender, EventArgs e)
        {
           
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
        }

        private void lbltab2_Click(object sender, EventArgs e)
        {
            line.Width = lbltab2.Width;
            line.Left = lbltab2.Left;
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
    }
}
