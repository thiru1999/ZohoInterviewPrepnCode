using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SampleEmployeeManagementSerializationAndDeserialization
{
    public class Operation : IOperation
    {
        public void AddingLinkedList()
        {
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Employee e1 = new Employee(name, age, gender);
            SeDe.Chain.AddLast(e1);
        }
        public void Adding()
        {
            String filePath = @"C:\Users\Z004K1SD\Desktop\Sample.txt";
            using (StreamWriter sw = File.CreateText(filePath)){
                foreach(var i in SeDe.Chain)
                {
                    sw.WriteLine($"Name={i.Name} Age= {i.Age} Gender={i.Gender}");
                }

            }

        }
       
        public void Deleting(string name)
        {
            foreach(var i in SeDe.Chain)
            {
                if (i.Name == name)
                {
                    SeDe.Chain.Remove(i);
                }

            }
        }

        public void Updating(string name)
        {
            foreach (var i in SeDe.Chain)
            {
                if (i.Name == name)
                {
                    i.Name = name;
  
                }

            }
        }

        
    }
}
