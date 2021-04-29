using System;
using System.Collections.Generic;

namespace CompanyManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \t \t * * * COMPANY MANAGER APP * * *");
            HourlyEmployee hourlyEmployee = new HourlyEmployee
            {
                ID = 1,
                Name = "John Doe",
                Position = "Hourly Employee",
                IsEmployed = true
            };
            hourlyEmployee.GetEmployeeData();
            hourlyEmployee.CalculateSalary();
        }
    }
}
