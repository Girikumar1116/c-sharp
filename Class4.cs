

namespace EmployeeManagement
{
    internal class EmpWageMonthly
    {
        const int Is_FullTime = 1;
        const int Is_PartTime = 2;
        const int Emp_Rate_Per_Hour = 20;
        const int Working_days = 20;
        public static void Wages_For_Month()
        {
            int emp_Wage = 0;
            int emp_Hrs = 0;
            int total_emp_wage = 0;
            for (int i = 1; i <= Working_days; i++)
            {


                Random r = new Random();
                int emp_check = r.Next(0, 3);
                switch (emp_check)
                {
                    case Is_FullTime:
                        emp_Hrs = 8;
                        break;
                    case Is_PartTime:
                        emp_Hrs = 4;
                        break;
                    default:
                        emp_Hrs = 0;
                        break;
                }
                emp_Wage = emp_Hrs * Emp_Rate_Per_Hour;
                total_emp_wage += emp_Wage;
            }
            Console.WriteLine("emp salary" + total_emp_wage);
        }
        static void Main(string[] args)
        {

            EmpWageMonthly.Wages_For_Month();
        }
    }
}
