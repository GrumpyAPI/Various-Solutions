using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int numOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfEmployees; i++)
            {
                string[] input = Console.ReadLine().Split();

                Employee employee = new Employee(input[0], double.Parse(input[1]), input[2]);

                employees.Add(employee);
            }

            employees = employees.OrderByDescending(x => x.Salary).ToList();

            double highestAverageSalary = 0;
            string highestDepartment = employees[0].Department;

            for (int i = 0; i < employees.Count; i++)
            {
                string currentDepartment = employees[i].Department;
                double currentSalary = 0;
                int departmentCounter = 0;

                for (int j = 0; j < employees.Count; j++)
                {
                    if (currentDepartment == employees[j].Department)
                    {
                        departmentCounter++;
                        currentSalary += employees[j].Salary;
                    }
                }

                double currentAverageSalary = currentSalary / departmentCounter;

                if (currentAverageSalary > highestAverageSalary)
                {
                    highestAverageSalary = currentAverageSalary;
                    highestDepartment = employees[i].Department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestDepartment}");

            foreach (var employee in employees)
            {
                if (employee.Department == highestDepartment)
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
                }
            }
        }
    }
}
