using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //Customer customer = new Customer{Id = 1,FirstName = "Necati",LastName = "Akdamar",Address = "Ankara"};
            //personManager.Add(customer); //personmanager a customer gönderiyoruz.

            //personManager.Add(new Customer { Id = 2, FirstName = "Engin", LastName = "Demiroğ", Address = "Kayseri" });//farklı ekleme tarzı

            //Student student = new Student { Id = 3, FirstName = "Ogrenci1", LastName = "SoyadOgr", Department = "Comp.Science" };//farklı ekleme tarzı
            //personManager.Add(student);

            //IPerson person = new IPerson(); interfaceler new lenemez ama implemnt ettiği tüm sınıfları referanslayabilir.
            IPerson person = new Customer();
            IPerson person2 = new Student();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());//sqlserver veritabanımıza eklendi

            //bir verimiz var ve bu veriyi her iki veritabanına eklemeye çalışıyoruz.
            ICustomerDal[] customerDals = new ICustomerDal[2] 
            { new SqlServerCustomerDal(), new OracleCustomerDal() };//Veritabanlarımızdan bir array oluşturuyoruz.
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();//bütün veritabanlarımızı gezip tek tek veriyi ekliyoruz.
            }

            

        }
    }

    interface IPerson//temel amacı bir nesne oluşturup diğer nesneleri ondan implement etmektir./Soyut bir nesnedir.
    {
        int Id { get; set; }//bunlar diğer nesnelerde kullanacağımız temel nesneler.
        String FirstName { get; set; }
        String LastName { get; set; }
    }

    class Customer : IPerson//Somut Nesnedir
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson//Somut nesnedir.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }

    class PersonManager
    {   //Customer customer yerine Iperson person veriyorum.
        public void Add(IPerson person)//Customer customer = parametre olarak bana bir müşteri nesnesi ver demektir.
        {
            Console.WriteLine(person.FirstName);//implemente ettiği için Ipersona ister customer, ister student gönderebiliyoruz.
        }
    }
}
