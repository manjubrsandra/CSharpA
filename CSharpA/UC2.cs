using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA
{
    internal class UC2
    {
        public static void Wage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_HOUR = 20;
            int emphrs = 0;
            int empwage=0;
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == IS_FULL_TIME)
            {
                emphrs=8;
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
