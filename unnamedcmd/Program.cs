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
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string Answer = Console.ReadLine();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (Answer == "help")
            {
                commands.cmdhelp();
                Program.cmd();
            }
            if (Answer == "clear")
            {
                commands.clear();
                Program.cmd();
            }
            if (Answer == "github")
            {
                commands.github();
                Program.cmd();
            }
            if (Answer == "helloworld")
            {
                commands.helloworld();
                Program.cmd();
            }
            if (Answer == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("This command doesn't exists!");
                Program.cmd();
            }
        }
    }
}
