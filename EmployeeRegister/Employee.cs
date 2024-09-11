using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class Employee
    {

        public string Name;
        public decimal Salary;
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name:\t{Name}\tSalary:\t{Salary}");
        }
    }
}
