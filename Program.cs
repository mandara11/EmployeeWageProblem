namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Program");
            EmployeeCheck.CheckEmployeeAttendence(); //UC1
            DailyEmpWage.CheckEmployeeAttendence();  //UC2
            PartTime.AddPartTime();  //UC3
            PartTimeSwitch.AddPartTimeSwitch(); //UC4
        }
    }
}