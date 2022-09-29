using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeProjectDay9
{
    public class EmployCondition
    {
        public static void EmployeDetail()
        {
            //Constants 
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employe is Prasent");
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }
        }
    }
}
