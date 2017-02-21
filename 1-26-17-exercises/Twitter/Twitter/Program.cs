using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Twitter
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter a message:");
            string input = ReadLine();
            int MAX = 5;
            if (input.Length > MAX)
            {
                WriteLine("Your message is too long.");
            }
            else
            {
                WriteLine("Your message is approved.");
            }
        }
    }
}
