using System;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sum=0;
            for(int i=0; i<=10; i++)
            {
                if(i==5)
                {
                    break;
                   
                }
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
