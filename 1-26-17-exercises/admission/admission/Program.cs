using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace admission
{
    class Program
    {
        static void Main()
        {
            WriteLine("What was your GPA?");
            double gpa = Convert.ToDouble(ReadLine());
            WriteLine("What were your average test scores?");
            double ts = Convert.ToDouble(ReadLine());
            if (gpa >= 3.0 && ts >= 60)
            {
                WriteLine("You have been accepted.");
            }
            else
            {
                if (gpa <= 3.0 && ts >= 80)
                {
                    WriteLine("You have been accepted.");
                }
                else
                {
                    WriteLine("You have been denied.");
                }
            }
        }
    }
}
