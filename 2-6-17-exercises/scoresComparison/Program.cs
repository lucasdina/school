using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace temperatureList {
    class tempList {
        enum Test {
            Test01 = 0, Test02, Test03, Test04
        }
        static void Main(string[] args) {
            double[] weekTests = new double[4];
            double totalTests = 0;
            double test = 0;
            int counter = 0;
            double fromAverage = 0;
            while(counter < weekTests.Length) {
                WriteLine("Enter the score for {0}:", Enum.GetName(typeof(Test), counter));
                test = Convert.ToDouble(ReadLine());
                weekTests[counter] = test;
                totalTests = totalTests + test;
                ++counter;
                //Write("{0}", counter);
            }

            double averageTest = totalTests / counter;
            for(int x = 0; x < weekTests.Length; x++) {
                fromAverage = weekTests[x] - averageTest;
                WriteLine("{0}'s test score of {1} is {2} from the average test.", Enum.GetName(typeof(Test), x), weekTests[x], fromAverage);
            }
            WriteLine("----------------------------------------------------------------------------");
            if(weekTests[0] > weekTests[1] && weekTests[1] > weekTests[2] && weekTests[2] > weekTests[3]) {
                for(int x = 0; x < weekTests.Length; x++) {
                    WriteLine("{0}'s score was {1}", Enum.GetName(typeof(Test), x), weekTests[x]);
                }
                WriteLine("You should probably study more!");
            }
            else {
                if(weekTests[0] < weekTests[1] && weekTests[1] < weekTests[2] && weekTests[2] < weekTests[3]) {
                    for(int x = 0; x < weekTests.Length; x++) {
                        WriteLine("{0}'s score was {1}", Enum.GetName(typeof(Test), x), weekTests[x]);
                    }
                    WriteLine("Keep up the great work!");
                }
                else {
                    for(int x = 0; x < weekTests.Length; x++) {
                        WriteLine("{0}'s score was {1}", Enum.GetName(typeof(Test), x), weekTests[x]);
                    }
                    WriteLine("You're a hot mess!");
                }
            }
            
        }
    }
}
