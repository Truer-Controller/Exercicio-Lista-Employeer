using System;
using System.Collections.Generic;
using System.Globalization;
namespace TreinoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered: ");
            int numberRegisterEmployee = int.Parse(Console.ReadLine());
            List<Employees> employeesListInformation = new List<Employees>();
            
            for(int i = 0; i < numberRegisterEmployee; i++)
            {
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("ID: ");
                int idEmployee = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();
                Console.Write("Salary: ");
                double salaryEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                employeesListInformation.Add(new Employees(idEmployee, nameEmployee, salaryEmployee));
            }
            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int seachIdEmployee = int.Parse(Console.ReadLine());

            Employees emp = employeesListInformation.Find(x => x.IdEmployee == seachIdEmployee);
            if(emp != null)
            {
                Console.Write("Enter the percente: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employees obj in employeesListInformation)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
