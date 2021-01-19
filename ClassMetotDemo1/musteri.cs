using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class musteri
    {
        int _id;
        public int id
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        string _adi;
        public string adi
        {
            get { return _adi; }
            set { _adi = value; }
        }
        string _soyadi;
        public string soyadi
        {
            get { return _soyadi; }
            set { _soyadi = value; }
        }

        public override string ToString()
        {
            string s = "Id: "+ _id+", Adı: " + _adi  + ", Soyadi: " + _soyadi + " isimli müşteriler eklendi.";
            return s;
        }

    }
}
