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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            Memur m = new Memur();
            m.IseGirisTarihi = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Adi = textBox1.Text;
            p.Soyadi = textBox2.Text;
            p.DogumTarihi = dateTimePicker1.Value;
            p.TCKN = textBox3.Text;

            Ogrenci o = new Ogrenci();
            InsanEkle(o);
            Ogretmen ogr = new Ogretmen();
            InsanEkle(ogr);
            ogr.Adi = "Veysel";
            ogr.Soyadi = "Perü";
            ogr.DogumTarihi = Convert.ToDateTime("1969-02-13");
            ogr.TCKN = "67309105720";
            ogr.Bransi = "Bilişim";
            ogr.Sinifi = "303";

            MessageBox.Show(ogr.ToString());



        }

        void InsanEkle(Insan ins)
        {


        }


    }
}
