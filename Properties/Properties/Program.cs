using System;

namespace Properties
{
    internal class Program
    {
        public int number { get; set; }
        string name;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
    class A
    {
        public static void Main(string[] args)
        {
            Program P = new Program();
            P.number = 101;
            Console.WriteLine(P.number);
            P.Name = "Mayur";
            Console.WriteLine(P.Name);
        }
    }
}
