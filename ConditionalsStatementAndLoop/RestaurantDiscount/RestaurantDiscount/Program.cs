using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
	class Program
	{
		static void Main(string[] args)
		{
			int groupSize = int.Parse(Console.ReadLine());
			string package = Console.ReadLine();
			double priceDiscount = 0;
			double pricePerson = 0;
			if (groupSize <= 50 && groupSize > 0)
			{
				Console.WriteLine("We can offer you the Small Hall");
				if (package == "Normal")
				{
					priceDiscount = 3000 * 0.95;
					pricePerson = priceDiscount / groupSize;
				}
				else if (package == "Gold")
				{
					priceDiscount = 3250 * 0.9;
					pricePerson = priceDiscount / groupSize;
				}
				else if (package == "Platinum")
				{
					priceDiscount = 3500 * 0.85;
					pricePerson = priceDiscount / groupSize;
				}
			}
			else if (groupSize <= 100 && groupSize > 50)
			{
				Console.WriteLine("We can offer you the Terrace");
				if (package == "Normal")
				{
					priceDiscount = 5500 * 0.95;
					pricePerson = priceDiscount / groupSize;
				}
				else if (package == "Gold")
				{
					priceDiscount = 5750 * 0.9;
					pricePerson = priceDiscount / groupSize;
				}
				else if (package == "Platinum")
				{
					priceDiscount = 6000 * 0.85;
					pricePerson = priceDiscount / groupSize;
				}
			}
			else if (groupSize <= 120 && groupSize > 100)
			{
				Console.WriteLine("We can offer you the Great Hall");
				if (package == "Normal")
				{
					priceDiscount = 8000 * 0.95;
					pricePerson = priceDiscount / groupSize;
				}
				else if (package == "Gold")
				{
					priceDiscount = 8250 * 0.9;
					pricePerson = priceDiscount / groupSize;
				}
				else if (package == "Platinum")
				{
					priceDiscount = 9000 * 0.85;
					pricePerson = priceDiscount / groupSize;
				}
			}


			else
			{
				Console.WriteLine("We do not have an appropriate hall.");
				return;
			}
			Console.WriteLine($"The price per person is {pricePerson:f2}$");
		}
	}
}