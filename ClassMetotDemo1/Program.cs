using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)

        {
            musterimanager insertmusteri = new musterimanager();
            insertmusteri.Ekle(1, "necati", "akdamar");
            musterimanager insertmusteri1 = new musterimanager();
            insertmusteri1.Ekle(2, "Müge", "akdamar");
            musterimanager insertmusteri2 = new musterimanager();
            insertmusteri2.Ekle(3, "İclal", "akdamar");
            musterimanager insertmusteri3 = new musterimanager();
            insertmusteri3.Ekle(4, "Feryal", "akdamar");
            musterimanager insertmusteri4 = new musterimanager();
            insertmusteri4.Ekle(5, "Demir", "akdamar");

            

            Console.WriteLine(new string('-',30));

            musterimanager deletemusteri = new musterimanager();
            deletemusteri.sil(3, "İclal", "akdamar");
           
        }
    }
}
