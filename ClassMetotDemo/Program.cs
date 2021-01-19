using System;

namespace ClassMetotDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.tc = "12773575000";
            musteri1.adi = "necati";
            musteri1.soyadi = "akdamar";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.tc = "12773575000";
            musteri2.adi = "müge";
            musteri2.soyadi = "akdamar";

            Musteri musteri3 = new Musteri
            {
                id = 3,
                tc = "12773575000",
                adi = "iclal",
                soyadi = "akdamar"
            };

            MusteriManager musterimanager = new MusteriManager();
            //musterimanager.ekle();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};
                        
            musterimanager.ekle(musteri1);
            musterimanager.ekle(musteri2);
            musterimanager.sil(musteri3);
            



            //for (int i = 0; i < musteriler.Length; i++)
            //{

            //    Console.WriteLine("Müşteri Id : " + musteriler[i].id +
            //        " Adı, Soyadı : " + musteriler[i].adi + " " + musteriler[i].soyadi);
            //}



        }

    }
}
