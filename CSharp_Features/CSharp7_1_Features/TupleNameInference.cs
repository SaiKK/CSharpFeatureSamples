using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp7_1_Features
{
    public class TupleNameInference
    {
        public void TupleNameExample_7_0()
        {
            string Name = "Sai";
            int EmpID = 100;

            var sampleTuple = (Name, EmpID);

            //Console.WriteLine(sampleTuple.Item1);
            //Console.WriteLine(sampleTuple.Item2);
        }

        public void TupleNameExample_7_0_WithName()
        {
            string Name = "Sai";
            int EmpID = 100;

            var sampleTuple = (EmployeeName:Name, EmployeeID:EmpID);

            Console.WriteLine(sampleTuple.EmployeeName);
            Console.WriteLine(sampleTuple.EmployeeID);
        }

        public void TupleNameExample_7_1_FieldInference()
        {
            string Name = "Sai";
            int EmpID = 100;

            var sampleTuple = (Name, EmpID);

            Console.WriteLine(sampleTuple.Name);
            Console.WriteLine(sampleTuple.EmpID);

        }
        string Name { get; set; } = "Sai";
        int EmpID { get; set; } = 100;
        public void TupleNameExample_7_1_PropertyInference()
        {
            var sampleTuple = (Name, EmpID);

            Console.WriteLine(sampleTuple.Name);
            Console.WriteLine(sampleTuple.EmpID);
        }

        public void TupleNameExample_7_1_ObjectTypeInference()
        {
            Employee employee = new Employee() { Name = "Sai", EmpID = 100 };
            var sampleTuple = (employee.Name, employee.EmpID);

            Console.WriteLine(sampleTuple.Name);
            Console.WriteLine(sampleTuple.EmpID);
        }

        public void TupleNameExample_7_1_NullTypeInference()
        {
            Employee employee = null;
            var sampleTuple = (employee?.Name, employee?.EmpID);

            Console.WriteLine(sampleTuple.Name); //null
            Console.WriteLine(sampleTuple.EmpID); //null
        }

        public void TupleNameExample_7_1_ValueInference()
        {
            Employee employee = null;
            var sampleTuple = ("Sai", employee?.EmpID);

            Console.WriteLine(sampleTuple.Item1); //Sai
            Console.WriteLine(sampleTuple.EmpID); //null
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int EmpID { get; set; }
    }
}
