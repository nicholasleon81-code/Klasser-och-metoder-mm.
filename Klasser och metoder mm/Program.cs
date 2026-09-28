
using DiceGame.Metoder;



/*
//En "instans" det betyder att objektet kan nu få ett värde ifall den inte är privat
//Två olika sätt att skriva samma sak
Tarning tarning1 = new Tarning();
Tarning tarning2 = new (6);

Console.WriteLine($"Tärning 1 har värde: {tarning1.Varde}");
Console.WriteLine($"Tärning 2 har värde: {tarning2.Varde}");

tarning1.Rulla();

Console.WriteLine($"Tärning 1 har nu värdet: {tarning1.Varde}");
*/
//Lätt litet tärnings spel, testa och se ifall ni kan förstå
int returnValue = 0;
while (true)
{
    Console.Write("Hur stor tärningsbord vill du ha?: ");
    string? readInput = Console.ReadLine();

    bool successfulParse = int.TryParse(readInput, out returnValue);
    if (successfulParse)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du skrev ett värde vi inte kan förstå.");
    }

}

TarningsHand hand = new TarningsHand(returnValue);
hand.RullaAlla();
Console.ReadLine();