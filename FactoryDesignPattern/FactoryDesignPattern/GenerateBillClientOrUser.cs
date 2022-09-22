using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class GenerateBillClientOrUser
    {
        public static void Main()
        {
            string planName = Console.ReadLine();
            GetPlanFactory plan = new GetPlanFactory();
            IgetRate catches= plan.GetPlan(planName);
            int billAmount=catches.GetRate()*10;
            Console.WriteLine(billAmount);


        }
        
    }
}
