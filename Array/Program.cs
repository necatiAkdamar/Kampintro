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
                Console.WriteLine("Loto Sayı "+i+"= "+ say);
            }
            Console.WriteLine(new string('-', 30)+"Çok Boyutlu Diziler\n");
            string[,] bolgeler = new string[5, 3]//Çok boyutlu dizi tanımlama. Bölgeler ve şehirleri gibi. 5 satır 3 sütundan oluşuyor.
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" },
            };

            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)//getupperbound=0ıncı parametrenin en üst değeri[5,3] dizisinde 5 in olduğu parametre
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)//getupperbound=1inci parametrenin en üst değeri [5,3] dizisinde 3 ün olduğu parametre
                {
                    Console.WriteLine(bolgeler[i, j]);
                }
                Console.WriteLine("-------bolgebitti-----");
            }



        }

    }
}
