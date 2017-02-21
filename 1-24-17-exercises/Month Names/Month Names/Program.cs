using System;
using static System.Console;

namespace Month_Names
{
    class Program
    {
        enum months
        { January = 1, February, March, April, May, June, July, August, September, October, November, December }
        static void Main()
        {
            WriteLine("Enter the number of the month");
            int monthNum = Convert.ToInt32(ReadLine());
            WriteLine("The name of month {0} is {1}", monthNum, (months)monthNum);   
        }
    }
}
