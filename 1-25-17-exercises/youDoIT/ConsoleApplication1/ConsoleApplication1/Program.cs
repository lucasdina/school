using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(ReadLine());
            switch (year)
            {
                case 1:
                    WriteLine("Freshman");
                    break;
                case 2:
                    WriteLine("Sophmore");
                    break;
                case 3:
                    WriteLine("Junior");
                    break;
                case 4:
                    WriteLine("Senior");
                    break;
                default:
                    WriteLine("Invalid Year");
                    break;


            }
        }
    }
}
