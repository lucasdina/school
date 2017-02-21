using System;
using static System.Console;

class test
{
    public static void Main()
    {
        char response = 'y' ;
        while (response == 'y') ;
        {
            WriteLine("Enter the scores of 5 of your tests in percentages.");
            int test0 = Convert.ToInt32(ReadLine());
            int test1 = Convert.ToInt32(ReadLine());
            int test2 = Convert.ToInt32(ReadLine());
            int test3 = Convert.ToInt32(ReadLine());
            int test4 = Convert.ToInt32(ReadLine());
            int average = (test0 + test1 + test2 + test3 + test4) / 5;
            WriteLine("Your average was {0}", average);
            string input = ReadLine();
            char response = Convert.ToChar(input);
        }
    }
}