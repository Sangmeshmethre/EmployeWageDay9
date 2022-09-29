using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeProjectDay9
{
    public class Employerefactor
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAY = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        public static int computeEmpWage()
        {
            int empHrs = 0, totalEmphrs = 0, totalWorkingDays = 0;
            while (totalEmphrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAY)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmphrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
