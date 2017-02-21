using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumForInts {
    class Program {
        static void Main(string[] args) {
            int counter = 1;
            //WriteLine("Enter an interger:");
            int total = 0;
            while(counter <5) {
                WriteLine("Enter a number");
                int input = Convert.ToInt32(ReadLine());
                counter++;
                total = total + input;
                
            }
            WriteLine("The sum is {0}", total);
        }
    }
}
