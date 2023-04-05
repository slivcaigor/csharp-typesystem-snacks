// 5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.


Console.Write("Inserisci un numero: ");
int numero;
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.Write("Inserisci un numero valido: ");
}

if (numero % 2 == 0)
{
    Console.WriteLine($"Il numero {numero} è pari!");
}
else
{
    Console.WriteLine($"Il numero {numero} è dispari, il successivo è: {numero + 1}");
}

Console.ReadLine();
