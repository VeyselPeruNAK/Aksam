using System;

namespace Ders4_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while döngüsünde döngü bloğu koşula bakılmaksızın 1 deffa çalışır. sonraki çalışmalar için koşul kontrol edilir.

            /*
            do
            {
                // koşula bağlu blok.
            } while (true);
            */
            // ÖRN: klavyeden alınan sayıları toplayıp ekrana...
            // 0 yazınca çıkış yapılacak.

            int toplam = 0;
            int s;
            do
            {
                Console.Write("Sayı : ");
                s = Convert.ToInt32(Console.ReadLine());
                toplam += s;

            } while (s != 0);  // s 0 olmadığı sürece döngü çalışsın.
            Console.WriteLine($"toplam = {toplam}");
            Console.ReadLine();
            // SORU: Kullanıcıdan eposta ve parola bilisi alıp kontrol edecek pr. yaz.
            // eposta = smart@pro.net parola = SP123
            // bilgiler doğru değilse tekrar istesin.
            //string eposta = "smart@pro.net";
            //string parola = "nA123";
            //string ep, pa;
            //do
            //{
            //    Console.Write("E-Posta Giriniz: ");
            //    ep = Console.ReadLine();
            //    Console.Write("Parola Giriniz: ");
            //    pa = Console.ReadLine();

            //} while (ep != eposta ||  pa != parola);
            //Console.WriteLine("Başarılı giriş!");



        }
    }
}
