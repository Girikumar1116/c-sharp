using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class EvenOdd
    {
        public static void evenOdd()
        {
            int number;
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine(number + " is Even number");
            else
                Console.WriteLine(number + " is odd number");
        }
    }
}
