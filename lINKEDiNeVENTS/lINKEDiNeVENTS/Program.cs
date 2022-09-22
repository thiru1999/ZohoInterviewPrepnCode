//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lINKEDiNeVENTS
//{
//    public  delegate void MyBankDelegate(int amount,ref int total);
//    internal class Program
//    {
//        public static event MyBankDelegate Account;
//        static void Main(string[] args)
//        {
//            Bank B = new Bank();
//            int Amount = 0;
//            int total = 0;
//            Program.Account += B.Adding;
//            Program.Account += B.Print;
//            do
//            {
//                Console.WriteLine("Enter the Amount");
//                Amount = int.Parse(Console.ReadLine());

                
//                //if (total < 500)
//                //{
//                //    Account -= B.Print;

//                //}
//                Account(Amount, ref total);



//            }
//            while (true);
            

//        }

//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lINKEDiNeVENTS
{
    public delegate void MyBankDelegate(int amount, ref int total);
    internal class Program
    {
        public static event MyBankDelegate Account;
        static void Main(string[] args)
        {
            Bank B = new Bank();
            int Amount = 0;
            int total = 0;
            Program.Account += (int amount, ref int total2) => {
                total += amount;
                Console.WriteLine("The Balance Amount is" + total2);
            };
            Program.Account += (int amount, ref int total2) =>
            {
                if (total > 500)
                {
                    Console.WriteLine("Savings Reached");
                }
            };
            do
            {
                Console.WriteLine("Enter the Amount");
                Amount = int.Parse(Console.ReadLine());


                //if (total < 500)
                //{
                //    Account -= B.Print;

                //}
                Account(Amount, ref total);



            }
            while (true);


        }

    }
}
