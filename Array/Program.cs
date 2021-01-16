using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 5, 8, -78, 45, 0, 30, -28, 80, -100, 101 };

            int T = 0;
            foreach (var x in dizi)
            {
                T += x;
            }
            Console.WriteLine("Örn.1 Dizi Toplamı : " + T);
            Console.WriteLine(new string('-', 30));

            
            int sayi = dizi.Length-1;
            for (int i = sayi; i >= 0; --i)
            {
                Console.WriteLine("Örn.2 Dizinin Tersten Yazılışı : "+ dizi[i]);
            }
            Console.WriteLine(new string('-', 30));

            foreach (var x in dizi)
            {
                if (x%2==0){Console.WriteLine("Örn.3 Cift Sayılar: " + x);}
                else{continue;}
            }
            Console.WriteLine(new string('-', 30));

            Random rastgele = new Random();
            for (int i = 1; i < 7; i++)
            {
                int say = rastgele.Next(1,49);
                Console.WriteLine("Sayı "+i+"= "+ say);
            }




        }

    }
}
