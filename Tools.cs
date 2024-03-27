using System;
using System.IO;
using System.Net;

namespace ClownShellSetup
{
    public class Tools
    {
        public const string QuickToolsDll = "https://github.com/Mel4221/QuickTools/raw/testing/bin/Release/QuickTools.dll";
        public static void GetQuickTools()
        {

        }
        public static void DownloadFile(string address, string fileName)
        {

            using (WebClient client = new WebClient())
            {
                client.UseDefaultCredentials = true;

                Uri Uri = new Uri(address);
                //.._completed = false;

               // client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
               // client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);

                client.DownloadFileAsync(Uri, fileName);
                while (client.IsBusy) { }
            }

        }

    }
}
