using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMosh
{
    internal class YoutubeException:Exception
    {
        public YoutubeException(string Message,Exception innerException) : base(Message, innerException)
        {


        }
    }
}
