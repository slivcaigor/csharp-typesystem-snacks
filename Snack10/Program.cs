// 10. Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

int N;

Console.Write("Inserisci un numero: ");
while (!int.TryParse(Console.ReadLine(), out N))
{
    Console.WriteLine("Numero non valido. Inserisci solo numeri.");
    Console.Write("Inserisci un numero: ");
}

Random rnd = new();
for (int i = 0; i < N; i++)
{
    int[] numeri = new int[10];
    for (int j = 0; j < 10; j++)
    {
        numeri[j] = rnd.Next(1, 101);
    }

    Console.WriteLine($"Array {(i + 1)}:");
    foreach (int n in numeri)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();
