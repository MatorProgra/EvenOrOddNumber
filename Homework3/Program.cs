using System;

namespace Homework3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Program sprawdza parzystość liczb.\nWpisz liczbę: ");

			int input;

			while (!int.TryParse(Console.ReadLine(), out input))
			{
				Console.Write("Error! Wpisałeś złe dane! Spróbuj jeszcze raz: ");
			}

			string result = (input % 2 == 0) ? "parzysta" : "nieparzysta";

			Console.WriteLine($"Twoja liczba {input} jest {result}.");
			Console.ReadLine();
		}
	}
}
