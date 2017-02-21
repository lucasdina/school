using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WhippetBus {
    class Program {
        static void Main(string[] args) {
            //int costSelect = 0;
            int[] distance = { 0, 100, 300, 500 };
            double[] cost = { 25.00, 40.00, 55.00, 70.00 };
            WriteLine("How far will you be traveling today?");
            int input = Convert.ToInt32(ReadLine());
            if(input > 500) {
                WriteLine("That will be {0}", cost[3].ToString("C"));
            }
            else {
                for(int x = 0; x < distance.Length; x++) {
                    if(input >= distance[x] && input < distance[x + 1]) {
                        WriteLine("That will be {0}", cost[x].ToString("C"));
                    }
                }
            }
            }
    }
}
