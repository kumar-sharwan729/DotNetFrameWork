using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.ConsoleKeyFolder
{
    internal class ReadKeyDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password");
            ConsoleKeyInfo ck = Console.ReadKey(true);
            string password = "";

            while (ck.Key != ConsoleKey.Enter)
            {
                
                Console.Write("#");
                password += ck.KeyChar;
                ck = Console.ReadKey(true);
            }
            Console.WriteLine("Entered Password is "+ password);
        }
    }
}
