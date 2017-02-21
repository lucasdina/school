using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace checkMonth
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter the number of your birth month.");
            int month = Convert.ToInt32(ReadLine());
            if (month <=0 || month >= 13)
            {
                WriteLine("Invalid month");
            }
            else
            {
                WriteLine("{0} is a valid month", month);
            }
        }
    }
}
