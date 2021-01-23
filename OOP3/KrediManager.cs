using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager//interface leri birbirinin alternatifi olan ama kod içerikleri birbirinden farklı olan classlar için şablon ve referans tutucu olarak kullanırız.
    {
        void Hesapla();
        void BiseyYap();
    }
}
