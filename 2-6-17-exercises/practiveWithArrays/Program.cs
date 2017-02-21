using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace practiveWithArrays {
    class Program {
        static void Main(string[] args) {
            int[] valid = { 321, 654, 987 };
            int x = 0;
            bool isValid = false;
            int id = 0;
            while(x < valid.Length && id != valid[x])
            ++x;
            if(x != valid)
                isvalid = true;
            if(isValid)
                Write("valid");
            else
                Write("not valid");

        }
    }
}
