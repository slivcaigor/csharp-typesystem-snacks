// 9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

int[] numeri = Array.Empty<int>();
int somma = 0;
int numero;

Console.Write("Inserisci un numero: ");
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Numero non valido. Inserisci solo numeri.");
    Console.Write("Inserisci un numero: ");
}

while (somma + numero < 50)
{
    Array.Resize(ref numeri, numeri.Length + 1);
    numeri[^1] = numero;
    somma += numero;

    Console.Write("Inserisci un numero: ");
    while (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Numero non valido. Inserisci solo numeri.");
        Console.Write("Inserisci un numero: ");
    }
}

Console.WriteLine("La somma degli elementi è maggiore di 50. Ecco i numeri inseriti:");
foreach (int n in numeri)
{
    Console.WriteLine(n);
}

Console.ReadLine();




