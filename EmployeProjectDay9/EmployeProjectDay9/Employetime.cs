using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeProjectDay9
{
    public  class Employetime
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOURS = 20;
        public static void EmployeTime()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if(empCheck == IS_FULL_TIME)
                {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
