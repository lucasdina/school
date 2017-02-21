// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class DebugSix04 {
    public static void Main() {
        const int QUIT = 999;
        Console.Write("Please enter a number or " +
           QUIT + " to quit...");
        string inString = ReadLine();
        int num = Convert.ToInt32(inString);
        int[] numbers = new int[num];
        int x = 0;
        double average;
        double total = 0;
        while((x < numbers.Length) && num != QUIT) {
            numbers[x] = num;
            total += numbers[x];
            ++x;
            Write("Please enter a number or " +
               QUIT + " to quit...");
            inString = ReadLine();
            num = Convert.ToInt32(inString);
        }
        WriteLine("The numbers are:", numbers);
        for(int y = 0; y < x; ++y)
            Console.Write("{0,6}", numbers[y]);
        average = total / x;
        WriteLine();
        WriteLine("The average is {0}", average);
    }
}
