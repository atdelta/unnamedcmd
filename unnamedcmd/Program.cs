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
            Console.WriteLine("Write that you want (help - for help):");
            string Answer = Console.ReadLine();
        }
    }
    
    class help
    {
        Console.WriteLine("help - your number 1 helper");
        Console.WriteLine("---------------------------");
        Console.WriteLine("exit - Exits UnnamedCMD");
        Console.WriteLine("help - shows this msg");
    }
}
