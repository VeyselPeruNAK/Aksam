using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders29_Netler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, turkceYanlis, turkceNet;
            double matDogru, matYanlis, matNet;
            double fizDogru, fizYanlis, fizNet;

            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);

            matDogru = Convert.ToDouble(txtMatDogru.Text);
            matYanlis = Convert.ToDouble(txtMatYanlis.Text);

            fizDogru = Convert.ToDouble(txtFizikDogru.Text);
            fizYanlis = Convert.ToDouble(txtFizikYanlis.Text);

            turkceNet = turkceDogru - (turkceYanlis / 4);
            matNet = matDogru - (matYanlis / 4);
            fizNet = fizDogru - (fizYanlis / 4);

            txtTurkceNet.Text = turkceNet.ToString();
            txtMatNet.Text = matNet.ToString();
            txtFizikNet.Text = fizNet.ToString();

            /*
textBox1 >>> txtTurkceDogru
textBox2 >>> txtTurkceYanlis
textBox3 >>> txtTurkceNet
textBox4 >>> txtMatDogru
textBox5 >>> txtMatYanlis
textBox6 >>> txtMatNet
textBox7 >>> txtFizDogru
textBox8 >>> txtFizYanlis
textBox9 >>> txtFizNet

            button1 >>> btnHesapla
             */
        }
    }
}
