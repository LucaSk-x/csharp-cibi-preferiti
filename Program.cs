// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = {"Pizza", "Pasta", "Risotto", "Lasagne", "Pasta al forno", "Scaloppine", "Orata al Cartoccio", "Bistecca" };

//Esercizio 1 (lunghezza array)
Console.WriteLine("1. La mia classifica ha " + cibiPreferiti.Length + " cibi");

//Esercizio 2 (stampo la lista intera)
Console.WriteLine("2. i miei cibi preferiti sono:");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

//Esercizio 3 (stampo il cibo nella posizione 0)
Console.WriteLine("3. Il mio cibo preferito è: " + cibiPreferiti[0]);

//Esercizio 4 (stampo il cibo nell' ultima posizione) 
Console.WriteLine("4. Il mio cibo meno preferito è: " + cibiPreferiti[4]);