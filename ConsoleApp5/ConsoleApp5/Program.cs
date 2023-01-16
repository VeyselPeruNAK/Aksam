using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {

                Topla(1, 2);//C# aşırı yüklenmiş metotları seçerken önceliği normal metotlara verir.
                Console.ReadLine();
            }
        }
        static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Ben normal metodum.");
        }

        static void Topla(params int[] gelenSayilar)
        {
            Console.WriteLine("Ben params kullanılmış metodum.");
        }


    }
}