using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace enterLowerCaseLetters {
    class Program {
        static void Main(string[] args) {
            WriteLine("Enter a lowercase letter:");
            char input = 'a';
            input = Convert.ToChar(ReadLine());
            while(input !='!') {
                //input = Convert.ToChar(ReadLine());
                if(input >= 'a' && input <= 'z') {
                    WriteLine("{0} is a lowercase letter.", input);
                    //WriteLine("THAT IS NOT LOWERCASE!!!");
                }
                else {
                    WriteLine("THAT IS NOT LOWERCASE!!!");
                    //WriteLine("{0} is a lowercase letter. Enter another one or type !", input);
                }
                WriteLine("Enter a lowercase letter:");
                input = Convert.ToChar(ReadLine());
            }
                
        }
    }
}
