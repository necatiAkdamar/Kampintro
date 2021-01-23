using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)//
        {
            //başvuran bilgileri hesapla kodlarvar burada
            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)//birden fazla kredinin sonucunu görmek istiyoruz hangisi avantajlı karşılaştıracaz
        {
            foreach (var kredi in krediler)//liste olarak gönderilen kredilerdeki her bir kredinin bir operasyonunu yap. Oyüzden foreach
            {
                kredi.Hesapla();
            }
        }
    }
}
