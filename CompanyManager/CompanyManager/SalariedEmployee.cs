using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public class SalariedEmployee : Employee
    {
        public override void CalculateSalary()
        {
            int quarterlyBonus = 800;
            double hourly = 20;
            double salaryAnnualy = 2 * hourly + 3 * quarterlyBonus + 1000;
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
            Console.WriteLine("ID: {0}" + "\n" +  "Name: {1}" + "\n" +  "Position: Salaried Employee");
        }
    }
}
