using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Carpim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(comboBox1.Text);
            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add(sayi + "x" + i + "=" + sayi * i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> sayilar = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                sayilar.Add(i.ToString());
            }

            this.comboBox1.DataSource = sayilar;
        }
    }
}
