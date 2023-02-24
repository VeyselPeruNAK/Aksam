using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation
{
    enum Hizmetler
    {
        Saç_Traşı,
        Sakal_Traşı,
        Saç_Yıkama,
        Cilt_Bakımı
    }
    class Kuafor
    {
        // enum: Hizmetler: Saç Traşı,Sakal Traşı, Saç Yıkama, Cilt Bakımı
        // Saç Tıraşı: 20, Sakal Traşı: 15, Saç Yıkama: 10, Cilt Bakımı=30
        // ID,Ad,sacTırasiUcreti,sakalTrasiUcreti,SacYikamaUcreti,CiltBakimiUcreti
        // ToplamTutar.

        // Metotlar: SacTrasiYap(),SakalTrasiYap(),SacYika(),CiltBakimiYap()
        // BilgiYaz().
        int ID;
        string Ad;

        //byte _vergiMiktarı;
        //public byte vergiMiktarı
        //{
        //    get { return this._vergiMiktarı; }
        //    set
        //    {
        //        try
        //        {
        //            this._vergiMiktarı = value;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Hatalı değer geldi !!!");
        //        }
        //    }
        //}

        private float _SacYikamaUcreti;
        public float SacYikamaUcreti
        {
            get { return this._SacYikamaUcreti; }
            set
            {
                this._SacYikamaUcreti = value;
            }
        }

        private float _sakalTrasiUcreti;
        public float sakalTrasiUcreti
        {
            get { return this._sakalTrasiUcreti; }
            set
            {
                this._sakalTrasiUcreti = value;
            }
        }

        private float _ciltBakimiUcreti;
        public float ciltBakimiUcreti
        {
            get { return this._ciltBakimiUcreti; }
            set
            {
                this._ciltBakimiUcreti = value;
            }
        }


        private float _sacTirasiUcreti;
        public float sacTirasiUcreti
        {
            get { return this._sacTirasiUcreti; }
            set
            {
                this._sacTirasiUcreti = value;
            }
        }
        private float toplamUcret;

        private List<Hizmetler> alinanHizmetler = new List<Hizmetler>();

        public Kuafor()
        {
            this.toplamUcret = 0;
            this.sacTirasiUcreti = 20.0f;
            this.ciltBakimiUcreti = 30.0f;
            this.sakalTrasiUcreti = 15.0f;
            this.SacYikamaUcreti = 10.0f;
        }


        public void SacTrasiYap()
        {
            this.alinanHizmetler.Add(Hizmetler.Saç_Traşı);
            this.toplamUcret += this.sacTirasiUcreti;
        }

        public void SacYika()
        {
            this.alinanHizmetler.Add(Hizmetler.Saç_Yıkama);
            this.toplamUcret += this.SacYikamaUcreti;
        }

        public void SakalTrasiYap()
        {
            this.alinanHizmetler.Add(Hizmetler.Sakal_Traşı);
            this.toplamUcret += this.sakalTrasiUcreti;
        }

        public void CiltBakimiYap()
        {
            this.alinanHizmetler.Add(Hizmetler.Cilt_Bakımı);
            this.toplamUcret += this.ciltBakimiUcreti;
        }

        public void BilgiYaz()
        {
            Console.WriteLine("Aşağıdaki hizmetleri aldınız:");
            foreach (var item in this.alinanHizmetler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Toplam tutar : {this.toplamUcret}");
        }
    }
}
