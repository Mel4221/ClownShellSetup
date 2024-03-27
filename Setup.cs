using System;
namespace ClownShellSetup
{
    public partial class Setup
    {
        public string Path { get; set; } = String.Empty;

        public Setup(string path)
        {
            this.Path = path;     
        }

        public void Start()
        {
            this.RunPrechecks();
            //Console.Read(); 
            Installer installer = new Installer();
            installer.Install(this.Path); 
        }
    }
}
