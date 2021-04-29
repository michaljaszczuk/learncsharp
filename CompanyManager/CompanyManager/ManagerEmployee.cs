using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public class Manager : Employee
    {
        public override void CalculateSalary()
        {
            int quarterlyBonus = 1000;
            double departmentComission = quarterlyBonus * 2.3;
            double hourly = 20;
            double salaryAnnualy = 2 * hourly + 3 * quarterlyBonus + departmentComission + 1000;
            Console.WriteLine(salaryAnnualy);
        }

        public override void GetEmployeeData()
        {
            if (IsEmployed != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This employe no longer works here");
                Console.ResetColor();
            }
            Console.WriteLine("ID: " + ID + "Name: " + Name + "Position: Manager Employee");
        }
    }
}
