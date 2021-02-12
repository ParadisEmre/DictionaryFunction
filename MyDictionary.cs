using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryFunction
{
    class MyDictionary<T, L>
    {
        T[] items1;
        L[] items2;

        public MyDictionary()
        {
            items1 = new T[0];

            items2 = new L[0];

        }

        public bool Count { get; internal set; }

        public void Add(T item1, L item2)
        {

            T[] temp1 = items1;
            L[] temp2 = items2;

            items1 = new T[items1.Length + 1];
            items2 = new L[items2.Length + 1];




            for (int i = 0; i < temp1.Length; i++)
            { 
                items1[i] = temp1[i];
                items2[i] = temp2[i];
            }

            items1[items1.Length - 1] = item1;
            items2[items2.Length - 1] = item2;

        }
        public void toList()
        {
            for (int i = 0; i < items1.Length; i++)
            {
                Console.WriteLine(items1[i] + " : " + items2[i]);
            }
        }

    }
}
