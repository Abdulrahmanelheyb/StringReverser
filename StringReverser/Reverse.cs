using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringReverser
{
    public class Reverse
    {
        public static string executeWithArrayReverse(string text)
        {
            Stopwatch ws = new Stopwatch();
            ws.Start();
            var words = text.Split(' ');
            string rlt = null;
            for (int i = 0; i < words.Length; i++)
            {
                char[] chrs = words[i].ToCharArray();
                for (int j = (chrs.Length - 1); j >= 0; j--)
                {
                    rlt += chrs[j];
                }
                rlt += " ";
            }

            ws.Stop();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Watch Time is : " + ws.Elapsed.ToString());
            Console.ResetColor();
            return rlt;
        }
    }
}
