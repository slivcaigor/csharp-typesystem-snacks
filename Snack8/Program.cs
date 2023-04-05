//  8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] numeri = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int somma = 0;

for (int i = 0; i <= numeri.Length - 1; i++)
{
    if (i % 2 != 0)
    {
        somma += numeri[i];
    }
}

Console.WriteLine($"La somma degli elementi in posizione dispari è {somma}");
Console.ReadLine();