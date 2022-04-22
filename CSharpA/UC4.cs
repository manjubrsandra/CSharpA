using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA
{
    internal class UC4
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PRAT_TIME = 2;
        public const int EMP_RATE_HOUR = 20;
        public static void Switch()
        {
         
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            switch(num)
            {
                case IS_FULL_TIME:
                    emphrs=8;
                    break;
                case IS_PRAT_TIME:
                    emphrs = 4;
                    break;
              default:
                    emphrs=0;
                    break;
            }
            empwage= emphrs * EMP_RATE_HOUR;
            Console.WriteLine("Employee  wage is : " + empwage);
        }
    }
}
