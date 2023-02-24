using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation
{
    class User
    {
        private int _ID;
        private string AdSoyad; // AÇIK YÖNTEM İLE KAPSULLEME YAPTIK.
        private string _Adres;  // KISA YÖNTEM İLE KAPSULLEME YAPTIK.
        public string Adres {
            get { return this._Adres; }
            set 
            { 
                if(!(String.IsNullOrEmpty(value)) && !(String.IsNullOrWhiteSpace(value)))
                    this._Adres = value;
                else
                {
                    Console.WriteLine("Boşluklardan oluşan veya tamamen boş değer atayamazsınız.!!!");
                }
            }
        }
        private string _Telefon;
        
        /// Telefon özelliği sadece _Telefon özelliğine erişim için kullanılır. Arada köprüdür.
        public string Telefon
        {
            get { return this._Telefon; }
            set 
            {   // Telefon formatına uygun mu kontrolü yapılabilir.
                this._Telefon = value; 
            }
        }



        // ERİŞİM BELİRTEÇLERİ //
        // public: her yerden ulaşılabilir.
        // private: sadece sınıf içerisinden erişilebilir.
        // protected: sınıf içerisinden ve kalıtım yolu ile miras alan alt sınıflardan erişilebilir.
        // 
        public void setAdSoyad(string adsoyad)
        {
            if (!(String.IsNullOrEmpty(adsoyad)) && !(String.IsNullOrWhiteSpace(adsoyad)))
            {
                this.AdSoyad = adsoyad;
            }
            else
            {
                Console.WriteLine("Boşluklardan oluşan veya tamamen boş değer atayamazsınız.!!!");
            }
        }
   
        public string getAdSoyad()
        {
            return this.AdSoyad;
        }
    }
 }