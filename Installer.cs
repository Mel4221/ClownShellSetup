using System;
using QuickTools.QIO; 
using QuickTools.QCore;

namespace ClownShellSetup
{
    public class Installer
    {
        public string Path { get; set; } = String.Empty; 


        internal void Install(string path)
        {
            this.Path = path;
            Get.Pink($"Working...");
            BinDownloader bin = new BinDownloader();
            bin.AllowDeubbuger = true;
            bin.OutPutPath = this.Path;
            bin.DownloadSources();
            bin.Load();
            bin.DownloadPackage($"ClownShell");
        }
    }
}
