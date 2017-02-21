using System;
using static System.Console;

namespace hoursAndMinutes
{
    class Program
    {
        static void Main()
        {
            WriteLine("How many eggs did chicken 1 produce");
            int egg0 = Convert.ToInt32(ReadLine());
            WriteLine("How many eggs did chicken 2 produce");
            int egg1 = Convert.ToInt32(ReadLine());
            WriteLine("How many eggs did chicken 3 produce");
            int egg2 = Convert.ToInt32(ReadLine());
            WriteLine("How many eggs did chicken 4 produce");
            int egg3 = Convert.ToInt32(ReadLine());
            int dozen = (egg0 + egg1 + egg2 + egg3) / 12;
            int eggleft = (egg0 + egg1 + egg2 + egg3) % 12;
            WriteLine("Your chickens produced {0} dozen and {1} eggs.", dozen, eggleft);

        }
    }
}