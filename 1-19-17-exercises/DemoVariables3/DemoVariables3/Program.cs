using System;
using static System.Console;

class demoVar3
{
    public static void Main()
    {
        WriteLine("Enter a Number");
        int value = Convert.ToInt32(ReadLine());
        bool isSixMore = 6 > value;
        WriteLine("When the value is {0}, isSixMore is {1}", value, isSixMore);
        WriteLine("Enter another Number");
        int value1 = Convert.ToInt32(ReadLine());
        bool isSixMore1 = 6 > value1;
        WriteLine("When the value is {0}, isSixMore is {1}", value1, isSixMore1);
    }
}