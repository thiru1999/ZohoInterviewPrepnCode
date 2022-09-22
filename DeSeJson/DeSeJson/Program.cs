using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DeSeJson
{
    internal class Program
    {
        public static string k;

        public static List<Employee> emplist = new List<Employee>();
        //public static List<Employee> Emplist
        //{
        //    get
        //    {
        //        return emplist;
        //    }
        //    set
        //    {
        //        emplist = value;
        //    }
        //}
        static void Main()
        {
            emplist = new List<Employee>() { new Employee("Thiru","Male",22),new Employee("Mani","Male",23),
            new Employee("Kumar","Male",24),new Employee("Shree","Female",23)};
            k = JsonConvert.SerializeObject(emplist);
            File.WriteAllText(@"C:\Users\Z004K1SD\source\repos\DeSeJson\DeSeJson\bin\Debug\DeSe.Json", k);
            Operation op = new Operation();
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Employee e = new Employee(name, gender, age);
            op.Adding(e);
            op.Updating("Kani", "Thiru");
            op.Deleting("Shree");
           
        }
    }
}
