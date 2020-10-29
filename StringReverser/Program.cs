using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverser
{
    class Program
    {
        private static void Dialog()
        {
            Console.Title = "String Reverser ABCD | DCBA";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter Text to reverse ");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("With Array Reverse :");
            string rlta = Reverse.executeWithArrayReverse((Console.ReadLine()));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reversed String = " + rlta);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Do you want try again ? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("For Yes = y For No = Press any Key ");
            Console.ResetColor();
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                Dialog();
            }
            else
            {
                Environment.Exit(0);
            }
            

        }
        static void Main(string[] args)
        {
            Dialog();
        }
    }
}
