using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeProjectDay9
{
    public  class EmployeworkingUC6
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_INT_MONTH = 10;
        public static void EmployeWorking()
        {
            //variable
            int empHrs = 0, totalEmpHours = 0, totalWorkingdays = 0;
            //Compution 
            while (totalEmpHours <= MAX_HRS_INT_MONTH && totalWorkingdays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingdays++;
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
                totalEmpHours += empHrs;
                Console.WriteLine("Day :" + totalWorkingdays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }

    }
}

