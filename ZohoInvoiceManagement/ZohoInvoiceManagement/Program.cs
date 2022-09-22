using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZohoInvoiceManagement.Model;
using ZohoInvoiceManagement.Controller;

namespace ZohoInvoiceManagement
{
    internal class Program
    {
        public static int CustomerId { get; set; } = 0;
        public static int InvoiceId { get; set; } = 0;
        public static int ItemId { get; set; } = 0;

        private static int dummy = 1;
        public static Dictionary<int,Customer> MappingCustIdWithCustomer=new Dictionary<int,Customer>(); //Mapping idd with Customer Class
        public static Dictionary<int, ItemContainer> MappingItemWithId = new Dictionary<int, ItemContainer>();//Mapping id with Items clkass
        public static Dictionary<int, Invoice> MappingInvoiceIdWithInvoice = new Dictionary<int, Invoice>(); //Mapping idd with Invoice Class

        public static void Main(string[] args)
        {
            ItemContainer item1 = new ItemContainer("HeadPhone", 400);
            Program.MappingItemWithId[Program.ItemId] = item1;

            ItemContainer item2 = new ItemContainer("Speaker", 1000);
            Program.MappingItemWithId[Program.ItemId] = item2;

            ItemContainer item3 = new ItemContainer("SdCard", 500);
            Program.MappingItemWithId[Program.ItemId] = item3;

            ItemContainer item4 = new ItemContainer("Battery", 6000);
            Program.MappingItemWithId[Program.ItemId] = item4;

            while (dummy == 1)
            {
                Console.WriteLine("1.Add Customer");
                Console.WriteLine("2.Add Invoice");
                Console.WriteLine("3.Add Item To Invoice");
                Console.WriteLine("4.Display All Customer Details");
                int inputResponse = int.Parse(Console.ReadLine());
                switch (inputResponse)
                {
                    case 1:
                        Console.WriteLine("Enter the customer Name :");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the customer Address :");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter the customer Phone Number :");
                        string phoneNo = Console.ReadLine();
                        Customer cust = new Customer(name, address, phoneNo);
                        Program.MappingCustIdWithCustomer[Program.CustomerId] = cust; //Mapping id with Customer
                        Console.WriteLine("Your Customer Id is " + CustomerId);
                        break;

                    case 2:
                        Console.WriteLine("1:Existing Customer");
                        Console.WriteLine("2:New Customer");
                        int choice = int.Parse(Console.ReadLine()); ;
                        if (choice == 1)
                        {
                            Console.WriteLine("Enter The CustomerId");
                            int customerIdChoice = int.Parse(Console.ReadLine());
                            AddingInvoice adding = new AddingInvoice();
                            adding.AddingInvoiceToExistingCustomer(customerIdChoice);
                            break;

                        }
                        else if (choice == 2)
                        {
                            break;

                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the InvoiceNumber");
                        int dummyInvoiceId = int.Parse(Console.ReadLine());
                        AddingItemToInvoice addExtraItem = new AddingItemToInvoice();
                        addExtraItem.AddingExtraItemToExistingInvoice(dummyInvoiceId);
                        break;
                    case 4:
                        Program.Disp(new DisplayCustoomerDetails());     //Dsiplay Customer details using Runtime Pollymorphism                                       
                        break;

                    case 5:
                        Program.Disp(new DisplayInvoiceDetails());     //Dsiplay Involice details using Runtime Pollymorphism                                       
                        break;

                }
            }

        }
        public static void Disp(IDisplayDetails display)  //Dynmaicamically caling the Display function of interface using what Class is passed as Arguement
        {
            display.Display();

        }
    }
}
