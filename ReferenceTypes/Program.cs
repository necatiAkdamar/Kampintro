using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {//int, decimal, bool, float,enum, bool sayılal tipler değer tiplerdir. value types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayı1 : "+sayi1);//sayi1 20 değerini alır.


            //array, class, interface... reference types lerdir.
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;//diziler referans değer olduğu için sayılar1 dizisi ilk elemanı 1000 olur.
            Console.WriteLine(sayilar1[0]);//sayilar1 dizisinin ilk değeri 1000 olur. 

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;//dediğimde person2 ninde firstname i Engin olur. Bellekteki adresleri birbirine atıyoruz.
            person1.FirstName = "Derin";// dediğimizde referanstipler olduğu için person2ninde firstname i Derin olacaktır.
            Console.WriteLine(person2.FirstName);//sonuc Derin
            Console.WriteLine(person1.FirstName);//sonuc Derin

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "2134589";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;//inherit yani kalıtsal olduğu için customer i person e atayabiliyoruz.
            customer.FirstName = "Ahmet";

            Console.WriteLine(person3.FirstName);//Ahmet olur. Referans adresi ahmet atadığımız için
            Console.WriteLine(customer.FirstName);//Ahmet olur.
            Console.WriteLine(((Customer)person3).CreditCardNumber);//burada person3 inherit olduğu için customer i boxing yaparak creditnumber e ulaşıyoruz.

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);//inherit yapıda olduğu için parantez içinde person, employe ve customer i parametre olarak gönderebiliyoruz
            //buda bize yazılımda aynı kodu farklı nesneler için çalıştırmaya imkan sunuyor.
        }
    }

    class Person//Buraya base class yani temel sınıf denir. Ebeveyn denir.
    {
        public int    Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person//Burası child sınıftır.person class ındakilere ek olarak creditnumberda var Customer class ında
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person//Burasıda child sınıftır. person class ındakilere ek olarak EmployeeNumber var Employee classında
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
