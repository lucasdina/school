using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MultiplicationTable {
    class Program {
        static void Main(string[] args) {
            WriteLine("Enter a number:");
            int input = Convert.ToInt32(ReadLine());
            int count = 0;
            while(count <= 12) {
                int sum = count * input;
                WriteLine("{0} X {1} = {2}", input, count, sum);
                count++;
            }

        }
    }
}
