using System;

namespace Swaping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your first number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int temp = 0;
            //temp = num1;
            //num1 = num2;
            //num2 = temp;
            //Console.WriteLine();
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //int n = 5;
            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine(n*i);

            //}

            //Console.WriteLine("Enter first number");
            //int num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter third number");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter fourth number");
            //int num4 = Convert.ToInt32(Console.ReadLine());
            //double avg = (num1 + num2 + num3 + num4) / 4;
            //Console.WriteLine(avg);

            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"You look younger than {age}");
            //Console.WriteLine("You look younger than {0}", age);

            //Console.WriteLine("Enter Number");
            //int num=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} {1} {2} {3}",num, num ,num ,num);
            //Console.WriteLine("{0}{1}{2}{3}", num, num, num, num);
            //Console.WriteLine("{0} {1} {2} {3}", num, num, num, num);
            //Console.WriteLine("{0}{1}{2}{3}", num, num, num, num);

            //Console.WriteLine("Enter Number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}{1}{2}", num, num, num);
            //Console.WriteLine("{0} {1}", num, num);
            //Console.WriteLine("{0} {1} ", num, num);
            //Console.WriteLine("{0} {1} ", num, num);
            //Console.WriteLine("{0}{1}{2}", num, num, num);

            //string name = "w3resource";
            //Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", name[0], name[2], name[3], name[4], name[5], name[6], name[7], name[8],name[9]);
            //Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", name[0], name[1], name[2], name[3], name[4], name[5], name[6], name[7], name[8]);

            //string sentence = "The quick brown fox jumps over the lazy dog.";
            //Console.WriteLine("{0}{1}{2}", sentence[0], sentence, sentence[0]);

            //Console.WriteLine("enter first number");
            //int num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if(num1 >0 && num2 <0 || num1<0 && num2>0)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //Console.WriteLine("Enter first Number");
            //int num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second Number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1==num2 ? 3*(num1+num2) :(num1+num2));
            //if(num1==num2)
            //{
            //    Console.WriteLine(3 * (num1 + num2));
            //}
            //else
            //{
            //    Console.WriteLine(num1 + num2);
            //}

            //Console.WriteLine("Enter first Number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second Number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int sum = num1 + num2;
            //bool a=true; bool b=false;
            //Console.WriteLine(num1==20 || sum==20 ? a : b);

            //Console.WriteLine("Enter first Number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //bool a = true; bool b = false;
            //if (num1 % 20==0 && num1>=100 && num1<=200)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}
            //string setence = "My Name is Mayur";
            //Console.WriteLine(setence.ToUpper());
            //Console.WriteLine(setence.ToLower());
            //Console.WriteLine(setence.Split());

            //for(int i=0; i<=99; i++)
            //{
            //    if(i % 2 !=0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("-----------------");
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            Console.WriteLine("\nSum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine(sum.ToString());

        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }

}
    

