using System;
using System.Collections.Generic;

namespace Generic_Collection_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> MyDist = new Dictionary<string, string>();
            MyDist.Add("Good","Worst");
            MyDist.Add("Carefull","Careless");
            MyDist.Add("Agree","disagree");
            MyDist.Add("Attact","Defence");
            MyDist.Add("Friend","Enemy");
             foreach(KeyValuePair<string, string> item in MyDist)
            {
                Console.WriteLine("Keys are :"+ item.Key +" , " + "Values are :" + item.Value);
            }
            Console.WriteLine(MyDist.Count);
            Console.WriteLine("---------------------------------------------");
            MyDist.Remove("Good");
            foreach (KeyValuePair<string, string> item in MyDist)
            {
                Console.WriteLine("Keys are :" + item.Key + " , " + "Values are :" + item.Value);
            }
            Console.WriteLine(MyDist.ContainsKey("Friend"));

            MyDist.Clear();
            foreach (KeyValuePair<string, string> item in MyDist)
            {
                Console.WriteLine("Keys are ;" + item.Key + " , " + "Values are ;" + item.Value);
            }
            Console.WriteLine("---------------------------------------------");

            Dictionary<int, string> MyDist1 = new Dictionary<int, string>();
            MyDist1.Add(1, "Mayur");
            MyDist1.Add(2, "Manoj");
            MyDist1.Add(3, "Mahesh");
            MyDist1.Add(4, "Mandar");
            foreach(int item in MyDist1.Keys)
            {
                Console.WriteLine("Key is :" + item);
            }

            Console.WriteLine("---------------------------------------------");

            foreach (string item in MyDist1.Values)
            {
                Console.WriteLine("Value is :" + item);
            }
        }
    }
}
