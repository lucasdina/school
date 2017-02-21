using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace youDoIT_1
{
    class Program
    {
        static void Main()
        {
            
            int num1, num2, num3;
            WriteLine("Enter three interger:");
            num1 = Convert.ToInt32(ReadLine());
            num2 = Convert.ToInt32(ReadLine());
            num3 = Convert.ToInt32(ReadLine());
            if (num1 == num2)
                if (num1 == num3)
                    WriteLine("All three numbers are equal");
            else
                WriteLine("First two numbers are equal");
            if (num1 == num3)
                WriteLine("First and Last are equal");
            else
                if (num2 == num3)
                WriteLine("The last two are equal");
            else
                WriteLine("No two numbers are equal");
            
                  
        }
    }
}
