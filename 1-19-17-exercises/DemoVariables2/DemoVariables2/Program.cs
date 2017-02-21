using System;
using static System.Console;


class demoVars2
{
    static void Main()
    {
        WriteLine("Enter two variables");
        int val1 = Convert.ToInt32(ReadLine()), val2 = Convert.ToInt32(ReadLine()), sum, diff, prod, quot, rem;
        sum = val1 + val2;
        diff = val1 - val2;
        prod = val1 * val2;
        quot = val1 / val2;
        rem = val1 % val2;
        WriteLine("The sum of the two variables is {0}", sum);
        WriteLine("The difference between the two variables is {0}", diff);
        WriteLine("The product of the two variables is {0}", prod);
        WriteLine("The remainder of the two variables is {0}", rem);
        WriteLine("The quotient of the two variables is {0}", quot);

    }
}