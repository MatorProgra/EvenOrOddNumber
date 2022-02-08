// See https://aka.ms/new-console-template for more information

Console.Write("Program sprawdza parzystość liczb. Koniec - k.\nWpisz liczbę: ");

while (true)
{
	string input;
	while ((input = Console.ReadLine()!.ToLower()) != "k")
	{		
		if (int.TryParse(input, out int number))
		{
			string result = (number % 2 == 0) ? "parzysta" : "nieparzysta";
			Console.WriteLine($"Twoja liczba {number} jest {result}.");
			Console.Write("Wpisz liczbę: ");
		}
		else
			Console.Write("Error! Nieprawidłowe dane! Wpisz liczbę: ");
	}
	break;
}

Console.WriteLine("\nKoniec programu.");
Console.ReadLine();