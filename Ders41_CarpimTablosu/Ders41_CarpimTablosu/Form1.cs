using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders41_CarpimTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            int sayi = Convert.ToInt32(comboBox1.Text);
            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add(sayi + "x" + i + "=" + sayi * i);
            }
            listBox1.Items.Add("---------------------------------");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
                comboBox1.Items.Add(i);
            comboBox1.SelectedIndex = 0;
        }
    }
}
