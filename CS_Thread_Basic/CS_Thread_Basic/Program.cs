using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_Thread_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Threading");
           
            //1.set the thread name
            Thread.CurrentThread.Name = "main Thread";
            Console.WriteLine($"The curren Thread {Thread.CurrentThread.Name}\t" +
                $"{Thread.CurrentThread.ManagedThreadId}\t" +
                $"{Thread.CurrentThread.CurrentCulture}\t" +
                $"{Thread.CurrentThread.Priority}");

            Thread t1 = new Thread((Thread) => Increment());
            Thread t2 = new Thread((Thread)=> Decreament());

            //start thread
            t1.Start();
            t2.Priority = ThreadPriority.Highest;
            t2.Start();
            Console.ReadLine();
        }

        static void Increment()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Increment {i}");
                if(i == 5)
                {
                    Thread.Sleep(1000);
                }
               
            }
        }
        static void Decreament()
        {
            for (int i = 10; i >0; i--)
            {
                Console.WriteLine($"Decrement {i}");
            }
        }
    }
}
