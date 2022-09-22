using System;
public class Employee
{
    public string alias;
    public string name;
    Employee e1 = new Employee("ee", "ece");

    public Employee(string name, string alias)
    {
        // Use this to qualify the members of the class
        // instead of the constructor parameters.
        e1.name = name;
        e1.alias = alias;
    }
}
public class Mains
{
    public static void Main()
    {
        Employee e1 = new Employee("dfdfc", "efef");
        Console.WriteLine(e1.name);

    }
}