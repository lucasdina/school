using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortPrices
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] night = { 1, 2, 3, 4, 5, 6, 7, 8 };
			int[] price = { 200, 200, 180, 180, 160, 160, 160, 145 };
			WriteLine("How many nights will you be staying?");
			int input = Convert.ToInt32(ReadLine());
			int total;
			if (input >= 8)
			{
				total = input * 145;
				WriteLine("Your total will be {0}.", total.ToString("C"));
			}
			else
			{
				//bool valid = false;
				for (int x = 0; x < night.Length; x++)
				{
					if (input == night[x])
					{
						total = input * price[x];
						WriteLine("Your total will be {0}.", total.ToString("C"));
					}

				
				}
			}
		}
	}
}