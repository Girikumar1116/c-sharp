using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Leapyear
    {
        public static void Leap()
        {
            int year;
            Console.WriteLine("Enter a year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) ||
                (year % 400 == 0))
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Non leap year");
        }
    }
}
