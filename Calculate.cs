using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Calculate
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Division(double num1, double num2)
        {
            
            return num1/ num2;
        }
        public double Multplication(double num1, double num2)

        {
            string cool;
            int num,k;
            Console.WriteLine("do you wish a multiplication table of a any number?");
            cool = Console.ReadLine();
            if(cool=="Y"|| cool=="Y")
            {
                Console.WriteLine("Enter any number");
                num = Convert.ToInt32(Console.ReadLine());
                for(k=1;k<=10;k++)
                {
                    Console.WriteLine("the multiplicatio table of number {0}x{1} is ={2}", num, k, num * k);
                }



            }
            else if(cool=="N"||cool=="N")
            {
                
            }
            return num1 * num2;

        }
        public double subtraction(double num1, double num2)
        {
            
            if(num1==0)
            {
                throw new Exception("num1 should not be zero");

            }
            else
            {
                return num1 - num2;
            }
        }

    }

}
