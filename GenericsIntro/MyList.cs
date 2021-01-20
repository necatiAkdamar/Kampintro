using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro//
{
    class MyList<T>
    {
        T[] items;
        //constructor-bir class new lendiğinde çalışan ilk bloğa constructor denir.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item) //T olarak ne değer verirsem istediğim elemanın türüde odur.
        {
            T[] tempArray = items;//geiçici dizinin referansı items ın referansı oldu. new lediğimizde referans değerimiz kaybolmasın verilerimiz kalsın diye
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//tempArray e referans değeri kaybolmasın diye verilen değerleri items a geri alıyoruz.
            }
            items[items.Length - 1] = item;//items ın son elemanına parametre olarak gelen itemi ekledim.
        
        }
    }
}
