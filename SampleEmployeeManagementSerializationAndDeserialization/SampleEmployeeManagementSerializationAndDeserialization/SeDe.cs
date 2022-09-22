using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SampleEmployeeManagementSerializationAndDeserialization
{
    public class SeDe
    {
        private static LinkedList<Employee> chain { get; } = new LinkedList<Employee>();
        public static LinkedList<Employee> Chain
        {
            get
            {
                return chain;
            }
        }
        public static void Main()
        {
            /*Employee emp = new Employee("Kumar", 23, "M");
            Stream stream = File.Open("EmployeeDataBase.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, emp);
           */

            /*String filePath = @"C:\Users\Z004K1SD\Desktop";*/

            Operation op = new Operation();
            op.AddingLinkedList();
            op.AddingLinkedList();
            op.Adding();

        }
            
            
            
            
        

    }
}
