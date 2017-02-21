using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace temperatureList {
    class tempList {
        enum Day {
            Sunday = 0, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
        static void Main(string[] args) {
            double[] weekTemps = new double[7];
            double totalTemps = 0;
            double temp = 0;
            int counter = 0;
            double fromAverage = 0;
            while(counter < weekTemps.Length) {
                WriteLine("Enter the temperature for {0}:", Enum.GetName(typeof(Day), counter));
                temp = Convert.ToDouble(ReadLine());
                weekTemps[counter] = temp;
                totalTemps = totalTemps + temp;
                ++counter;
                //Write("{0}", counter);
            }

            double averageTemp = totalTemps / counter;
            for(int x = 0; x < weekTemps.Length; x++) {
                fromAverage = weekTemps[x] - averageTemp;
                WriteLine("{0}'s temperature of {1} is {2} from the average temperature.", Enum.GetName(typeof(Day), x), weekTemps[x], fromAverage);
                //WriteLine("Total is: {0} \nAverage is: {1}", totalTemps, averageTemp);
            }
            WriteLine("\nTotal is: {0} \nAverage is: {1}", totalTemps, averageTemp);
        }
    }
}
