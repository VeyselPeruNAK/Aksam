using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders27_PassForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form Form2 = new Form2(textBox1.Text);
            //Form2.ShowDialog();
            Form Form3 = new Form3(textBox1.Text, Convert.ToInt32(textBox2.Text));
            Form3.ShowDialog();
        }
    }
}
