using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace deliveryCharges {
    class Program {
        static void Main(string[] args) {
            int[] zips = { 12345, 23456, 34567, 45678, 56789, 67890, 78901, 89012, 90123, 01234 };
            int[] delCharges = { 01, 12, 23, 34, 45, 56, 67, 78, 89, 90 } ;
            int x;
            int entry;
            int cost = 0;
            Write("What is your zip code? ");
            entry = Convert.ToInt32(ReadLine());
            x = Array.BinarySearch(zips, entry);
            //int cost = delCharges[x];
            if(x < 0)
                WriteLine("We do not deliver to {0}.", entry);
            else {
                cost = delCharges[x];
                WriteLine("Yes, we deliver to {0}, and the delivery cost will be {1}", entry, cost.ToString("C"));
            }
            }
    }
}
