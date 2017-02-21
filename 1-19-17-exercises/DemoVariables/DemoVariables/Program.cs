using System;
using static System.Console;

class demoVars
{
    static void Main()
    {
        int anInt = -123;
        uint anUnassignedInt = 567;
        WriteLine("The int {0} is assigned and the uint {1} is unassigned.", anInt, anUnassignedInt);
    }
}