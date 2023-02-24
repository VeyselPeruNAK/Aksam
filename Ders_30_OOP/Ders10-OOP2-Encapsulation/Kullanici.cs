using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation

{
    class Kullanici
    {
        private int ID { get; set; }
        private string _AdSoyad;
        public string AdSoyad
        {
            get { return this._AdSoyad; }
            set { this._AdSoyad = value; }
        }

        private string _Telefon;
        public string Telefon
        {
            get { return this._Telefon; }
            set { this._Telefon = value; }
        }

        public Kuafor kuafor;

        public Kullanici()
        {
            this.kuafor = new Kuafor();
        }

    }
}
