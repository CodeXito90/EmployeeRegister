﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class Employee
    {

        public string Name { get; set; }
        public decimal Salary { get; set; }

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
