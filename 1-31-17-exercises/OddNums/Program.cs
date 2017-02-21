using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OddNums {
    class Program {
        static void Main(string[] args) {
            int count = 1;
            while (count <= 99) {
                WriteLine("{0} ",count.ToString("D2"));
                count ++;
                count++;
            }
        }
    }
}
