using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
            //MyDictionary.Add("Mehmet", "Yıldız");

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Ali", "Demir");
            Console.WriteLine(myDictionary.Length);
            Console.WriteLine(myDictionary.MyKey[0]);
            Console.WriteLine(myDictionary.MyValue[0]);
            
        }
       
    }
}

