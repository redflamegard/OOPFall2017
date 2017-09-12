using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeilApplication
{
    class Program
    {
        static int IndexNumber;
        public static string hatType, hatColor, sweatShirtColor, sneakerColor, saying;




        static void Main()
        {
            int[] numbers =  { 1, 2, 3, 4, 5};
            string[] hatType =  { "Top Hat", "Ball Cap", "Beanie", "Fiedora" };
            string[] Color =  { "Blue", "Black", "Grey", "White" };
           
            




     
        }



        void Speak()
        {
            string[] Saying = { "Hey there!", "Look at me I am Neil", "What a nice day to be a Neil", "Top of the morning to you" };
            Random ran = new Random();
            IndexNumber = ran.Next(Saying.Length);
            Console.WriteLine("Neil: {1}" , Saying[IndexNumber]);
            Console.ReadLine();

        }

        void Sit()
        {


        }
        void Flee()
        {


        }
        void Eat()
        {


        }
    }
}
