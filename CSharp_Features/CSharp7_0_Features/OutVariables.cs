using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_0_Features
{
    public class OutVariablesE1Old
    {
        public void GetEmployeeDetails()
        {
            double salary;
            GetSalary(out salary);
        }

        private void GetSalary(out double salary)
        {
            salary = 10000;
        }
    }

    public class OutVariablesE1
    {
        public void GetEmployeeDetails()
        {
            GetSalary(out var salary);
            
            if(int.TryParse(GetAge(), out var age))
            {
                //Do something here
            }
        }

        private string GetAge()
        {
            return "25";
        }
        private void GetSalary(out double salary)
        {
            salary = 10000;
        }
    }

}
