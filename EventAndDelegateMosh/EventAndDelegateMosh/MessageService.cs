using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateMosh
{
    internal class MessageService
    {
        public void OnVideoEncodedeee(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending Message...."+e.video.Title);
        }
    }
}
