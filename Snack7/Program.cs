// 7. Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

int[] numeri = new int[6];
int count = 0;
while (count < 6)
{
    Console.Write("Inserisci un numero: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        if (numero % 2 != 0)
        {
            numeri[count] = numero;
            count++;
        }
    }
    else
    {
        Console.WriteLine("Numero non valido. Riprova.");
    }
}
Console.WriteLine("I numeri dispari inseriti sono:");
for (int i = 0; i < numeri.Length; i++)
{
    Console.WriteLine(numeri[i]);
}
Console.ReadLine();