using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMosh
{
    internal class YoutubeApi
    {
        
        public string GetVideo(string search)
        {
            try
            {
                throw new Exception("internal video not Found");
            }
            catch(Exception e)
            {
                throw new YoutubeException("No video Found", e);

            }
            return "hi";

        }
    }
}
