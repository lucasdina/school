using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace tipsList {
    class Program {
        enum Day {
            Sunday=0, Monday, Tuesday, Wednesday, Thursday, Friday
        }
        static void Main(string[] args) {
            double[] weekTips = new double[7];
            double totalTips = 0;
            double tip = 0;
            int counter = 0;
            double fromAverage = 0;
            while (counter < weekTips.Length) {
                WriteLine("Enter waiter's tips for {0}:", Enum.GetName(typeof(Day), counter));
                tip = Convert.ToDouble(ReadLine());
                weekTips[counter] = tip;
                totalTips += tip;
                ++counter;
                Write("{0}", counter);
            }

            double averageTip = totalTips / counter;
            for(int x = 0; x < weekTips[x] - averageTip;)  {
                fromAverage = weekTips[x] - averageTip;
                WriteLine("{0}'s tip of {1} is {2} from the average tip.", Enum.GetName(typeof(Day), x));
            }
    }
    }
}
