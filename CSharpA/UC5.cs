using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA
{
    internal class UC5
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public static void Month()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalempWage = 0;

            for (int Day = 0; Day < NUM_OF_WORKING_DAYS; Day++)
            {
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalempWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
            }
            Console.WriteLine("Total empWage: " + totalempWage);
        }
    }
}
