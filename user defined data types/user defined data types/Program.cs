/*using System;
class employee:IComparable<employee>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int CompareTo(employee? other)
    {
        if (this.Id > other.Id)
        {
            return 1;

        }
        else if (this.Id > other.Id)
        {
            return -1;

        }
        else
        {
            return 0;

        }
    }
}

class implementation
{
    public static void Main()
    {   

        employee E1=new employee();
        E1.Id = 1021;
        E1.Name = "Thiru";
        employee E2=new employee();
        E2.Id = 102;
        E2.Name = "Mani";
        List<employee> instant = new List<employee>() { E1 ,E2};
        instant.Sort();
        foreach(employee Emp in instant)
        {
            Console.WriteLine(Emp.Id);
            Console.WriteLine(Emp.Name);
        }




    }
}*/



using System;
class datatimecheck
{
    public static void Main()
    {
        /*   DateTime hiredate = new DateTime(2022,09,05);
           Console.WriteLine(hiredate.GetType());*/

        string firstname = " kmar ";
        string lastname = "thirumani";


        string interpolestring = $"{firstname}{lastname}";
        Console.WriteLine(interpolestring);
        Console.WriteLine(firstname.Substring(0, 2));
        Console.WriteLine(firstname.Contains("l"));
    }
}