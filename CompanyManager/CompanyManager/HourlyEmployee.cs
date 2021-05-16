using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public class HourlyEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double hourly = 14.70;
            double salaryAnnualy = 2 * hourly + 1000;
            Console.WriteLine("Salary: " + salaryAnnualy);
        }

        public override void GetEmployeeData()
        {
            if (IsEmployed != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This employee no longer works here");
                Console.ResetColor();
            }
            Console.WriteLine("ID: " + ID + "\n" + "Name: " + Name + "\n" +  "Position: Hourly Employee");
        }



    }

    
    
}
