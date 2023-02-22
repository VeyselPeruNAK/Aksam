using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders22_Dikdortgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int genislik = Convert.ToInt32(txtGenislik.Text);
            int uzunluk = Convert.ToInt32(txtUzunluk.Text);
            int alan = genislik * uzunluk;
            int cevre = (genislik + uzunluk) * 2;
            lblCevre.Text = "Çevre : " + cevre;
            lblAlan.Text = "Alan : " + alan;
        }
    }
}
