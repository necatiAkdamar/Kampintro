using System;

using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" }; //isimler dizisi oluşturduk. Elemanlarını tanımladık


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };//liste şeklinde dizi koleksiyonu oluşturabiliyoruz.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");//koleksiyona 5.bir eleman ekleyebiliyoruz.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

             


        }
    }
}
