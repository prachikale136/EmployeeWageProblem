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
            int Part_Time = 0;
            int Full_Time = 1;
            int EmpWagePerHr= 20;

            int empHrs = 0;
            int empWage = 0; 
            Random random= new Random();
            int check = random.Next(0,3);

            if(check == Full_Time)
            {
                empHrs = 8;
            }
            else if(check == Part_Time) 
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
        empWage = empHrs * EmpWagePerHr;
        Console.WriteLine("Emp wage: " + empWage);
        }

    }
}
