using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "2222222222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12356554889";

            Musteri musteri3 = new GercekMusteri();//müşteri class ı hem gerçek hem tüzel kişinin referansını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();//hem gerçek hem tüzel müşteri ekleyebiliyoruz. Customermanager clası ile
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
