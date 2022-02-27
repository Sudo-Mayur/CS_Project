using System;
using System.Collections;

namespace Collection_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue MyQueue = new Queue();
            MyQueue.Enqueue("Mayur");     //ue methode is used to add the element in the Enque
            MyQueue.Enqueue("21");
            MyQueue.Enqueue("Male");
            MyQueue.Enqueue("True");
            MyQueue.Enqueue("7 August");

            Console.WriteLine(MyQueue.Count);  // Count methode count total element in the queue
            Console.WriteLine("--------------------");
            String name =Convert.ToString( MyQueue.Contains("Mayur")); //Cotains methode find wether the element is present in the queue or not
            Console.WriteLine(name);
            Console.WriteLine("--------------------");

            foreach (Object item in MyQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");

            MyQueue.Dequeue();             //Dequeue methode remove the first elemt from Queue
            foreach (Object item in MyQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");

            Console.WriteLine(MyQueue.Peek());  //Peek methode print first element fron the queue
            Console.WriteLine("--------------------");

            MyQueue.Clear();   //clear methode clear the all element from the queue
            foreach (Object item in MyQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(MyQueue.Count);
        }
    }
}
