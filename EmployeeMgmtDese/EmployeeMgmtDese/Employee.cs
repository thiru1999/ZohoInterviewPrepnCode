using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace EmployeeMgmtDese
{
    /*[Serializable()]*/

    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public Employee()
        {
                
        }

        public Employee(string name,string gender,int age)
        {
            Name = name;
            Gender = gender;
            Age = age;

        }

        /*public void GetObjectData(SerializationInfo info)
        {
            info.AddValue("Name", Name);
            info.AddValue("Gender", Gender);
            info.AddValue("Age", Age);
        }

        public Employee(SerializationInfo info)  //deserialization
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Gender = (string)info.GetValue("Gender", typeof(string));
            Age = (int)info.GetValue("Age", typeof(int));

        }*/
    }
}
