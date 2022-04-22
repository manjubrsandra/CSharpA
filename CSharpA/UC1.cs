using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA
{
    internal class UC1
    {
        public static void Attendence()
        {
            int IS_FULL_TIME = 1;
            Random obj= new Random();
            int num= obj.Next(0,2);
            if(num == IS_FULL_TIME)
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
