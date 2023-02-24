using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım
{
    class AnaClass
    {
        protected string Test;
        private int _ID;
        public int ID
        {
            get { return this._ID; }
            //set { 
            //    if (value<= int.MaxValue && value>=int.MinValue)
            //        this._ID = value; 
            //}
        }
        private DateTime _KayitTarihi;
        public DateTime KayitTarihi
        {
            get { return this._KayitTarihi; }
            set { this._KayitTarihi = value; }
        }

        //public void KayitTarihiYaz()
        //{
        //    Console.WriteLine($"İlan ID: " + this.ID + "\nİlan Tarihi: " + this.KayitTarihi);
        //}

        public void BilgiYaz()
        {
            Console.WriteLine($"ID: {this.ID}");
            Console.WriteLine($"Kayit Tarihi: {this.KayitTarihi}");
        }

        public AnaClass()
        {
            this.Test = "TESTTTTT";
        }
        public AnaClass(int id, DateTime kayitTarihi)
        {
            this._ID = id;
            this._KayitTarihi = kayitTarihi;
            this.Test = "TESTTTTT";
        }
        private DateTime _IlanTarihi;
        public DateTime IlanTarihi
        {
            get { return this._IlanTarihi; }
            set { this._IlanTarihi = value; }
        }

        public void IlanTarihiYaz()
        {
            Console.WriteLine("_IlanTarihi=" + _IlanTarihi);
        }
    }
}
