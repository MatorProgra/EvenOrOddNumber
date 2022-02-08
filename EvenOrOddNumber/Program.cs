// See https://aka.ms/new-console-template for more information

Console.Write("Program sprawdza parzystość liczb.\nWpisz liczbę (k kończy działanie): ");

string input;
while ((input = Console.ReadLine()!.ToLower()) != "k")
{
	if (int.TryParse(input, out int number))
	{
		string result = (number % 2 == 0) ? "parzysta" : "nieparzysta";
		Console.WriteLine($"Twoja liczba {number} jest {result}.");
		Console.Write("Wpisz liczbę (k kończy działanie): ");
	}
	else
		Console.Write("Error! Nieprawidłowe dane! Wpisz liczbę: ");
}

Console.WriteLine("\nKoniec programu.");
Console.ReadLine();