using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)//Ekleme Fonksiyonu,operasyonu tanımlama. (string ad) parametresi tanımlar gibi.Product türünde product isimli parametre gönder
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }



        //void kullanımı farkı
        public int Topla(int sayi1, int sayi2)//fonksiyon olarak tanımlayıp geriye değer-sonuç döndürmesini istediğimiz metotları bu şekilde tanımlarız.
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)//void geriye veri döndürmeyen git-yap-işlemi bitir, sadece şunu yap ve bitir şeklindeki kodlamalarda kullanılır.
        {
            Console.WriteLine( sayi1 + sayi2);
        }
    }

}
