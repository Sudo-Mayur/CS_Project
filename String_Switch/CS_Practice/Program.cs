using System;

namespace CS_Practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //string name = "Mayur Mahadev Chavan";
            //int count = 0;
            //for(int i=0; i<name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}


            //string name = "Mayur, Mahadev Chavan";
            //int count = 0;
            //foreach (char c in name)
            //{
            //    if (c == ',')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //string name = "mayur ,Mahadev, Chavan";
            //int count = 0;
            //for (int i=0; i<name.Length; i++)
            //{
            //    if(name[i]==',')
            //    {
            //        Console.WriteLine(i);
            //        count++;

            //    }
            //}
            //Console.WriteLine($"Total number of comma\'s are {count}");

            //string reverseString = "";
            //string name = "mayur Chavan";
            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    reverseString = reverseString + name[i];
            //}
            //Console.WriteLine(reverseString);

            //string name = "Mayur the and i am the is old ";
            //string[] num = name.Split();
            //int result = 0;
            //foreach (string s in num)
            //{
            //    if (s == "the" || s == "is" || s == "am")
            //    {
            //        result++;
            //    }
            //    for(int i=0; i<num.Length; i++)
            //    {
            //        if(num[i]==s)
            //        {

            //        }
            //    }
            //}
            //Console.WriteLine(result);

            //string name = "Mayur the and i am the is old ";
            //string[] num = name.Split();
            //int result = 0;
            //int a = 0;
            //foreach (string s in num)
            //{
            //    if (s == "the" || s == "is" || s == "am")
            //    {
            //        result++;
            //    }


            //}
            //Console.WriteLine(result);
            //Console.WriteLine(a);


           
            break;

            string name = "Mayur the and i am the is old is ";
            string[] sample = { "the", "is", "to", "and" };
            string[] s = name.Split();
            int count = 0;
            foreach (string item in sample)
            {
                if(item =="is" || item=="the")
                {
                    Console.WriteLine(name.IndexOf(item));
                    count++;
                 
                }
            }
            Console.WriteLine(count);

             case 7:
                    string[] num = str.Split();
            int result = 0;
            foreach (string s in num)
            {
                if (s == "the" || s == "is" || s == "to" || s == "and")
                {
                    result++;
                }
            }
            Console.WriteLine(result);
            break;






        }

    }
}
