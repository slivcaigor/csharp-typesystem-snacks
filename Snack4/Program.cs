//4.Calcola la somma e la media dei numeri da 2 a 10.
int somma = 0;
int numeri = 0;
for (int i = 2; i <= 10; i++)
{
    somma += i;
    numeri++;
}
decimal media = (decimal)somma / numeri;
Console.WriteLine($"Somma: {somma}");
Console.WriteLine($"Media: {media}");
Console.ReadLine();