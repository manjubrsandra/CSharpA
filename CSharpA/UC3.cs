using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA
{
    internal class UC3
    {
        public static void Parttime()
        {
            int IS_FULL_TIME = 1;
            int IS_PRAT_TIME = 2;
            int EMP_RATE_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            if (num == IS_FULL_TIME)
            {
                emphrs=8;
            }
            else if (num == IS_PRAT_TIME)
            {
                emphrs = 4;
            }
            else
            {
                emphrs = 0;
            }
            empwage= emphrs * EMP_RATE_HOUR;
            Console.WriteLine("Employee  wage is : " + empwage);
        }
    }
}
