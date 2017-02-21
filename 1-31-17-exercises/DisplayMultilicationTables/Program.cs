using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMultilicationTables {
    class Program {
        static void Main(string[] args) {
            
            int firstNum = 1;
            int secondNum = 1;
            int sum = 1;
            
            while(secondNum < 11){
                firstNum = 1;
                while(firstNum < 11){
                    sum = firstNum * secondNum;
                    //WriteLine();
                    Write("{0} ", sum.ToString("D3"));
                    //WriteLine();
                    firstNum++;
                }
                secondNum++; 
            }
            
            //WriteLine("exit");
        }
    }
}
