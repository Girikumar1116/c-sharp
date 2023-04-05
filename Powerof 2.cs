using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Powerof2
    {

        public  void power()
        {
            string val;
            Console.Write("enter a integer:");
            val = Console.ReadLine();
            int N = Convert.ToInt32(val);
            if (N < 0 || N > 32)
                Console.WriteLine("Give the number between 1 to 31");
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
        }
    }
}
