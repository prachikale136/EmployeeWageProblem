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
            int full_time = 1;
            int EmpWagePerHr= 20;

            int empHrs = 0;
            int empWage = 0; 
            Random random= new Random();
            int check = random.Next(0,2);

            if(check == full_time)
            {
                empHrs = 8;
            }
            else 
            {
                empHrs = 4;
            }
        empWage = empHrs * EmpWagePerHr;
        Console.WriteLine("Emp wage: " + empWage);
        }

    }
}
