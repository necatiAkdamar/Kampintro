using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]//bir çalışan array i oluşturuyoruz. daha 3ten fazlada tanımlayabiliriz.
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();//bütün çalışanlara çalış emri veriyoruz.
            }

            IEat[] eats = new IEat[2]//buraya robot dışında çalışanlara yemek yeme emri veriyoruz.
            {
                new Manager(),
                new Worker(),                
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }


    //Şirkette çalışanların bulunduğu bir olay simule ediyoruz.
    //İşçiler, yöneticiler ve robotlar çalışan tiplerdir.
    interface IWorker
    {
        void Work();
        //void Eat();//Bunları ayrı ayrı interface olarak tanımlayabiliriz.
        //void GetSalary();//maaş
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary//maaş için
    {
        void GetSalary();
    }



    class Manager : IWorker, IEat, ISalary//yönetici
    {
        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        void IEat.Eat()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary//çalışan
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        void IWorker.Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker//Robot sadece çalışır yemek ve maaş almaz.
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
