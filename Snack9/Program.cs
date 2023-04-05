// 9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

int[] numeri = new int[8];
int somma = 0;
int i = 0;

Console.Write("Inserisci un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

while (somma + numero < 50)
{
    numeri[i] = numero;
    somma += numero;
    i++;

    Console.Write("Inserisci un numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("La somma degli elementi è maggiore di 50. Ecco i numeri inseriti:");
for (int j = 0; j < i; j++)
{
    Console.WriteLine(numeri[j]);
}
Console.ReadLine();