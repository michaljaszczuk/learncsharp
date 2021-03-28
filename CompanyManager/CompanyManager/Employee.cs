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
}
