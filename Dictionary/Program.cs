using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(134, "Tolga Demirer");
            ogrenci.Add(158, "Ümit Özkan");
            ogrenci.Add(115, "Kadir Aydemir");
            ogrenci.Add(188, "Cemal Çiftçi");
            ogrenci.Add(201, "Orhan Yalçın");
            ogrenci.Add(413, "Necati Akdamar");

            Console.WriteLine("Lütfen Öğrenci Numarası Giriniz:");
            int No = int.Parse(Console.ReadLine());//intparse girilen değeri integer a çevirir.

            string isim = " ";
            if (ogrenci.TryGetValue(No, out isim))//TrygetValue yapısında koleksiyonda No değeri mevcut ise bununla ilgili değeri isim değişkenine atar.
            {
                Console.WriteLine(isim);
            }
            else
            {
                Console.WriteLine("Öğrenci Bulunamadı TryGetValuedan");
            }

            try//try-catch yapısında try bölümünde kodlarımız bulunur. Catch bölümünde ise
               //try bölümündeki kodlarda hata oluştuğunda kullanıcıya verilecek mesaj yer alır.
            {
                Console.WriteLine(ogrenci[No]);
            }
            catch (Exception)
            {
                Console.WriteLine("Öğrenci Bulunamadı.");

            }
            bool varmi = ogrenci.ContainsKey(158);//parametre olarak girilen değerde bir anahtar var ise true yok ise false döndürür.
            //ogrenci.Clear();//koleksiyon içerisinde yer alan tüm anahtar-değer çiftlerini siler.

            int ElemanSayisi = ogrenci.Count;//koleksiyon içerisinde bulunan anahtar değerlerin sayısını verir.
            Console.WriteLine("Eleman Sayısı : " + ElemanSayisi);

            bool SilindiMi = ogrenci.Remove(415);//parametre olarak girilen değerde bir anahtar mevcutsa anahtarı ve değir silip true, anahtar mecvcut değilse false döndürür.

            Dictionary<int, string>.KeyCollection KeysList = ogrenci.Keys;//anahtarları içeren bir koleksiyon oluşturur.
            foreach (int Keys in KeysList)
            {
                Console.WriteLine(Keys);
                Console.WriteLine(ogrenci[Keys]);
            }

            Dictionary<int, string>.ValueCollection ValueList = ogrenci.Values;//değerleri içeren bir koleksiyon oluşturur.
            foreach (string Value in ValueList)
            {
                Console.WriteLine("Değerler: "+Value);
            }
                        
            foreach (KeyValuePair<int,string> Veri in ogrenci)//koleksiyonda her bir veriyi aynı anda tutan komut yapısıdır keyvaluepair
            {
                Console.WriteLine("Numara:{0} - İsim:{1}", Veri.Key, Veri.Value);
            }


        }
    }
}
