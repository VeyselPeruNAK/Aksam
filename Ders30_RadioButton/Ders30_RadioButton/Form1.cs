using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders30_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbKirmizi.Checked == true)
            {
                MessageBox.Show("Kırmızı seçildi.");
            }
            else if (rbMavi.Checked == true)
            {
                MessageBox.Show("Mavi seçildi.");
            }
            else if (rbTuruncu.Checked == true)
            {
                MessageBox.Show("Turuncu seçildi");
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbKirmizi.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else if (rbMavi.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else if (rbTuruncu.Checked == true)
            {
                this.BackColor = Color.Orange;
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (rbKirmizi.Checked == true)
            {
                MessageBox.Show("Kırmızı seçildi.");
            }
            else if (rbMavi.Checked == true)
            {
                MessageBox.Show("Mavi seçildi.");
            }
            else if (rbTuruncu.Checked == true)
            {
                MessageBox.Show("Turuncu seçildi");
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }
        }
    }
}
