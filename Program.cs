using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program

    {
        public static double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("enter operation");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.subtraction");
            Console.WriteLine("3.multplication");
            Console.WriteLine("4.division");
            op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            var operation = new Calculate();
            
            
            switch(op)
            {
                case 1:
                    
                    Console.WriteLine("the sum of two entered numbers {0} and {1} equal to {2}", num1, num2, operation.Add(num1, num2));
                    Console.ReadKey();
                    break;
                case 2:
                    
                    Console.WriteLine("the difference of two entered numbers {0} and {1} equal to {2}", num1, num2, operation.subtraction(num1, num2));
                    Console.ReadKey();
                    break;
                case 3:
                    
                    Console.WriteLine("the multplication table of entered number {0}  and {1} is equal to {2}", num1, num2, operation.Multplication(num1, num2));
                    Console.ReadKey();
                    break;
                case 4:
                    
                    
                    Console.WriteLine("the quotient of two entered numbers {0} and {1} equal to {2}", num1, num2, operation.Division(num1, num2));
                    Console.ReadKey();
                    break;
                    Console.ReadKey();
                default:
                    Console.WriteLine("try another operand");
                    Console.ReadKey();
                    break;
            }


            
        }
    }
}
