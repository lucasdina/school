using System;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace creditCheck {
    class Program {
        static void Main() {

            int counter;
            int total = 0;

            // read the first letter
            WriteLine("Enter a number: ");
            //string creditScore = ReadLine();
            int creditScoreInt = Convert.ToInt32(ReadLine());


            counter = 0;
            while(creditScoreInt != 999) {
                if(creditScoreInt >= 999999999 || creditScoreInt < -999999999) {
                    WriteLine("Invalid number");
                }

                else {
                    ++counter;
                    total = creditScoreInt + total;

                }
                WriteLine("Enter a number: ");
                creditScoreInt = Convert.ToInt32(ReadLine());
            }
            WriteLine("The number of numbers read is {0} and the sum is {1}.", counter, total);

        }

    }
}
