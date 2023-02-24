using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_40_OOP1
{
    internal class Araba
    {
        //Sınıfın özellikleri: property, field
        public int ID;
        public string Marka;
        public string Model;

        public Araba()
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
        }
        public Araba(int id, string marka, string model)
        {
            Console.WriteLine("3 propertyli constructor çalıştı.");
            this.ID = id;
            Marka = marka;
            Model = model;
        }

        public void BilgiYaz()
        {
            Console.WriteLine("-----Araba Bilgileri ------");
            Console.WriteLine("Marka:" + Marka);
            Console.WriteLine("Model:" + Model);
        }
    }
}
