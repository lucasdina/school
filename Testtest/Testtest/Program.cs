using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 20;
            double bankBalance = 345.67;
            score = (int)bankBalance + 2;
            //bankBalance = score + 5.2;
            WriteLine("score is {0}", score);
            WriteLine("bankBalance is {0}", bankBalance);
        }

    }
}
