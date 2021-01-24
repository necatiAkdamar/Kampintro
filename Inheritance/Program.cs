using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]//Persondan inherit-kalıtım olduğu için bu şekilde kullanıp 3 classa erişeiliriz.
            {
                new Customer{FirstName="Engin" },
                new Student{ FirstName="Necati"},
                new Person{ FirstName="Müge"}
            };

            foreach (var person in persons)//bütün classları gezdik.
            {
                Console.WriteLine(person.FirstName);
            }

            Console.WriteLine("Hello World!");
        }
    }
//Interfaceler soyut nitelikte olup alttaki klaslara birden fazla ımplement olabilir.
    class Person//Ama baseclass olan class alttaki classlarda kullanıldıysa başka inherit belirtilmez.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person//customer in babası person dır. aldığı bütün özellikleri alır.
    {
        public string City { get; set; }//persondan aldığı özellikler dışında kendi özelliğide vardır.
    }

    class Student:Person
    {
        public string Department { get; set; }
    }
}
