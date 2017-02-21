using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            for (count = count; count < 10; count++) 
                Console.WriteLine("Hello Loop {0}", count);
        }
    }
}
