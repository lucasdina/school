using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ChatAWhile {
    class Program {
        static void Main(string[] args) {
            double[] areaCode = { 262, 414, 608, 715, 815, 920 };
            double[] pmc = { .07, .10, .05, .16, .24, .14 };
            WriteLine("Enter your area code from the following list.");
            for(int x=0; x < areaCode.Length; x++) {
                WriteLine("{0}", areaCode[x]);
            }
            bool validZip = false;
            double input = Convert.ToDouble(ReadLine());
            double cost = 0;
            for(int x = 0; x<areaCode.Length; ++x) {
                if(input == areaCode[x]) {
                    validZip = true;
                    cost = pmc[x];
                    WriteLine("How long do you plan to talk on the phone?");
                    double time = Convert.ToInt32(ReadLine());
                    double totalCost = cost * time;
                    WriteLine("This call to area code {0} for {1} minutes will cost you {2} at a rate of {3} per minute.", input, time, totalCost.ToString("C"), pmc[x]);
                }
            }
            //WriteLine("How long do you plan to talk on the phone?");
            //double time = Convert.ToInt32(ReadLine());
            //double totalCost = cost * time;
            //WriteLine("This call from area code {0} for {1} minutes will cost you {2}.", input, time, totalCost.ToString("C"));
        }
    }
}
