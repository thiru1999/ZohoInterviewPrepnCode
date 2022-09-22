﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ReservationUnitTest.Mocking.RefactoredCode;

namespace ReservationUnitTest.Mocking
{
    public class InstallerHelper
    {
        private IFileDownloader _FileDownloader;

        private string _setupDestinationFile;
        public InstallerHelper(IFileDownloader fileDownloader)
        {
            _FileDownloader = fileDownloader;


        }

        public bool DownloadInstaller(string customerName, string installerName)
        {
            try
            {
                _FileDownloader.DownloadFile(
                    string.Format("http://example.com/{0}/{1}",
                        customerName,
                        installerName),
                    _setupDestinationFile);

                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}
