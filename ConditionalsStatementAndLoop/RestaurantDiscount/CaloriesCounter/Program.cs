using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfLines = int.Parse(Console.ReadLine());
			int sumOfCalories = 0;
			for (int i = 0; i < numberOfLines; i++)
			{
				string ingredients = Console.ReadLine();
				ingredients = ingredients.ToLower();

				if (ingredients == "cheese")
				{
					sumOfCalories += 500;

				}
				else if (ingredients == "tomato sauce")
				{
					sumOfCalories += 150;
				}
				else if (ingredients == "salami")
				{
					sumOfCalories += 600;
				}
				else if (ingredients == "pepper")
				{
					sumOfCalories += 50;
				}


			}
			Console.WriteLine($"Total calories: {sumOfCalories}");
		}
	}
