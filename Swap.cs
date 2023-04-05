using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Swap
    {
        public static void swap()
        {
            int temp;
            int a = 10;
            int b = 20;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
