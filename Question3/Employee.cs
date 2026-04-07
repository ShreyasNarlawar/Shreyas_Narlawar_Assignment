using System;

public class Employee
{
    private int id;
    private string name;
    private double salary;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value > 0)
                salary = value;
            else
                Console.WriteLine("Salary must be greater than 0");
        }
    }
}
