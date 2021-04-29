using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public abstract class Employee
    {        
        public abstract void CalculateSalary();
        public abstract void GetEmployeeData();
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public bool IsEmployed { get; set; }
        
    }
    
    
    
    
}
