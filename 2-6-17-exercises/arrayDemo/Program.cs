using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace arrayDemo {
    class Program {
        static void Main(string[] args) {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            WriteLine("Enter 1 to view the list in order.\nEnter 2 to view the list in reverse order.\nEnter 3 to see a specific entry.\nEnter 999 to quit.");
            int input = Convert.ToInt32(ReadLine());
            while(input != 999) {
                if(input == 1) {
                    //WriteLine("success1");
                    WriteLine("The following is the list in order:");
                    for(int x = 0; x < array.Length; x++) {
                        WriteLine("{0}", array[x]);
                    }

                }
                else {
                    if(input == 2) {
                        //WriteLine("success2");
                        WriteLine("The following is the list in reverse order:");
                        for(int x = array.Length - 1; x >= 0; x--) {
                            WriteLine("{0}", array[x]);
                        }
                    }
                    else {
                        if(input == 3) {
                            WriteLine("Enter the number of the entry you are looking for:");
                            int arrayNew = Convert.ToInt32(ReadLine());
                            if(arrayNew <= 7 && arrayNew >= 0) {
                                int entry = arrayNew - 1;
                                WriteLine("The number {0} is located in position {1}", array[entry], entry);
                            }
                            else {
                                WriteLine("Invalid input");
                            }
                        }
                        else {
                            WriteLine("Invalid input");
                        }
                    }
                }
                WriteLine("Enter 1 to view the list in order.\nEnter 2 to view the list in reverse order.\nEnter 3 to see a specific entry.\nEnter 999 to quit.");
                input = Convert.ToInt32(ReadLine());
            }
        }
    }
}
