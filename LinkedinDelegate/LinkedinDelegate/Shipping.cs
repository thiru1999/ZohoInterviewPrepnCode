using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinDelegate
{
    public abstract class Shipping
    {
        public bool isHigRisk;
        abstract public void FeeCaln(decimal price, ref decimal fee);

        public static Shipping SelectDestination(string zone)
        {
            if (zone.Equals("Zone1"))
            {
                return new Zone1();
            }

            if (zone.Equals("Zone2"))
            {
                return new Zone2();
            }
            return null;
        }


        
    }
    public class Zone1:Shipping
    {
        public Zone1()
        {
            this.isHigRisk = false;
        }

        public override void FeeCaln(decimal price, ref decimal fee)
        {
            fee = price + (price * 0.25m);
        }
    }


    public class Zone2 : Shipping
    {
        public Zone2()
        {
            this.isHigRisk = true;
        }

        public override void FeeCaln(decimal price, ref decimal fee)
        {
            fee = price + (price * 0.10m);
        }
    }
}
