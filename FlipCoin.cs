using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class FlipCoin
    {
        public static void Flip()
        {
            Random random = new Random();
            int coin = random.Next(1, 3);
            int flip = random.Next(1, 11);
            if (coin == 1)
            {
                double percent = ((double)flip * 100) / 10;
                Console.WriteLine("Its Heads and percentage of heads is: " + percent + "%");
            }
            else
            {
                double percent = ((double)flip * 100) / 10;
                Console.WriteLine("Its Tails and percentage of tails is: " + percent + "%");

            }
        }
    }
}
