namespace EmployeeManagement
{
    internal class EmployeeDailyWage
    {
        int WagePerHrs = 20;
        int  Hrs= 0;
        public void Wage()
        {
            int Is_Full_Time = 1;
            Random ran = new Random();
            int empcheck = ran.Next(0, 2);
            if (empcheck == Is_Full_Time) { Hrs = 8; Console.WriteLine("Employee is absent"+(WagePerHrs*Hrs)); }
            else { Console.WriteLine("Employee is absent"+(WagePerHrs*Hrs)); }

        }
        static void Main(string[] args)
        {
            EmployeeDailyWage employeeDailyWage = new EmployeeDailyWage();
            
            employeeDailyWage.Wage();
    
        }
    }
}