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

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }
    }
}
