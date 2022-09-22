using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class GetPlanFactory
    {
        public IgetRate GetPlan(string PlanName)
        {
            if (PlanName.Equals("A"))
            {
                return new A();
            }
            if (PlanName.Equals("B"))
            {
                return new B();
            }
            return null;

        }

    }
}
