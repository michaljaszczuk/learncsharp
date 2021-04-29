using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    interface IEmployeeManager
    {      
        void HireEmployee();
        void FireEmployee();               
    }
    interface ISalary
    {
        void SalaryRise();
    }
}
