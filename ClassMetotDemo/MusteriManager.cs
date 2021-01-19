using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri customer)
        {
            Console.WriteLine("ID : " + customer.id);
            Console.WriteLine("Name : " + customer.tc);
            Console.WriteLine("Surname : " + customer.adi);
            Console.WriteLine("Phone Number : " + customer.soyadi);

        }
        public void sil(Musteri customer)
        {
            Console.WriteLine("ID : " + customer.id);
            Console.WriteLine("Name : " + customer.tc);
            Console.WriteLine("Surname : " + customer.adi);
            Console.WriteLine("Phone Number : " + customer.soyadi);
            Console.WriteLine("Müşteri Silindi");
        }
        public void Listele(Musteri[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine("ID : " + customers.id);
                Console.WriteLine("Name : " + customers.tc);
                Console.WriteLine("Surname : " + customers.adi);
                Console.WriteLine("Phone Number : " + customers.soyadi);

            }


        }

    }
}