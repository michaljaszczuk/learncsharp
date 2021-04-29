using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    abstract class Employee
    {
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected string Position { get; set; }
        protected bool IsEmployed { get; set; }
        protected int Salary { get; set; }
        public abstract void CalculateSalary();
    }
    class HourlyEmployee : Employee
    {
        public override void CalculateSalary()
        {
            const double hourly = 14.70;
            double salaryAnnualy = 2 * hourly + 1000;
        }
    }
    class SalariedEmployee : Employee
    {
        public override void CalculateSalary()
        {
            const int quarterlyBonus = 800;
            const double hourly = 20;
            double salaryAnnualy = 2 * hourly + 3 * quarterlyBonus + 1000;
        }
    }
    class Manager : Employee
    {
        public override void CalculateSalary()
        {
            const int quarterlyBonus = 1000;
            const double departmentComission = quarterlyBonus * 2.3;
            const double hourly = 20;
            double salaryAnnualy = 2 * hourly + 3 * quarterlyBonus + departmentComission + 1000;
        }
    }
    class Executive : Employee
    {
        public override void CalculateSalary()
        {
            const int quarterlyBonus = 5000;
            const double departmentComission = quarterlyBonus * 7.8;
            const double hourly = 38;
            double salaryAnnualy = 2 * hourly + 3 * quarterlyBonus + departmentComission + 1000;
        }
    }
}
