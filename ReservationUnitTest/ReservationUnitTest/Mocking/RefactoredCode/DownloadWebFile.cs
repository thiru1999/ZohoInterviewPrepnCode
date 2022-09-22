using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReservationUnitTest.Mocking.RefactoredCode
{
    public interface IFileDownloader
    {
        void DownloadFile(string url, string path);

    }
    internal class DownloadWebFile:IFileDownloader
    {
        
        public void DownloadFile(string url,string path)
        {
            var client = new WebClient();
            client.DownloadFile(url, path);        

        }

    }
}
