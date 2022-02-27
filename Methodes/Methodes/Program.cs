using System;

namespace Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operation that you want");  //Add=addition
            string v = Console.ReadLine();                       //Sub=Substraction
            Console.WriteLine("Enter first number");             //Mul=Multiplication
            int a =Convert.ToInt32(Console.ReadLine());          //Div=Division
            Console.WriteLine("Enter first number");
            int b = Convert.ToInt32(Console.ReadLine());
            
            MyMethode(a, b, v);  
          
            static void MyMethode(int x,int y,string Cal)
            {
                switch(Cal)
                {
                    case "Add":
                        if(x<=0 || y<=0)
                        {
                            Console.WriteLine("Wrong Input, the value should greater than zero and non negative value");
                        }
                        Console.WriteLine("The Addition is :" + x + y);
                        break;
                    case "Sub":
                        if (x <= 0 || y <= 0)
                        {
                            Console.WriteLine("Wrong Input, the value should greater than zero and non negative value");
                        }
                        Console.WriteLine("The Substractio is :" +  (x - y));
                        break;
                    case "Mul":
                        if (x <= 0 || y <= 0)
                        {
                            Console.WriteLine("Wrong Input, the value should greater than zero and non negative value");
                        }
                        Console.WriteLine("The Multiplication is :" + x * y);
                        break;      
                    case "Div":
                        if (x <= 0 || y <= 0)
                        {
                            Console.WriteLine("Wrong Input, the value should greater than zero and non negative value");
                        }
                        Console.WriteLine("The Division is :" + x / y);
                        break;
                    default:
                        Console.WriteLine("Doesnt mach any case");
                        break;

                }
            }
           
        }
    }
}
