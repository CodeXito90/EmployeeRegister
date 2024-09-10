using System;
//Valde att skapa 2 klasser för uppgiften, en för Anställda och en för registret. Detta klass innehåller
//anställdas namn och lön + metoden som skriver ut antälldas info!
class Employee
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

//I den här klassen innehåller vår privat lista av anställda som lagras + AddEmployee metod som 
//lägger till anställda i registeret och vår metod som skriver ut info till consolen

class EmployeeRegistry
{
    // Lista för att spara anställda
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




