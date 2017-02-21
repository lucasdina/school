using System;
using static System.Console;

namespace projectedRaises
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter the salaries of 3 of your employees");
            WriteLine("Employee 1");
            double emp0 = Convert.ToDouble(ReadLine());
            WriteLine("Employee 2");
            double emp1 = Convert.ToDouble(ReadLine());
            WriteLine("Employee 3");
            double emp2 = Convert.ToDouble(ReadLine());
            double emp0f = emp0 + (emp0 * .04);
            double emp1f = emp1 + (emp1 * .04);
            double emp2f = emp2 + (emp2 * .04);
            WriteLine("The first employee is making {0} this year and is projected to make {1} next year.", emp0, emp0f);
            WriteLine("The first employee is making {0} this year and is projected to make {1} next year.", emp1, emp1f);
            WriteLine("The first employee is making {0} this year and is projected to make {1} next year.", emp2, emp2f);


        }
    }
}
