
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeting
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();

			int age = int.Parse(Console.ReadLine());
			int employee = int.Parse(Console.ReadLine());
			double salary = double.Parse(Console.ReadLine());




			Console.WriteLine("Name: {0}", name);
			Console.WriteLine(" Age: {0}", age);
			Console.WriteLine("Employee ID: {0:D8}", employee);
			Console.WriteLine("Salary: {0:f2}", salary);

		}
	}
}
