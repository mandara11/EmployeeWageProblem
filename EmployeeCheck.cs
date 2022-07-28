using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public static class EmployeeCheck
    {
        public static void CheckEmployeeAttendence()
        {
            int IS_FULL_TIME = 1;
            Random obj = new Random();
            int empCheck = obj.Next(2);
            if(empCheck==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
