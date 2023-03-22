using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class EmployeeAttendance
    {
        public static void GetAttendance()
        {
            int Is_Full_Time = 1;
            Random ran = new Random();
            int empcheck = ran.Next(0, 2);
            if (empcheck == 1) { Console.WriteLine("Employee is present"); }
            else { Console.WriteLine("Employee is absent"); }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            EmployeeAttendance.GetAttendance();
        }
    }
}
