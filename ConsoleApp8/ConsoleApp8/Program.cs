using System;

public class BaseClass
{
    int num;

    public BaseClass()
    {
        Console.WriteLine("in BaseClass()");
    }

    public BaseClass(int i)
    {
        num = i;
        Console.WriteLine("in BaseClass(int i)");
    }

    public int GetNum()
    {
        return num;
    }
}

public class DerivedClass : BaseClass
{
    // This constructor will call BaseClass.BaseClass()
    public DerivedClass() : base(10)
    {
        Console.WriteLine("eknfkfn");
    }

    // This constructor will call BaseClass.BaseClass(int i)
    public DerivedClass(int i) 
    {
        Console.WriteLine("eknfkfn");
    }

    static void Main()
    {
        DerivedClass md = new DerivedClass();
        
    }
}
/*
Output:
in BaseClass()
in BaseClass(int i)
*/