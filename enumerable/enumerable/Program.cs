using System;
namespace enumerator
{
    public enum employeetype
    {
        salesmanager = 10,
        manager,
        salesman
    };
    class Enum_check
    {
        public static void Main()
        {
            employeetype k = new employeetype();



            foreach (string e in Enum.GetNames(typeof(employeetype)))
            {
                Console.WriteLine(e);

            }

        }
    }
}



