using System;
using static System.Console;

namespace dollars
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter your money:");
            int dollars = Convert.ToInt32(ReadLine());
            int twenties = dollars / 20;
            int tens = (dollars - (twenties * 20)) / 10;
            int fives = (dollars - (twenties * 20) - (tens * 10)) / 5;
            int ones = (dollars - (twenties * 20) - (tens * 10) - (fives * 5));
            WriteLine("With {0}, you would have {1} twenties, {2} in tens, {3} in fives, and {4} in ones.", dollars, twenties, tens, fives, ones);


            /*int twenties, tens, fives;
            twenties = dollars / TWENTIES;
            dollars -= twenties * TWENTIES;
            tens = dollars / TENS;
            dollars -= tens * TENS;
            fives = dollars / FIVES;
            dollars -= fives * FIVES;
            */
        }
    }
}
