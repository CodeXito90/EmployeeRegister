using EmployeeRegister;
using System;
class Program
{
    static void Main(string[] args)
    {
        EmployeeRegistry registry = new EmployeeRegistry();
        Console.WriteLine("Welcome to the Employee Registry!");

        while (true)
        {
            Console.Write("Enter Employee Name (or type 'exit' to finish): ");
            string name = Console.ReadLine();

            if (name.ToLower() == "exit")
            {
                break;
            }

            Console.Write("Enter Employee Salary: ");
            decimal salary;

            // Kontrollerar att lönen är en siffra
            while (!decimal.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Invalid input. Please enter a valid salary:");
            }

            // Lägg till den anställda till registret
            registry.AddEmployee(name, salary);
            Console.WriteLine("Employee added!\n");
        }

        // Visa alla anställda
        registry.DisplayAllEmployees();
        Console.WriteLine("Thank you for using the Employee Registry!");
    }
}




