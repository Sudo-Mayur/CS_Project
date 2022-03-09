using System;

namespace ConsoleAppPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int b = 0;
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            for(int i=2; i<numbers.Length; i++)
            {
                if(i%1==0 && i%i==0)
                {
                    Console.WriteLine(i);
                }
                {
                    continue;
                }
            }
            //for(int a=0; a< numbers.Length; a++)
            //{
            //    b = 0;
            //    for(int j=2; j<=numbers[a]/2; j++)
            //    {
            //        if(numbers[a]==0)
            //        {
            //            b = 1;
            //            break;
            //        }
            //        if(numbers[a]%j == 0)
            //        {
            //            b = 1;
            //            break;
            //        }
            //    }
            //    if(b==0)
            //    {
            //        Console.WriteLine(numbers[a]);
            //    }
            
            //}
           



        //    Console.WriteLine("Hello World!");
        //    int n, m, i = 0, Flag = 0;
        //    Console.WriteLine("Enter Your Number");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    m = n / 2;
        //    for (i = 2; i <= m; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            Console.WriteLine("Number is nor prime");
        //            Flag = 1;
        //            break;
        //        }               
        //    }
        
        //if(Flag==0)
        //    Console.WriteLine("prime number");
    }
}
}
