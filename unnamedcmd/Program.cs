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
            Console.Title = "UnnamedCMD by crosspl. & litecave.";
            string copyright = "(c) crosspl. & litecave. All rights reserved.";
            Console.WriteLine("Giving power to all systems!");
            Thread.Sleep(5000);
            Console.WriteLine(copyright);
            Program.cmd();
        }

        private static void cmd()
        {
            string copyright = "(c) crosspl. & litecave. All rights reserved.";
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
                Console.WriteLine(copyright);
                Program.cmd();
            }
            if (Answer == "github")
            {
                commands.github();
                Program.cmd();
            }
            if (Answer == "url")
            {
                Console.WriteLine("Write URL to your site");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string urlw = Console.ReadLine();
                commands.url(urlw);
#pragma warning restore CS8604 // Possible null reference argument.
            }
            if (Answer == "exit")
            {
                Environment.Exit(0);
            }
            if (Answer == "open")
            {
                Console.WriteLine("Write your apps name with path (if standartcmd command - without path)");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string appnamew = Console.ReadLine();
                    commands.open(appnamew);
#pragma warning restore CS8604 // Possible null reference argument.
            }
            if (Answer == "theme light")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                commands.clear();
                Console.WriteLine(copyright);
                Program.cmd();
            }
            if (Answer == "theme black")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                commands.clear();
                Console.WriteLine(copyright);
                Program.cmd();
            }
            else
            {
                Console.WriteLine("This command doesn't exists!");
                Program.cmd();
            }
        }
    }
}
