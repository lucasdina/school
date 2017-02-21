using System;
using static System.Console;


namespace System
{
    class showMeTheMoney
    {
        static void Main()
        {
            int moreMoney = 35;
            int someMoney = 27;
            int total = moreMoney + someMoney;

            //double someMoney = 27.19;
            //Write("The money is $");
            //WriteLine(someMoney);
            WriteLine("Bob has ${0} and is missing ${1}.", someMoney, moreMoney);
            WriteLine("Cindy has an extra ${0}.",moreMoney);
            WriteLine("Together, they have ${0} and Cindy is a dirty theif!",total);
            WriteLine("How much money do you have?");
            int input = Convert.ToInt32(ReadLine());
            WriteLine("You have ${0}", input);
            int money = input - total;
            int lessMoney = total - input;
            if (input > total)
            {
                WriteLine("That is ${0} more than these chumps.", money);
            }
            else
            {
                WriteLine("That is ${0} less than these chumps.", lessMoney);
            }
        }


    }
}