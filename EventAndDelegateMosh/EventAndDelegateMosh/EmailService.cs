using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateMosh
{
    internal class EmailService
    {
        public void OnVideoEncoded(object source,VideoEventArgs e)
        {
            Console.WriteLine("Sending Email...."+e.video.Title);
        }
    }
}
