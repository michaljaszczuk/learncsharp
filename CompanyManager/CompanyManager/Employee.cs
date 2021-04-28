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
        public abstract void CalculateSalary();
        
    }

    class HourlyEmployee : Employee
    {
        public override void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }

    class SalariedEmployee : Employee
    {
        public override void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Manager : Employee
    {
        public override void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Executive : Employee
    {
        public override void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
