using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_001_Inheritance
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }







        private void Form2_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {

            Ogrenci o = new Ogrenci();
            o.Alani = Alan.Sayısal;
            Ogrenci o2 = new Ogrenci();
            o2.Alani = Alan.Sözel;

            Kisi myKisi = new Kisi();
            myKisi.Ad = txtAd.Text;
            myKisi.Soyad = txtSoyad.Text;
            myKisi.TcKimlikNo = txtTcNo.Text;
            myKisi.DogumTarihi = dateDogumTarihi.Value;

            MessageBox.Show(myKisi.kisiBilgileri());
        }
    }
}
