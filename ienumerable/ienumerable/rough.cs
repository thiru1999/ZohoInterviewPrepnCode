//using System;
//using System.Collections.Generic;
//using System.Collections;
//namespace GenericIListInterfaceExample
//{
//    class Employee
//    {
//        public string Name { get; set; } = "X";
//        public string Designation { get; set; } = "Staff";
//        public int Salary { get; set; } = 5000;
//        public override string ToString()
//        {
//            return $"Name: {Name}, Designation: {Designation}, salary: {Salary}";
//        }
//        public override bool Equals(object obj)
//        {
//            Employee o = (Employee)obj;
//            return Name.Equals(o.Name);
//        }
//    }

//    class EmpList<Employee> : IList<Employee>
//    {
//        int cnt = 0;
//        Employee[] staff = new Employee[10];
//        public IEnumerator<Employee> GetEnumerator()
//        {
//            throw new InvalidOperationException("Employee List is currently not implementing its own enumerator");
//        }
//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            throw new InvalidOperationException("Employee List is currently not implementing its own enumerator");
//        }
//        public void DisplayList()
//        {
//            for (int i = 0; i < cnt; i++)
//                Console.WriteLine(staff[i]);
//        }

//        public void Add(Employee e)
//        {
//            if (cnt < 10)
//            {
//                staff[cnt] = e;
//                cnt++;
//            }
//        }

//        public void Clear()
//        {

//            cnt = 0;
//        }

//        public int Count
//        {
//            get
//            {
//                return cnt;
//            }
//        }

//        public bool IsFixedSize
//        {
//            get
//            {
//                return true;
//            }
//        }
//        public bool IsReadOnly
//        {
//            get
//            {
//                return false;
//            }
//        }

//        public Employee this[int index]
//        {
//            get
//            {
//                return staff[index];
//            }
//            set
//            {
//                staff[index] = value;
//            }
//        }
//        public bool Contains(Employee ob)
//        {
//            for (int i = 0; i < cnt; i++)
//            {
//                if (staff[i].Equals(ob))
//                    return true;
//            }
//            return false;
//        }
//        public int IndexOf(Employee ob)
//        {
//            for (int i = 0; i < cnt; i++)
//            {
//                if (staff[i].Equals(ob))
//                    return i;
//            }
//            return -1;
//        }
//        public void Insert(int index, Employee ob)
//        {
//            if ((cnt + 1 <= staff.Length) && (index >= 0) && (index < cnt))
//            {
//                cnt++;
//                for (int i = cnt - 1; i > index; i--)
//                {
//                    staff[i] = staff[i - 1];
//                }
//                staff[index] = ob;
//            }
//        }
//        public bool Remove(Employee ob)
//        {
//            int p = IndexOf(ob);
//            if (p != -1)
//            {
//                RemoveAt(p);
//                return true;
//            }
//            return false;
//        }
//        public void RemoveAt(int index)
//        {
//            if ((index >= 0) && (index < cnt))
//            {
//                for (int i = index; i < cnt; i++)
//                {
//                    staff[i] = staff[i + 1];
//                }
//                cnt--;

//            }
//        }

//        public void CopyTo(Employee[] arr, int index)
//        {
//            /*  foreach (Employee e in arr)
//                  Console.WriteLine(e);*/
//            for (int i = 0; i < cnt; i++)
//            {
//                arr[index] = staff[i];
//                index++;
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee[] arr = new Employee[]
//            {
//                new Employee{Name="A", Designation="Manager", Salary=45000},
//                new Employee{Name="B", Designation="Cleark", Salary=15000},
//                new Employee{Name="C", Designation="Programmer", Salary=35000},
//                new Employee{Name="D", Designation="Operator", Salary=25000},
//                new Employee{Name="E", Designation="Driver", Salary=15000},
//                new Employee{Name="F", Designation="Manager", Salary=50000},
//            };

//            EmpList<Employee> list1 = new EmpList<Employee>();
//            Console.WriteLine($"Count: {list1.Count}");
//            Console.WriteLine("Adding Elements...");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                list1.Add(arr[i]);
//            }
//            Console.WriteLine("List Elements...");
//            list1.DisplayList();
//            Console.WriteLine($"Count: {list1.Count}");

//            Employee e = new Employee { Name = "xyz", Designation = "Clerk", Salary = 17000 };
//            Console.WriteLine("Inserting in Employee List...");
//            list1.Insert(4, e);
//            list1.DisplayList();
//            Console.WriteLine($"Count: {list1.Count}");

//            Employee e1 = new Employee { Name = "B" };
//            Console.WriteLine("Removing an element from the list...");
//            list1.Remove(e1);
//            list1.DisplayList();
//            Console.WriteLine($"Count: {list1.Count}");

//            Console.WriteLine("Removing another element from the list...");
//            list1.RemoveAt(5);
//            list1.DisplayList();
//            Console.WriteLine($"Count: {list1.Count}");

//            Employee[] arr1 = new Employee[20];
//            for (int i = 0; i < 20; i++)
//                arr1[i] = new Employee();
//            Console.WriteLine("CopyTo method...");
//            list1.CopyTo(arr1, 7);
//            Console.WriteLine("Resulting Array...");
//            foreach (Employee ob in arr1)
//                Console.WriteLine(ob);

//            Console.WriteLine("Searching Elements in the list...");
//            Employee e3 = new Employee { Name = "A" };
//            Employee e4 = new Employee { Name = "S" };
//            Console.WriteLine($"Employee List Contains A: {list1.Contains(e3)}");
//            Console.WriteLine($"Employee List Contains S: {list1.Contains(e4)}");

//            Employee e5 = new Employee { Name = "E" };

//            Console.WriteLine($"Index of A: {list1.IndexOf(e3)}");
//            Console.WriteLine($"Index of S: {list1.IndexOf(e4)}");
//            Console.WriteLine($"Index of E: {list1.IndexOf(e5)}");

//            Console.WriteLine($"Is List Read Only: {list1.IsReadOnly}");

//            Console.WriteLine("Clearing the List...");
//            list1.Clear();
//            list1.DisplayList();
//            Console.WriteLine($"Count: {list1.Count}");
//        }
//    }
//}