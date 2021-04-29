using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public class Executive : Employee
    {
        public override void CalculateSalary()
        {
            int quarterlyBonus = 5000;
            double departmentComission = quarterlyBonus * 7.8;
            double hourly = 38;
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
            Console.WriteLine("ID: " + ID + "Name: " + Name + "Position: Executive Employee");
        }
    }
}
