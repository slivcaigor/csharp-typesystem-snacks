//	1. L’utente inserisce due numeri in successione.
//	Il software stampa il maggiore.

Console.WriteLine("Inserisci il primo numero:");
int num1;
while (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Inserisci un numero valido:");
}

Console.WriteLine("Inserisci il secondo numero:");
int num2;
while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Inserisci un numero valido:");
}

if (num1 > num2)
{
    Console.WriteLine($"Il primo numero è maggiore! -> {num1}");
}
else
{
    Console.WriteLine($"Il secondo numero è maggiore!  -> {num2}");
}

Console.ReadLine();
