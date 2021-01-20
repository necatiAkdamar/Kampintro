using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();   //urun ekleme/tanımlama şekli
            product1.Id = 1;
            product1.CategoryID = 2;        //mobilya kategori IDsi 2 olsun varsayalım
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryID = 5, UnitsInStock = 5, 
                ProductName = "Kalem", UnitPrice = 35 };    //bu şekilde de yazılabilir urun ekleme

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();   //string isim; der gibi ProductManager türünde productManager değişkeni tanımlıyoruz.
            productManager.Add(product1);   //product1 ile tanımladığımız bütün değerleri parametre içinde gönderdik.




            //int, double, bool... sayısal tipler değer tiplerdir. Atamalar değeri üzerinden olur.
            //diziler, class, interface, abstract class... referans tiplerdir. Atamalar referans tablosu üzerinden olur ve sonradan yapılan değişiklikler tipin içeriğini değiştirebilir.
        }
    }
}
