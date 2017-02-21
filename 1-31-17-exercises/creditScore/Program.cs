using System;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace creditCheck {
    class Program {
        static void Main() {
                             
            int counter;                          

            // read the first letter
            WriteLine("Enter a score: ");
            //string creditScore = ReadLine();
            int creditScoreInt = Convert.ToInt32(ReadLine());
             

            counter = 0;                            
            while(creditScoreInt != 999)                       
            {
                if (creditScoreInt > 851 || creditScoreInt < 299) {
                    WriteLine("Invalid Score");
                }
                    
                else{
                    ++counter;
                    
                    
                }
                WriteLine("Enter a score: ");
                creditScoreInt = Convert.ToInt32(ReadLine());
            }
            WriteLine("The number of letters read is: {0}", counter);

        }

    }
}
