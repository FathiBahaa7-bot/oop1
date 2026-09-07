namespace oop
{
    using System;

    public class Employee
    {
        public int Id;
        public string Name;
        public int Age;
        public int Salary;

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public class HR : Employee
    {
        public string name;
        public int age;

        public HR(string name, int age, string employeeName, int employeeAge)
            : base(employeeName, employeeAge)
        {
            this.name = name;
            this.age = age;
        }

        public void Print(string name1, string name2, int age1, int age2)
        {
            Console.WriteLine($"HR Name: {name1}");
            Console.WriteLine($"HR Age: {age1}");
            Console.WriteLine($"Employee Name: {name2}");
            Console.WriteLine($"Employee Age: {age2}");
        }
    }

    class Program
    {
        static void Main()
        {
            HR hr = new HR("Ahmed", 30, "Mohamed", 25);

            hr.Print("Ahmed", "Mohamed", 30, 25);
        }
    }
}

public class Employee
{
    private int id;
    private string name;
    private int age;
    private double salary;

    public int ID
    {
        get { return id; }
        set { if (value >= 0)  id = value; }
    }

    public string Name
    {
        get { return name; }
        set { if (value != null) name = value; }
    }

    public int Age
    {
        get { return age; }
        set { if (value >= 20) age = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { if (value >= 0) salary = value; }
    }
}


