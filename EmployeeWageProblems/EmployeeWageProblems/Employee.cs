using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    internal class Employee
    {
        public static void IsCheck()
        {
            const int Part_Time = 1;
            const int Full_Time = 2;
            int EmpWagePerHr= 20;

            int empHrs = 0;
            int empWage = 0; 
            Random random= new Random();
            int check = random.Next(0,3);

           switch(check)
            {
                case Full_Time:
                       empHrs = 8;
                    break;
                case Part_Time:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
        empWage = empHrs * EmpWagePerHr;
        Console.WriteLine("Emp wage: " + empWage);
        }

    }
}
