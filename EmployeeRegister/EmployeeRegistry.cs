using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class EmployeeRegistry
    {
        private List<Employee> employeeList = new List<Employee>();

        // Metod för att lägga till en anställd till listan
        public void AddEmployee(string name, decimal salary)
        {
            employeeList.Add(new Employee(name, salary));
        }

        // Metod för att visa alla anställda
        public void DisplayAllEmployees()
        {
            Console.WriteLine("\nEmployee Register:");
            foreach (Employee emp in employeeList)
            {
                emp.DisplayInfo();
            }
        }
    }
}
