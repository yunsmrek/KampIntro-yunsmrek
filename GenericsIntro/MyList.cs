using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//T tip int string class her şey olabiliyor
    {
        T[] items;// classın içinde her yer erişebilsin diye
        public MyList()//ctor tab tab constructor bir class new lendiği zaman çalışan blok a denir
        {
            items = new T[0];//otomatik çalışıyor
        }
        public void Add(T item)
        {
            T[] tempArray = items;//Geçici bir diziye elemanları atıyoruz
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;//0dan başladığı için -1 yazıyoruz

        }
    }
}
