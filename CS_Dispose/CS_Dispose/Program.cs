using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Dispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Dispose();
            myClass.display();
            Console.ReadLine();

            using(MyClass myClass2 = new MyClass())
            {

                myClass.display();
            }

        }
    }
    public class MyClass : IDisposable
    {
        public MyClass()
        {
            Console.WriteLine("ctr Called");
        }

        //void IDisposable.Dispose()
        //{
        //    Console.WriteLine("Call Dispalay");
        //}
        public void display()
        {
            Console.WriteLine("Call Display");
        }
       
        public void Dispose()
        {
            Console.WriteLine("calling Dispose");
            GC.SuppressFinalize(this);           
        }

        ~MyClass()
        {
            Console.WriteLine("called Des");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("aashsdshdsdsdfds");
            }
            Console.ReadLine();
        }

    }
}
