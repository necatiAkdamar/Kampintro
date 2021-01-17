using System;

namespace DortIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dortislem dortislem = new Dortislem();
            Console.WriteLine("Birinci sayıyı giriniz:");
            int sayi1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int a = dortislem.Carp(sayi1, sayi2);
            Console.WriteLine("Çarpma Sonucu : " + a);

            int b = dortislem.Topla(sayi1, sayi2);
            Console.WriteLine("Toplama Sonucu : " + b);

            int c = dortislem.Bol(sayi1, sayi2);
            Console.WriteLine("Bölme Sonucu : " + c);

            int d = dortislem.Cikar(sayi1, sayi2);
            Console.WriteLine("Cikarma Sonucu : " + d);

           
        }
    }
}
