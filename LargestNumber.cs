using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class LargestNumber
    {
        public static void largeNumber()
        {
            int x;
            int y;
            int z;
            Console.WriteLine("Enter First Number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            z = Convert.ToInt32(Console.ReadLine());
            int large = (x > y) ? (x > z ? x : z) : (y > z ? y : z);
            Console.WriteLine("The maximum number is " + large);

        }
    }
}
