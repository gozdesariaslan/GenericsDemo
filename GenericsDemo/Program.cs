using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(123, "Gözde");
            myDictionary.Add(456, "Büşra");

            myDictionary.GetList();
        }
    }
}
