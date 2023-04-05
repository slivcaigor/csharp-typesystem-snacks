// See https://aka.ms/new-console-template for more information

//Istruzioni condizionali
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





//	2. L’utente inserisce due parole in successione.
//		Il software stampa prima la parola più corta, poi la parola più lunga.
//Ciclo for
//    3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.
//    4. Calcola la somma e la media dei numeri da 2 a 10.
//Operatore modulo
//    5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
//Array
//    6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
//	7. Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
//    8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
//Ciclo while
//    9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
//Random
//    10. Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.
//Funzioni
//    11. Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.
//    12. Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.