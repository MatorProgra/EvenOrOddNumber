// See https://aka.ms/new-console-template for more information

Console.WriteLine("Program sprawdza parzystość liczb. Koniec - k.");

while (true)
{
	Console.Write("Wpisz liczbę: ");

	string? input = Console.ReadLine();
	if (string.IsNullOrWhiteSpace(input))
	{
		ErrorMessage();
		continue;
	}

	if (input.ToLower() == "k")
		break;

	if (!int.TryParse(input, out int evenOrOdd))
	{
		ErrorMessage();
		continue;
	}

	string result = (evenOrOdd % 2 == 0) ? "parzysta" : "nieparzysta";
	Console.WriteLine($"Twoja liczba {evenOrOdd} jest {result}.");
}

Console.WriteLine("\nKoniec programu.");
Console.ReadLine();

static void ErrorMessage() => Console.Write("Error! Nieprawidłowe dane! ");