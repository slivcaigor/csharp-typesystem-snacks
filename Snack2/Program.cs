//	2. L’utente inserisce due parole in successione.
//	Il software stampa prima la parola più corta, poi la parola più lunga.

Console.WriteLine("Inserisci la prima parola:");
string parola1 = Console.ReadLine() ?? string.Empty;
while (string.IsNullOrWhiteSpace(parola1) || parola1.Any(char.IsDigit))
{
    Console.WriteLine("Inserisci una parola valida (senza numeri):");
    parola1 = Console.ReadLine() ?? string.Empty;
}


Console.WriteLine("Inserisci la seconda parola:");
string parola2 = Console.ReadLine() ?? string.Empty;
while (string.IsNullOrWhiteSpace(parola2) || parola2.Any(char.IsDigit))
{
    Console.WriteLine("Inserisci una parola valida (senza numeri):");
    parola2 = Console.ReadLine() ?? string.Empty;
}


if (parola1.Length < parola2.Length)
{
    Console.WriteLine($"La parola più corta è la prima: {parola1}");
    Console.WriteLine($"La parola più lunga è la seconda: {parola2}");
}
else
{
    Console.WriteLine($"La parola più corta è la seconda: {parola2}");
    Console.WriteLine($"La parola più lunga è la prima: {parola1}");
}

Console.ReadLine();