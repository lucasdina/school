// Program asks user to enter three integers
// Program displays a message indicating whether the numbers
// are in sequential order
// in reverse order
// or in neither order
// in reverse order
// or in neither order
using System;
using static System.Console;
class DebugFour2
{
    static void Main()
    {
        WriteLine("Enter first number ");
        int num1 = Convert.ToInt32(ReadLine());
        WriteLine("Enter second number ");
        int num2 = Convert.ToInt32(ReadLine());
        WriteLine("Enter third number ");
        int num3 = Convert.ToInt32(ReadLine());
        if (num1 < num2 && num2 <= num3)
            WriteLine("Numbers are in sequential order");
        else
           if (num1 > num2 && num2 >= num3)
            WriteLine("Numbers are in reverse order");
        else
            WriteLine("Numbers are in neither sequential nor reverse order");
    }
}
