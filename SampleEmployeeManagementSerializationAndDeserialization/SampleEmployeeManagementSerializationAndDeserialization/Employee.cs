using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable()]
public class Employee:ISerializable
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public int ?Age  { get; set; }

    public Employee(string name,int age,string gender)
    {
        Name = name;
        Gender = gender;
        Age = age;

    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Name", Name);
        info.AddValue("Gender", Gender);
        info.AddValue("Age", Age);
    }

    public Employee(SerializationInfo info, StreamingContext context)  //deserialization
    {
        Name = (string)info.GetValue("Name", typeof(string));
        Gender = (string)info.GetValue("Gender", typeof(string));
        Age = (int)info.GetValue("Age", typeof(int));

    }
}