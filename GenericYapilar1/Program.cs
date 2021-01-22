using System;
using System.Collections.Generic;

namespace GenericYapilar1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();//Gerenic e hangi tip verirsek,(List generic bir tiptir.)
            sehirler.Add("Ankara");//parametre olarak vereceklerimiz parantaz içinde o tipte olur.
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            Mylist<string> sehirler2 = new Mylist<string>();//bizim oluşturduğumuz generic yapı. Ne tipte veri tanımlarsak o şekilde çalışır.
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);


        }
    }

    class Mylist<T>
    {
        T[] _array;
        T[] _tempArray;
        public Mylist()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array; //array deki elemenların heap ten uçmaması için 1 artırmadan önce tempArraye referansının aktarılması
            _array = new T[_array.Length + 1]; //yeni bir eleman fazlalı yeni bir array oluşturuyoruz.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; //heap ten uçmaması için temparray e tutturduğumuz elemanları eleman sayısı 1 artan array e aktarıyoruz.
            }

            _array[_array.Length - 1] = item; //array in sonuncu elemanına da gönderdiğimiz item i aktarıyoruz.
        }

        public int Count
        {
            get { return _array.Length; }

        }

    }
}
