using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileInfo
{
    class Program
    {
        static string Name, HairColor, EyeColor,  Height, Age;
        
        
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "5 Questions";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine(  );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          Hello! if we can have some info. We will ask you for Name, Hair Color, Eye color, Height, and Age?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                              If you are ready press enter!");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Okay so name?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Name = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thanks, " + Name + ". what about hair color?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            HairColor = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("So you have, " + HairColor + " colored hair. What about your eye color?" );
            Console.ForegroundColor = ConsoleColor.Cyan;
            EyeColor = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Okay cool, so you have " + EyeColor + " eyes. How tall are you?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Height = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ok thanks, so you are: " + Height +" tall. Cool but now for the final question, your age?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Age = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Alright, " + Age + "? I would've never guessed");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            Console.WriteLine("Thanks for your time!");
            Console.ReadLine();

        }
    }
}
