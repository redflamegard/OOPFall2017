using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static string name = "Corey";
        static void Main()
        {
            
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello what is your name?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            name = Console.ReadLine();
         
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( );
            Console.WriteLine("Hello " + "{0}", name );

            Console.Title = name;
            Console.ReadLine();
        }
    }
}
