using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders21_Toplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                int i, j;
                i = Convert.ToInt32(txtSayi1.Text);
                j = Convert.ToInt32(txtSayi2.Text);
                label3.Text = (i + j).ToString();
                label4.Text = "Toplam:";
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata: " + x.Message);
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                int i, j;
                i = Convert.ToInt32(txtSayi1.Text);
                j = Convert.ToInt32(txtSayi2.Text);
                label3.Text = (i - j).ToString();
                label4.Text = "Fark:";
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata: " + x.Message);
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                double i, j;
                i = Convert.ToDouble(txtSayi1.Text);
                j = Convert.ToDouble(txtSayi2.Text);
                label3.Text = (i * j).ToString("###,###.##");
                label4.Text = "Çarpım:";
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata: " + x.Message);
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                int i, j;
                i = Convert.ToInt32(txtSayi1.Text);
                j = Convert.ToInt32(txtSayi2.Text);
                label3.Text = (i / j).ToString();
                label4.Text = "Bölüm:";
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata: " + x.Message);
            }
        }
    }
}
