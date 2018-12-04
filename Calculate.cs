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
            
           
            return num1*num2;
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
