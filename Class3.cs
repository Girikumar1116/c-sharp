
namespace EmployeeManagement
{
    internal class EmployeeWageSwitchcase
    {
        const int Is_FullTime = 1;
        const int Is_PartTime = 2;
        const int Emp_Rate_Per_Hour = 20;
        public static void Cases()
        {
            int emp_Wage = 0;
            int emp_Hrs = 0;
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
                default :
                        emp_Hrs = 0;
                        break;
            }
            emp_Wage = emp_Hrs * Emp_Rate_Per_Hour;
            Console.WriteLine(emp_Wage);

        }
        static void Main(string[] args)
        {
            EmployeeWageSwitchcase.Cases();


        }
    }
}
