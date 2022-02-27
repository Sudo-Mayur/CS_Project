using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Q5 Obj = new Name1();
           // Obj.Methode1(2, 3);
           // ((Name1)Obj)).Methode2(4, 6, 7);

           //Q7
           MyClass1 myClass1 = new MyClass1();
            myClass1.MyProperty = 21;
            myClass1.MyProperty = 10000;
            Console.WriteLine($"age : {myClass1.MyProperty} Salary : { myClass1.MyProperty}");

           //Q11
           Q11 q11 = new Q11();
           q11.Name = 21;
           Console.WriteLine(q11.Name);



        }
    }
}
