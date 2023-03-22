

namespace EmployeeManagement
{
    public  class EmployeePartTimeWage
    {
        public static void PartTime()
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int emp_Rateper_Hour = 20;
            int empHrs = 0;
            int emp_Wage = 0;
            Random r = new Random();
            int empCheck = r.Next(0, 3);
            if (empCheck == Is_Full_Time ) { empHrs = 8;}
            else if(empCheck == Is_Part_Time) { empHrs = 4; }
           
            emp_Wage = empHrs * emp_Rateper_Hour;
            Console.WriteLine(emp_Wage);

        }
        static void Main(string[] args)
        {
            EmployeePartTimeWage.PartTime();
           

        }
    }
}
