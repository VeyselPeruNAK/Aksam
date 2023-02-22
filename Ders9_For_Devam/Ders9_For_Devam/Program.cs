using System;
using System.Collections.Generic;

namespace Ders9_For_Devam
{
    class Program
    {

        static List<string> kitaplar = new List<string>();
        static void Main(string[] args)
        {
            ////Çarpım Tablosu, Yanyana             
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j + "x" + i + "=" + (i * j) + "\t");
                }
                Console.WriteLine();
            }

            //Console.ReadLine();

            /* Aşağıdaki üçgeni ekrana çiziniz.


             *
             **
             ***
             ****
             *****
             ******
             *..20'ye kadar
                               *
                              ** 
                             ***  
             
             */

            //for (int i = 1; i <= 20; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i < 10 ? i + ") " : i + ")");
                //Console.Write(i);
                for (int j = 1; j <= 20 - i; j++)
                {

                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();


            // Menu
            // 1) Görüntüle
            // 2) Ekle
            // 3) Sil
            // 4) Çıkış
            // Seçenek: ?
            //kitaplar adlı list içinde işlem yapılacak. 
            //while(true)
            //{
            //    Console.WriteLine("    Menu");
            //    Console.WriteLine(" 1) Görüntüle");
            //    Console.WriteLine(" 2) Ekle     ");
            //    Console.WriteLine(" 3) Sil      ");
            //    Console.WriteLine(" 4) Çıkış    ");
            //    Console.WriteLine();
            //    Console.Write("Seçiminiz:" );
            //    string secim = Console.ReadLine();
            //    switch (secim)
            //    {
            //        case "4": break;
            //        case "1":
            //            foreach (var item in kitaplar)
            //            {
            //                Console.WriteLine(item);
            //            };break;
            //        case "2": 
            //            Console.Write("Eklenecek Kitap adı:");
            //            kitaplar.Add(Console.ReadLine());
            //            break;
            //        case "3":
            //            Console.WriteLine("Silinecek kitap adı:");
            //            kitaplar.Remove(Console.ReadLine());
            //            break;
            //    }
            //    if (secim == "4")
            //        break;

            //}
            //Console.WriteLine("Program bitti.");
            //Console.ReadLine();

            //0-1000 arasında bir sayı üretin.
            //Kullanıcıdan 15 tahmin alın.
            //Tahmin rastgele sayıdan büyükse "tahmin büyüktür."
            //küçükse "tahmin küçüktür." yazsın. 
            //Sayıyı bulursa tebrik etsin.
            //Program sonunda tüm tahminleri yazsın. 
            Random rnd = new Random();
            int rastgele = rnd.Next(0, 1000);
            Console.WriteLine("Sayı=" + rastgele);
            List<int> tahminler = new List<int>();
            int i;
            for (i = 0; i < 15; i++)
            {
                Console.Write("Tahmin:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                tahminler.Add(tahmin);
                if (tahmin < rastgele)
                    Console.WriteLine("Küçük oldu.");
                else if (tahmin > rastgele)
                    Console.WriteLine("Büyük oldu.");
                else
                {
                    Console.WriteLine("Tebrikler bildiniz." + rastgele);
                    break;
                }

            }

            if (i == 15)
            {
                Console.WriteLine("Bilemediniz. Sayı=" + rastgele + " idi.");
            }
            Console.Write("Tahminler:");
            foreach (var item in tahminler)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Program sona erdi.");
            Console.ReadLine();

            // Bir 15'lik double array'i SqrtBul adlı metoda göndersin. 
            // Metot, Karekökleri içeren double array'i dönsün.
            double[] d1 = { 8.5D, 6.7D, 9.0D };
            double[] d2 = SqrtBul(d1);
            foreach (double item in d2)
            {
                Console.WriteLine(Math.Round(item, 2));
            }
        }

        private static double[] SqrtBul(double[] d1)
        {
            double[] d3 = new double[d1.Length];
            for (int i = 0; i < d1.Length; i++)
            {
                d3[i] = Math.Sqrt(d1[i]);
            }
            return d3;
        }
    }
}
