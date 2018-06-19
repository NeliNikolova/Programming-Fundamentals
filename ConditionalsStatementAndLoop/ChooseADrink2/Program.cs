using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_drink
{
	class Program
	{
		static void Main(string[] args)
		{
			string proffesion = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());
			double price = 0;
			if (proffesion == "Athlete")
			{
				price = 0.7 * quantity;


			}
			else if (proffesion == "Businessman" || proffesion == "Businesswoman")
			{
				price = 1.0 * quantity;

			}
			else if (proffesion == "SoftUni Student")
			{
				price = 1.7 * quantity;

			}
			else
			{
				price = 1.2 * quantity;

			}
			Console.WriteLine($"The { proffesion} has to pay {price:f2}.");
		}
	}
}