using System;
using static System.Console;

namespace hoursAndMinutes
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter how many minutes you worked today.");
            int wmin = Convert.ToInt32(ReadLine());
            int hours = wmin / 60;
            int mins = wmin % 60;
            WriteLine("You worked {0} hours and {1} minutes.", hours, mins);

        }
    }
}
