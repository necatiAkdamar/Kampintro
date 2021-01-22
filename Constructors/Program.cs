using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName="Necati", LastName="Akdamar", City="Kayseri"};
            Customer customer3 = new Customer();//customer1 in kullanımı ile aynı bu kullanım
            customer3.Id = 3;
            customer3.FirstName = "İclal";
            customer3.LastName = "Akdamar";
            customer3.City = "Argıncık";

            Customer customer2 = new Customer(2, "Müge", "Akdamar", "Kayseri");//Constructor tanımlarsak parametre gönderiyor gibi bu şekilde de kullanabilirilz. 

            Console.WriteLine(customer2.FirstName);
        }

        
    }

    class Customer
    {
        public Customer()//customer1 ve customer3 default constructorı yani burasını kullanır.
        {

        }

        public Customer(int id, string firstname, string lastname, string city)//ctor tab yaptığımızda gelen Constructor yapısı.Class ismiyle aynı açılır.Customer 2 burasını kullanır.
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }

    public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
