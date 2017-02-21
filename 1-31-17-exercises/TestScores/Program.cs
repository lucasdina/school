using System;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestScores {
    class Program {
        static void Main() {
            int counter;
            WriteLine("Enter a score: ");
            int creditScoreInt = Convert.ToInt32(ReadLine());
            counter = 0;
            int scoreTotal = 0;
            while(creditScoreInt != 999) {
                if(creditScoreInt < 0 || creditScoreInt > 100) {
                    WriteLine("Invalid Score");
                }

                else {
                    ++counter;
                    scoreTotal = scoreTotal + creditScoreInt;
                    //int scoreTotalInt = scoreTotal + creditScoreInt;

                }
                WriteLine("Enter a score: ");
                creditScoreInt = Convert.ToInt32(ReadLine());
                //int scoreTotalInt = scoreTotal + creditScoreInt;

            }
            WriteLine("The number of scores read is: {0}", counter);
            double average = scoreTotal / counter;
            WriteLine("Your average was {0}", average);

        }

    }
}
