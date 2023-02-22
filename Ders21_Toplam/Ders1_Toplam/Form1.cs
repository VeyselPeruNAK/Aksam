using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1_Toplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            i = Convert.ToInt32(textBox1.Text);
            j = Convert.ToInt32(textBox2.Text);
            label1.Text = (i + j).ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
