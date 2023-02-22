using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders26_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            txt1.Text = "Color red";
        }

        private void txt1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Aqua;
            txt1.Text = "Color aqua";
        }

        private void txt1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt1.Text = "Double klik";
        }

        private void txt1_MouseClick(object sender, MouseEventArgs e)
        {
            txt1.Text = "Mouse Click";
        }
    }
}
