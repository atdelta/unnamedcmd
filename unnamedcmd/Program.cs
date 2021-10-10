// Wrote in VS2022 Prev4 and GitHub.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unnamedcmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giving power to all systems!");
            Thread.Sleep(5000);
            Program.cmd();
        }

        private static void cmd()
        {
            Console.WriteLine("Insert command (help - for help):");
            string Answer = Console.ReadLine();
            if (Answer == "help")
            {
                commands.cmdhelp();
                Console.WriteLine("");
                Program.cmd();
            }
            if (Answer == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("This command doesn't exists!");
                Console.WriteLine("");
                Program.cmd();
            }
        }
    }
}
