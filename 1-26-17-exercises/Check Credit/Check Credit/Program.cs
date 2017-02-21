using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Check_Credit
{
    class Program
    {
        static void Main()
        {
            WriteLine("How much is the item you are trying to purchase?");
            int cost = Convert.ToInt32(ReadLine());
            if (cost >= 0 && cost <= 5000)
            {
                WriteLine("Approved");
            }
            else
            {

                if (cost < 0)
                {
                    WriteLine("Invalid Price");
                }
                else
                    WriteLine("Denied");

            }
        }
    }
}
