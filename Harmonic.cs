using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Harmonic
    {
        public static void harmonics()
        {
            double result = 0;
            String val;
            Console.Write("Enter integer:");
            val = Console.ReadLine();
            int N = Convert.ToInt32(val);
            if (N == 0)
                Console.WriteLine("Not possible");
            else
            {
                for (float i = 1; i <= N; i++)
                {
                    result += 1 / i;
                }
                Console.WriteLine(result);
            }
        }
    }
}
