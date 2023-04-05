//  3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
//  Il programma stampa la somma di tutti i numeri inseriti.

int somma = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Inserisci il numero {i}:");
    if (!int.TryParse(Console.ReadLine(), out int numero))
    {
        Console.WriteLine("Numero non valido. Riprova.");
        i--;
    }
    else
    {
        somma += numero;
    }
}
Console.WriteLine($"La somma dei numeri inseriti è: {somma}");
Console.ReadLine();

