using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappUpdateEventExampleOwn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhatsappUpdate update = new WhatsappUpdate();
            Google android = new Google();
            Apple ios = new Apple();
            update.Clicking += android.AndroidWhatsappUpdate;
            update.Clicking += ios.IosWhatsappUpdate;
            update.AfterDevelopmentProcessOver();
        }
    }
}
