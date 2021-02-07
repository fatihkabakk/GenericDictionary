using System;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary1 = new MyDictionary<string, string>();
            myDictionary1.Add("Test", "Test_Pair");
            Console.WriteLine("First Dictionary;");
            myDictionary1.GetPairs();
            Console.WriteLine("***********************************");

            MyDictionary<int, string> myDictionary2 = new MyDictionary<int, string>();
            myDictionary2.Add(1, "Int_Test");
            myDictionary2.Add(2, "Second_Val");
            Console.WriteLine("\nSecond Dictionary;");
            myDictionary2.GetPairs();
            Console.WriteLine("***********************************");
            Console.ReadLine();
        }
    }
}
