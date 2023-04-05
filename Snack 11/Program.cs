// 11. Dare la possibilità di inserire due parole. Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.

Console.Write("Inserisci la prima parola: ");
string primaParola = Console.ReadLine() ?? string.Empty;

while (string.IsNullOrWhiteSpace(primaParola) || primaParola.Any(char.IsDigit))
{
    Console.WriteLine("Parola non valida. Inserisci solo parole.");
    Console.Write("Inserisci la prima parola: ");
    primaParola = Console.ReadLine() ?? string.Empty;
}

Console.Write("Inserisci la seconda parola: ");
string secondaParola = Console.ReadLine() ?? string.Empty;

while (string.IsNullOrWhiteSpace(secondaParola) || secondaParola.Any(char.IsDigit))
{
    Console.WriteLine("Parola non valida. Inserisci solo parole.");
    Console.Write("Inserisci la seconda parola: ");
    secondaParola = Console.ReadLine() ?? string.Empty;
}

VerificaLunghezzaParole(primaParola, secondaParola);

Console.ReadLine();

 static void VerificaLunghezzaParole(string primaParola, string secondaParola)
{
    if (primaParola.Length == secondaParola.Length)
    {
        Console.WriteLine("Le due parole hanno la stessa lunghezza.");
        Console.WriteLine($"Prima parola: {primaParola}");
        Console.WriteLine($"Seconda parola: {secondaParola}");
    }
    else
    {
        Console.WriteLine("Le due parole hanno lunghezza diversa.");
        Console.WriteLine($"La parola più lunga è: {(primaParola.Length > secondaParola.Length ? primaParola : secondaParola)}");
    }
}


