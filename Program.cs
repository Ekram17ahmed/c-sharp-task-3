using System;

class Employee
{
    public int Id;
    public string Name;
    public double Salary;

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
    }
}

class Program
{
    static Employee[] employees = new Employee[10];
    static int count = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1 - Add Employee");
            Console.WriteLine("2 - Get All Employees");
            Console.WriteLine("3 - Update Employee");
            Console.WriteLine("4 - Get Employee By ID");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    GetAllEmployees();
                    break;
                case "3":
                    UpdateEmployee();
                    break;
                case "4":
                    GetEmployeeById();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddEmployee()
    {
        if (count >= employees.Length)
        {
            Console.WriteLine("Employee list is full.");
            return;
        }

        Employee emp = new Employee();

        Console.Write("Enter ID: ");
        emp.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        emp.Salary = double.Parse(Console.ReadLine());
        Console.Clear();

        employees[count] = emp;
        count++;

        Console.WriteLine("Employee added successfully.");
    }

    static void GetAllEmployees()
    {
        Console.WriteLine("\nAll Employees:");
        for (int i = 0; i < count; i++)
        {
            employees[i].Display();
        }
    }

    static void UpdateEmployee()
    {
        Console.Write("Enter ID of employee to update: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            if (employees[i].Id == id)
            {
                Console.Write("Enter new name: ");
                employees[i].Name = Console.ReadLine();

                Console.Write("Enter new salary: ");
                employees[i].Salary = double.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Employee updated successfully.");
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }

    static void GetEmployeeById()
    {
        Console.Write("Enter ID to search: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            if (employees[i].Id == id)
            {
                employees[i].Display();
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }
}