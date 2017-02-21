using System;
using static System.Console;

namespace greenvilleRevenue
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter the number of contestants from last year:");
            int lastY = Convert.ToInt32(ReadLine());
            WriteLine("Enter the number of contestants from this year:");
            int thisY = Convert.ToInt32(ReadLine());
            int lastM = lastY * 25;
            int thisM = thisY * 25;
            WriteLine("Last year, there were {0} contestants and you recieved {1}. \nThis year, there were {2} contestants and you received {3}.", lastY, lastM.ToString("C"), thisY, thisM.ToString("C"));
            if (thisM > lastM)
                {
                WriteLine("You surpassed last years revenue.");
            }
            else
            {
                WriteLine("You did not surpass last years revenue.");
            }
        }


    }
}
