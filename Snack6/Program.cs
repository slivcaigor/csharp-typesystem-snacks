//  6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] invitati = { "Ibrahim", "Luigi", "Jessica", "Tommaso", "Romina" };

while (true)
{
    Console.Write("Inserisci il tuo nome: ");
    string nome = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsDigit))
    {
        Console.WriteLine("Inserisci un nome valido.");
    }
    else if (Array.IndexOf(invitati, nome) >= 0)
    {
        Console.WriteLine("Sei invitato alla festa del grande Gatsby!");
        break;
    }
    else
    {
        Console.WriteLine("Purtroppo non sei invitato alla festa del grande Gatsby.");
        break;
    }
}
Console.ReadLine();



