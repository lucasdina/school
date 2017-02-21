using System;
using static System.Console;

namespace carRental
{
    class Program
    {
        static void Main()
        {
            WriteLine("How many miles did you drive in your rental car?");
            double milest = Convert.ToDouble(ReadLine());
            WriteLine("How many days did you rent your car?");
            double dayst = Convert.ToDouble(ReadLine());
            double total = (dayst * 20) + (milest * .25);
            WriteLine("Your total cost will be {0}", total.ToString("C"));

        }
    }
}
