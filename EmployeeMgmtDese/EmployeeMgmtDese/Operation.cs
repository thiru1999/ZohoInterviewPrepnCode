using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace EmployeeMgmtDese
{
    public class Operation : IOperation
    {
        public void Adding()
        {
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Employee e = new Employee(name, gender, age);
            Program.Emplist.Add(e);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            using (Stream stream = File.Open(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml", FileMode.Create)) 
            {
                serializer.Serialize(stream, Program.Emplist);

            }
            
            /*XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");
            XmlNode root = doc.SelectSingleNode("ArrayOfEmployee");
            XmlElement employee = doc.CreateElement("Employee");
            root.AppendChild(employee);
            XmlElement names = doc.CreateElement("Name");
            names.InnerText = e.Name;
            employee.AppendChild(names);
            XmlElement genders = doc.CreateElement("Gender");
            genders.InnerText = e.Gender;
            employee.AppendChild(genders);
            XmlElement ages = doc.CreateElement("Age");
            ages.InnerText = e.Age.ToString();
            employee.AppendChild(ages);
            doc.Save(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");*/

            /*XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (Stream stream = File.Open("EmployeeDataBase.xml", FileMode.Append))
            {
                serializer.Serialize(stream, e);
            }
*/

        }

        public void Deleting(string name)
        {
            /*XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");
            XmlNode nameToDelete = doc.SelectSingleNode("ArrayOfEmployee/Employee[Name='Mani']");
            XmlNode root = doc.SelectSingleNode("ArrayOfEmployee");
            root.RemoveChild(nameToDelete);
            doc.Save(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");*/
            /*XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");

            XmlNodeList xnList = doc.SelectNodes("/ArrayOfEmployee");
            foreach(XmlNode xn in xnList)
            {
                Console.WriteLine(xn["Employee"]["Name"].InnerText);
                if (xn["Employee"]["Name"].InnerText == name)
                {
                    xn.RemoveChild(xn["Employee"]);
                }
            }
            doc.Save(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml"); 
*/
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");

            XmlNodeList xnList = doc.SelectNodes("ArrayOfEmployee/Employee");
            foreach (XmlNode xn in xnList)
            {
                if (xn["Name"].InnerText == name)
                {
                    xn.RemoveAll();

                }
            }
            doc.Save(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");


        }

        public void Updating(String editeName,string nameToChange)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");

            XmlNodeList xnList = doc.SelectNodes("ArrayOfEmployee/Employee");
            foreach (XmlNode xn in xnList)
            {
                if (xn["Name"].InnerText == nameToChange)
                {
                    xn["Name"].InnerText = editeName;


                }
            }
            doc.Save(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");
            /*XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");
            XmlNode Name = doc.SelectSingleNode("ArrayOfEmployee/Employee");
            Name.ChildNodes[0].InnerText = name;
            *//*          Console.WriteLine(Name.ChildNodes[0].InnerText);
                        Console.WriteLine(Name.ChildNodes[1].InnerText);
                        Console.WriteLine(Name.ChildNodes[2].InnerText);
            *//*
            doc.Save(@"C:\Users\Z004K1SD\source\repos\EmployeeMgmtDese\EmployeeMgmtDese\bin\Debug\EmployeeDataBase.xml");*/

        }
    }
}
