using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class GenericClass<T>//T parametresi biz ne değer tanımlarsak o değer tipine  dönüşüyor.
    {
        public T Example1;
        public void Example2(T parameter) { }
    }
}
