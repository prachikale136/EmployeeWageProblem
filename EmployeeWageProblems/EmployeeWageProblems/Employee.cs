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
            Random random= new Random();
            int check = random.Next(0,2);

            if(check == full_time)
            {
                Console.WriteLine("Employee is present");
            }
            else 
            {
                Console.WriteLine("Employee is absent");
            }
        }

    }
}
