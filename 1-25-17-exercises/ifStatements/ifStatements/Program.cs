using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(ReadLine());
            if (number <= 5)
                WriteLine("A");
            else
                WriteLine("B");
        }
    }
}
