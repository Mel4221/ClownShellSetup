using System;
using System.IO; 

namespace ClownShellSetup
{
    class MainClass
    {
        private static string[] Args { get; set; } = new string[] { };
        private static bool IsValidInput(String path)
        {
            if (!string.IsNullOrEmpty(path) &&
                   !string.IsNullOrWhiteSpace(path) &&
                   path != "" &&
                   Directory.Exists(path))
            {
                return true;
            }
            else
            {
                Args = new string[] { };
                return false; 
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine($"WELCOME TO CLOWNSHELLSETUP!!!");
            Setup setup;
            Args = args;
            string path;
            Func<string[], string> F = (arg) => 
                {
                    if (arg.Length == 1)
                    {
                        return arg[0];
                    }
                    else
                    {
                        return Console.ReadLine();
                    }
                };
            while (true)
            {
                //path = $"/home/mel/Downloads/"; //Console.ReadLine();
                path = F(Args);
                if (path.ToLower() == "exit") break;
                if (IsValidInput(path))
                {
                    setup = new Setup(path);
                    setup.Start();
                    return;
                }
                else
                {
                    Console.WriteLine($"[{path}] IS NOT A VALID PATH TRY AGAIN");
                }
            }
        }
    }
}
