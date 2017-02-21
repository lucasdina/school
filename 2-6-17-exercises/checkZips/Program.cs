using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace checkZips {
    class Program {
        static void Main(string[] args) {
            int[] zips = { 12345, 23456, 34567, 45678, 56789, 67890, 78901, 89012, 90123, 01234 };
            int x;
            int entry;
            Write("What is your zip code?? ");
            entry = Convert.ToInt32(ReadLine());
            x = Array.BinarySearch(zips, entry);
            if(x < 0)
                WriteLine("We do not deliver to {0}.", entry);
            else
                WriteLine("Yes, we deliver to {0}", entry);
        }
    }
}
