using System;

namespace Switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operation that you want to perform");
            Console.WriteLine("Add");                    //Add=addition
            Console.WriteLine("Sub");                   //Sub=Substraction        
            Console.WriteLine("Mul");                   //Mul=Multiplication
            Console.WriteLine("Div");                   //Div=Division
            Console.WriteLine("------------");
          
            string v = Console.ReadLine();
            
                Console.WriteLine("Enter first number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = Convert.ToInt32(Console.ReadLine());

                Program.MyMethode(a, b, v);
            }

            static void MyMethode(int x, int y, string C)
            {
                switch (C)
                {
                    case "Add":
                        if (x <= 0 || y <= 0)
                        {
                            Console.WriteLine("Wrong Input, the value should greater than zero and non negative value");
                        }
                        else
                        {
                            Console.WriteLine("The Addition is :" + (x + y));
                        }
                        break;
                    case "Sub":
                        if (x <= 0 || y <= 0)
                        {
                            Console.WriteLine("Wrong Input, the value should greater than zero and non negative value");
                        }
                        else
                        {
                            Console.WriteLine("The Substractio is :" + (x - y));
                        }
                        break;
                    case "Mul":
                        if (x <= 0 || y <= 0)
                        {
                            Console.WriteLine("Wrong Input, the value should greater than zero and non negative value");
                        }
                        else
                        {
                            Console.WriteLine("The Multiplication is :" + (x * y));
                        }
                        break;
                    case "Div":
                        if (x <= 0 || y <= 0)
                        {
                            Console.WriteLine("Wrong Input, the value should greater than zero and non negative value");
                        }
                        else
                        {
                            Console.WriteLine("The Division is :" + (x / y));
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input operation");
                        break;

                }
            }

        }
    }

