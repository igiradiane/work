using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didy1
{
    class Program
    {


        static void Main(string[] args)
        {
            string EmploName, type, Answer;
            int hr = 0, EmploNumber;
            double bonus = 0, tax = 0, SSF;
            double salary, Gsalary = 0, netSalary = 0;

            Console.Clear();
            Console.WriteLine("EMPLOYEE E-PAYMENT");
            Console.WriteLine("\n\n");
            while (true)
            {
                Console.WriteLine("Enter his/her name ");
            
                EmploName = Console.ReadLine();
                Console.WriteLine("Enter his/her number:");
               
                EmploNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is his/her category: ");

                type = Console.ReadLine();

                if (type == "monthly")

                {
                    Console.Write("\t\t his/her salary:");
                    salary = Convert.ToInt32(Console.ReadLine());

                    

                    Console.WriteLine("Gross salary: {0:0.00}.", Gsalary);
                    tax = salary * 18 / 100;
                    SSF = salary * 3 / 100;
                    netSalary = salary - tax - SSF;
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("the charged salary is {0}", tax);
                    
                    Console.WriteLine("the security fund is {0}", SSF);
                    
                    Console.WriteLine("the net salary after tax and security fund is {0}", netSalary);


                }
                else if (type == "hourly")
                {
                    Console.WriteLine("enter hours worked:");
                   
                    hr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter hourly salary");
                   
                    salary = Convert.ToInt32(Console.ReadLine());
                    Gsalary = salary * hr;
                    tax = Gsalary * 18 / 100;
                    netSalary = Gsalary - tax;
                    Console.WriteLine("=======================");
                    Console.WriteLine("the gross salary is :{0}", Gsalary);
                    
                    Console.WriteLine("the charged tax is of: {0}", tax);
                   
                    Console.WriteLine("the net salary after tax reduction is: {0}\t", netSalary);
                   
                }

                else if (type == "evening")
                {
                    Console.WriteLine("enter hours worked:");
                    Console.WriteLine("\t\t");
                    hr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter hourly salary");
                    Console.WriteLine("\t\t");
                    salary = Convert.ToInt32(Console.ReadLine());
                    Gsalary = salary * hr;
                    bonus = Gsalary * 0.15 / 100;
                    tax = Gsalary * 18 / 100;
                    netSalary = Gsalary - tax + bonus;
                    Console.WriteLine("++++++++++++++++");
                    Console.WriteLine("the gross salary is of :{0}", Gsalary);
            
                    Console.WriteLine("the charged tax is of:{0}", tax);
                      
                    Console.WriteLine("the bonus on evening work is:{0}", bonus);
                  
                    Console.WriteLine("the net salary is:{0}", netSalary);
                }

                
                Console.Write("Do You Want To Continue? Y/N : ");
                Answer = Console.ReadLine();
                if (Answer == "y" || Answer == "Y")
                {
                    continue;
                }
                else if (Answer == "n" || Answer == "N")
                {

                    Console.Write("exit");
                    Console.Write("\n\n");
                    break;
                }
            }
        }
    }
}