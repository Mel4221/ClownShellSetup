using System;
using System.IO;
using System.Threading;

namespace ClownShellSetup
{
    public partial class Setup
    {
          private int Attempts = 1; 
         public void RunPrechecks()
        {
            if (!File.Exists("QuickTools.dll"))
            {
                try
                {
                    Console.WriteLine($"MISSING: [QuickTools.dll]");
                    Console.WriteLine($"GET: [{Tools.QuickToolsDll}]");
                    Tools.DownloadFile(Tools.QuickToolsDll, "QuickTools.dll");
                }
                catch(Exception ex)
                {
                    Attempts++;
                    Console.WriteLine($"FAILED TO DOWNLOAD: [QuickTools.dll] TRYING AGAIN ATTEMPS: [{Attempts}] OF [{10}]");
                    Console.WriteLine($"ERROR: [{ex.Message}]");
                    Thread.Sleep(5000);
                    this.RunPrechecks();
                    if (this.Attempts == 10) throw new Exception("MAXIMUM ATTEMPTS REACHED");
                }

            }
        }
    }
}
