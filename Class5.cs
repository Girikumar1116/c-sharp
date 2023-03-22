
namespace EmployeeManagement
{
    internal class EmpWageMonthlyCondition
    {
        const int Is_FullTime = 1;
        const int Is_PartTime = 2;
        const int Emp_Rate_Per_Hour = 20;
        const int Working_days = 20;
        const int Max_hours = 100;
        public static void Wages_For_Month()
        {
            int emp_Wage = 0;
            int emp_Hrs = 0;
            int total_emp_wage = 0;
            int No_Of_Hrs = 0;
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
                No_Of_Hrs += emp_Hrs;
                if (No_Of_Hrs != 100)
                {
                    emp_Wage = emp_Hrs * Emp_Rate_Per_Hour;
                    total_emp_wage += emp_Wage;
                }
                else { break; }
            }
            Console.WriteLine("emp salary" + total_emp_wage);
        }
        static void Main(string[] args)
        {

            EmpWageMonthlyCondition.Wages_For_Month();
        }
    }
}

