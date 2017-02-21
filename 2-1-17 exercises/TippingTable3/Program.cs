using System;
using static System.Console;
class TippingTable {
    static void Main() {
        //WriteLine("How much was dinner?");
        //double dinnerPrice = 13.45;
        //WriteLine("");
        double tipRate;
        //WriteLine("");
        double tip;
        WriteLine("What is the lowest tip percantage?");
        double LOWRATE = Convert.ToDouble(ReadLine());
        WriteLine("What was the highest tip percentage?");
        double MAXRATE = Convert.ToDouble(ReadLine());
        //WriteLine("");
        double TIPSTEP = 0.05;
        WriteLine("What was the lowest resturant bill?");
        double MAXDINNER = Convert.ToDouble(ReadLine());
        WriteLine("What was the highest resturant bill?");
        //double DINNERSTEP = 10.00;
        double dinnerPrice = Convert.ToDouble(ReadLine());
        double DINNERSTEP = 10.00;
        Write("Price");
        for(tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
            Write("{0, 8}", tipRate.ToString("F"));
        WriteLine();
        WriteLine("--------------------------------------");
        while(dinnerPrice <= MAXDINNER) {
            Write("{0, 8}", dinnerPrice.ToString("C"));
            while(tipRate <= MAXRATE) {
                tip = dinnerPrice * tipRate;
                Write("{0, 8}", tip.ToString("F"));
                tipRate += TIPSTEP;
            }
            dinnerPrice += DINNERSTEP;
            tipRate = LOWRATE;
            WriteLine();
        }
    }
}
