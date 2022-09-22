using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSeJson
{
    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }

        public Employee(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;

        }
    }
}
