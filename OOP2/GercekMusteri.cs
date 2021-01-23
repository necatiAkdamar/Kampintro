using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual-Gercekmüşteri demektir.
    class GercekMusteri:Musteri //gerçek müşteri de bir müşteridir. inheritance. Müşteri de ne varsa burayada getir.
    {       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
