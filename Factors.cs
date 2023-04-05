using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Factors
    {

        public static void factors()
        {
            String val;
            Console.WriteLine("Enter a integer:");
            val = Console.ReadLine();
            int N = Convert.ToInt32(val);
            for (int i = 2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N = N % i;
                }
            }
            if (N > 2)
                Console.WriteLine(N);
        }
    }
}
