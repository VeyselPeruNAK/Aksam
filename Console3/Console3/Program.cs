using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            string sayi_str = "";
        giris:
            Console.Write("Bir sayı giriniz:");

            sayi_str = Console.ReadLine();
            //int Result = 0;
            bool i = int.TryParse(sayi_str, out sayi);
            if (!i)
            {
                Console.WriteLine("Geçersiz integer");
                goto giris;
            }

            //sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
                goto giris;

            Console.WriteLine("Sayı=" + sayi.ToString());

            if (sayi < 0)
                Console.WriteLine("Sayı Negatif");
            else
                Console.WriteLine("Sayı Pozitif");
            Console.WriteLine("Program sona erdi. Enter'a basınız.");
            Console.ReadLine();
        }
    }
}
