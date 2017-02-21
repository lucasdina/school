using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hurricane
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter the speed of the hurricane:");
            int wSpeed = Convert.ToInt32(ReadLine());
            if (wSpeed >= 74 && wSpeed <= 96)
            {
                WriteLine("Catagory 1");
            }
            else
            {
                if (wSpeed >= 96 && wSpeed <= 110)
                {
                    WriteLine("Catagory 2");
                }
                else
                {
                    if (wSpeed >= 111 && wSpeed <= 129)
                    {
                        WriteLine("Catagory 3");
                    }
                    else
                    {
                        if (wSpeed >= 130 && wSpeed <= 156)
                        {
                            WriteLine("Catagory 4");
                        }
                        else
                        {
                            if (wSpeed >= 157)
                            {
                                WriteLine("Catagory 5");
                            }
                            else
                            {
                                WriteLine("Invalid input.");
                            }
                        }
                    }
                }
            }
        }
    }
}
