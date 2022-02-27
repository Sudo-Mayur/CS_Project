using System;

namespace ConsoleApp2
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            bool isSpeaker = true;
            int RegistrstionFees = isSpeaker ? 0 : 50;
            Console.WriteLine(RegistrstionFees);

        }
    }
}
