using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate-TüzelMüşteri demek
    class TuzelMusteri:Musteri //bu olaya miras yani inheritance diyoruz. Tüzelmüşteri bir müşteridir demek bu. Müşteride ne varsa burayada getir.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
