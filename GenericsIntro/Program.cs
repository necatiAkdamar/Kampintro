using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //MyList isimler = new MyList(); //kendi koleksiyonumuzu yazıyoruz.
            MyList<string> isimler = new MyList<string>();
            isimler.Add = "Engin";

            Console.WriteLine("Hello World!");
        }
    }
}
