using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabel
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			double volume = int.Parse(Console.ReadLine());
			double energy = int.Parse(Console.ReadLine());
			double sugar = int.Parse(Console.ReadLine());
			double kiloCal = (volume * energy) / 100;
			double sugarTotal = (volume / 100) * sugar;
			Console.WriteLine("{0}ml {1}:", volume, name);
			Console.WriteLine("{0}kcal, {1}g sugars", kiloCal, sugarTotal);
		}
	}
}

