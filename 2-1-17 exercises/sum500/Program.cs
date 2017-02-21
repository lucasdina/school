using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum500 {
    class Program {
        static void Main(string[] args) {
            int sum = 0;
            int count = 0;
            while(count <= 500) {
                sum = sum + count;
                count++;
            }
            Console.WriteLine("The total of intergers from 1 to 500 is: {0}", sum);
        }
    }
}
