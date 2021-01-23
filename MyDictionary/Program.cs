using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> exp_1 = new GenericClass<int>();//int-Genericclasa ne türde değişken tanımlarsak onu çalıştırır.
            exp_1.Example1 = 123;
            exp_1.Example2(321);

            GenericClass<string> exp_2 = new GenericClass<string>();//string tanımlama yaptık.
            exp_2.Example1 = "Necati Akdamar";
            exp_2.Example2("Necati Akdamar");

            GenericMethod<int, string> kayitlar = new GenericMethod<int, string>();
            kayitlar.Add(1, "Necati Akdamar");
            kayitlar.Add(2, "Orhan Yalçın");
            kayitlar.Add(3, "Engin Demiroğ");
            kayitlar.Add(4, "Yasin Karayasin");

            Console.WriteLine("\n Oluşturulan kayıt sayısı: "+kayitlar.Count);
            


        }
    }
}
