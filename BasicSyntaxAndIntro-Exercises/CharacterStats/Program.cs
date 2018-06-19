using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracterStat
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int currentHealth = int.Parse(Console.ReadLine());
			int maximumHealth = int.Parse(Console.ReadLine());
			int currentEnargy = int.Parse(Console.ReadLine());
			int maximumEnergy = int.Parse(Console.ReadLine());
			int resultHealth = maximumHealth - currentHealth;
			int resultEnergy = maximumEnergy - currentEnargy;


			Console.WriteLine("Name: {0}", name);
			Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', resultHealth));
			Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnargy), new string('.', resultEnergy));


		}
	}
}

