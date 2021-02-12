using System;

namespace DictionaryFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>() ;

            myDictionary.Add("Emre", 18);
            myDictionary.Add("Yeşim", 24);
            myDictionary.Add("Selim", 10);
            myDictionary.Add("Onur", 39);
            myDictionary.Add("Bilge", 28);

            myDictionary.toList();
        }
    }
}
