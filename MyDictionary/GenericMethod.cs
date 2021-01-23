using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class GenericMethod<T1, T2>
    {
        T1[] key;
        T2[] value;
        T1[] tempkey;
        T2[] tempvalue;

        public GenericMethod()
        {
            key = new T1[0];
            value = new T2[0];
        }

        public void Add(T1 keys, T2 values)
        {
            tempkey = key;
            tempvalue = value;
            key = new T1[tempkey.Length + 1];
            value = new T2[tempvalue.Length + 1];
            for (int i = 0; i < tempkey.Length; i++)
            {
                key[i] = tempkey[i];
                value[i] = tempvalue[i];
            }
            key[key.Length - 1] = keys;
            value[value.Length - 1] = values;
            Console.WriteLine("Rehber kaydı oluştu. Numara:{0} - İsim:{1}", keys, values);
        }

        public int Count
        {
            get { return key.Length; }
        }

        

        internal class ValueCollection
        {
        }
    }
}
