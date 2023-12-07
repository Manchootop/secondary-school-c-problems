using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_
{
    class Employee
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        public Employee()
        {
            name = "No name";
            age = 1;
        }

        public Employee(int age) : this()
        {
            this.age = age;
        }

        public Employee(string name, int age) : this(age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Department
    {
        private List<Employee> employees = new List<Employee>();
        public List<Employee> Employees { get { return employees; } set { this.employees = value; } }

        public void AddMember(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public void GetOldest()
        {
            Employee employee = this.Employees.FirstOrDefault();
            int maxAge = int.MinValue;
            foreach (Employee emp in this.Employees)
            {
                if (emp.Age > maxAge)
                {
                    maxAge = emp.Age;
                    employee = emp;
                }
            }

            Console.WriteLine($"{employee.Name} {employee.Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Department department = new Department();


            for (int i = 0; i < n; i++)
            {
                string[] emp = Console.ReadLine().Split(' ');
                Employee employee = new Employee(emp[0], int.Parse(emp[1]));

                department.AddMember(employee);

            }

            foreach (Employee employee in department.Employees)
            {
                if (employee.Age > 30)
                {
                    Console.WriteLine($"{employee.Name} - {employee.Age}");
                }
            }
        }
    }
}
