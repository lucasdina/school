using System;
using static System.Console;

namespace Month_Names
{
    class Program
    {
        enum months
        { Mercury = 1, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto }
        static void Main()
        {
            WriteLine("Enter the number of the planet (There are nine!!!)");
            int monthNum = Convert.ToInt32(ReadLine());
            WriteLine("The name of planet {0} is {1}", monthNum, (months)monthNum);
        }
    }
}
