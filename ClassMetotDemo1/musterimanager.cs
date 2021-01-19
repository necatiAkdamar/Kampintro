using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class musterimanager
    {
        public void Ekle(int id, string adi, string soyadi)
        {
            musteri ekle = new musteri();
            ekle.id = id;
            ekle.adi = adi;
            ekle.soyadi = soyadi;
                                   
            string s = ekle.ToString();
            Console.WriteLine(s);
        }

        public void sil(int id, string adi, string soyadi)
        {
            musteri sil = new musteri();
            sil.id = id;
            sil.adi = adi;
            sil.soyadi = soyadi;

            Console.WriteLine("Girmiş olduğunuz " + id + " idli " + adi + " " + soyadi + " müşteri kaydı silinmiştir.");
        }
                
    }
}
