using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Vowels
    {
        public static void vowels()
        {
            char x;
            Console.WriteLine("Enter a alphabet: ");
            x = Convert.ToChar(Console.ReadLine());

            if (x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U' || x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
            {
                Console.WriteLine("The alphabet is a vowel");
            }
            else if ((x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z'))
            {
                Console.WriteLine("The alphbet is a Consonant");
            }
            else
            {
                Console.WriteLine("Enter a valid alphabet");
            }

        }
    }
}
