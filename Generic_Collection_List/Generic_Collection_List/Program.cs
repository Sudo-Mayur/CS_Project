using System;
using System.Collections.Generic;

namespace Generic_Collection_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Rollnumbers = new List<int>();
            Rollnumbers.Add(101);
            Rollnumbers.Add(103);
            Rollnumbers.Add(104);
            Rollnumbers.Add(105);
            Rollnumbers.Add(106);

            Rollnumbers.Insert(1,102);
            Console.WriteLine($"Total element in the list :" + Rollnumbers.Count);
            Console.WriteLine(Rollnumbers.Contains(106));

            foreach(int i in Rollnumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");

            Rollnumbers.AddRange(Rollnumbers);
            foreach (int i in Rollnumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");
            Rollnumbers.RemoveAt(3);
            Rollnumbers.Remove(106);
            foreach (int i in Rollnumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");
            Rollnumbers.Clear();
            if(Rollnumbers.Count == 0)
            {
                Console.WriteLine("No Rollnumber available in the list");
            }
            Console.WriteLine("----------------");
            List<string> Names = new List<String>();
            Names.Add("Mayur");
            Names.Add("Amol");
            Names.Add("Manoj");
            Names.Add("Ram");
            Names.Add("Sam");
            
            Names.Sort();
            foreach(string i in Names)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------");
            Names.Reverse();
            foreach(string i in Names)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");
            Console.WriteLine(Names.IndexOf("Ram"));


        }
    }
}
