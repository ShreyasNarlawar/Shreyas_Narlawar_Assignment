using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "John", Salary = 60000 },
            new Employee { Id = 2, Name = "Sam", Salary = 40000 }
        };

        var result = employees.Where(e => e.Salary > 50000);

        foreach (var emp in result)
        {
            Console.WriteLine(emp.Name + " - " + emp.Salary);
        }
    }
}
