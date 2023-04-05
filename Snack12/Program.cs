//  12. Scrivere una funzione per verificare se un numero è pari o dispari. Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.

Console.Write("Inserisci un numero: ");

int numero;

while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Numero non valido. Inserisci solo numeri.");
    Console.Write("Inserisci un numero: ");
}

if (VerificaPariDispari(numero))
{
    Console.WriteLine("Il numero è pari.");
}
else
{
    Console.WriteLine("Il numero è dispari.");
}

Console.ReadLine();

 static bool VerificaPariDispari(int numero)
{
    return numero % 2 == 0;
}
