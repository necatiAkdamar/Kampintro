using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface ICustomerDal//Dal insert update delete işlemlerinin yapıldığı yer anlamına gelir
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal//çalıştığımız veritabanı ile ilgili işlemleri tanımlıyoruz.
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleCustomerDal : ICustomerDal//çalıştığımız veritabanı ile ilgili işlemleri tanımlıyoruz.
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
