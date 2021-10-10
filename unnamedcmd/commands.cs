using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unnamedcmd
{
    internal class commands
    {
        public static void cmdhelp()
        {
            Console.WriteLine("");
            Console.WriteLine("help - your number 1 helper");
            Console.WriteLine("---------------------------");
            Console.WriteLine("github - Open's UnnamedCMD GitHub");
            Console.WriteLine("helloworld - Showing: Hello, World!");
            Console.WriteLine("exit - Exits UnnamedCMD");
            Console.WriteLine("help - shows this msg");
            Console.WriteLine("clear - clear console");
            Console.WriteLine("");
        }
        public static void github()
        {
            Process.Start("explorer.exe", "https://github.com/litecave/unnamedcmd");
            Console.WriteLine("");
        }
        public static void helloworld()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("");
        }
        public static void clear()
        {
            Console.Clear();
        }
    }
}
