using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
        giris:
            Console.Write("Bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
                goto giris;

            if (sayi < 0)
                Console.WriteLine("Sayı Negatif");
            else
                Console.WriteLine("Sayı Pozitif");
            //Console.WriteLine("Program sona erdi.");
            //Console.ReadLine();
        }
    }
}
