using System;
using static System.Console;

namespace milesToKilometers
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter the number of miles you would like to convert.");
            double miles = Convert.ToDouble(ReadLine());
            double kilometers = miles * 1.6;
            WriteLine("{0} miles is equal to {1} kilometers.", miles, kilometers);
        }
    }
}
