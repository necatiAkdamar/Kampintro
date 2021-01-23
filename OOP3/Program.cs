using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args) 
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();//interfacelerde kendisini implement eden classın referansını tutabilir.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);//parametre olarak hangi krediyi gönderirsem kredimanagerdaki hesapla o parametrenin hesaplasını çalıştırır. Aynı zamanda loglama yapacaz database e


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };//2 krediyi hesaplattık aynı anda

            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);//kredileri yollayabiliriz


        }
    }
}
