// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//string[] cibiPreferiti = {"Pizza", "Pasta", "Risotto", "Lasagne", "Pasta al forno", "Scaloppine", "Orata al Cartoccio", "Bistecca" };

////Esercizio 1 (lunghezza array)

//Console.WriteLine("1. La mia classifica ha " + cibiPreferiti.Length + " cibi");

//Esercizio 2 (stampo la lista intera)
//Console.WriteLine("2. i miei cibi preferiti sono:");
//for (int i = 0; i < cibiPreferiti.Length; i++)
//{
//    Console.Write(i+1 + " - ");
//    Console.WriteLine(cibiPreferiti[i]);
//}

////Esercizio 3 (stampo il cibo nella posizione 0)
//Console.WriteLine("3. Il mio cibo preferito è: " + cibiPreferiti[0]);

////Esercizio 4 (stampo il cibo nell' ultima posizione) 
//Console.WriteLine("4. Il mio cibo meno preferito è: " + cibiPreferiti[cibiPreferiti.Length - 1]);

////bonus (stampo la posiozione mediana)
//if (cibiPreferiti.Length % 2 == 0)
//{
//    int mediana = cibiPreferiti.Length / 2;
//    Console.WriteLine("La mediana è " + cibiPreferiti[mediana]);
//}
//else
//{
//    int mediana = cibiPreferiti.Length / 2;
//    Console.WriteLine("La mediana è " + cibiPreferiti[mediana] );
//}



//_________________________________________________________________________________

//Snack1.L’utente inserisce due numeri in successione (Il software stampa il maggiore)

//{
//    Console.WriteLine("Inserisci 2 numeri:");
//    string text = "Il tuo numero maggiore è :";

//    int number1 = Convert.ToInt32(Console.ReadLine());
//    int number2 = Convert.ToInt32(Console.ReadLine());

//    if (number1 > number2)
//    {
//        Console.WriteLine(text + number1);
//    }
//    else
//    {
//        Console.WriteLine(text + number2);
//    }
//}



////Snack2.L’utente inserisce due parole in successione (Stampa prima la più corta  e poi la più lunga)
//{
//    Console.WriteLine("Inserisci 2 parole:");
//    string text = "Le tue parole ordinate per lunghezza sono: ";

//    string parola1 = Console.ReadLine();
//    string parola2 = Console.ReadLine();
//    if (parola1.Length >  parola2.Length)
//    {
//        Console.WriteLine(text + parola2 + " - " + parola1);
//    }
//    else
//    {
//        Console.WriteLine(text + parola1 + " - " + parola2);
//    }
//}

//Snack3.Il software deve chiedere per 10 volte all’utente di inserire un numero (Il programma stampa la somma di tutti i numeri inseriti.)

//{
//    Console.WriteLine("Inserisci 10 numeri:");
//    int sommaNumeri = 0;
//    string text = "La somma dei tuoi 10 numeri inseriti è: ";
//    for (int i = 0; i < 10; i++)
//    {
//        int numero = Convert.ToInt32(Console.ReadLine());
//        sommaNumeri = sommaNumeri + numero;
//    }
//    Console.WriteLine(text + sommaNumeri);
//}

////Snack4.Calcola la somma e la media dei numeri da 2 a 10
//{
//    {
//        Console.WriteLine("La somma dei numeri da 2 a 10 è: ");
//        int numero = 2;
//        int sommaNumeri = 0;
//        for (int i = 0; i < 8; i++)
//        {
//            numero++;
//            sommaNumeri = sommaNumeri + numero;
//        }

//        Console.WriteLine(sommaNumeri);
//    }
//}

//Snack5.Il software chiede all’utente di inserire un numero. Se il numero inserito è pari stampa il numero, se è dispari, stampa il numero successivo.
//{
//    {
//        Console.WriteLine("Inserisci un numero, otterai sempre un numero pari");
//            int numero = Convert.ToInt32(Console.ReadLine());
//        if (numero % 2 == 1)
//        {
//            numero = numero + 1;
//        }

//        Console.WriteLine(numero);
//    }
//}


//Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
//{
//    string[] invitati = { "Luca", "lorenzo", "Mattia", "Omar", "Ugo" };

//    Console.WriteLine("inserisci il tuo nome per scoprire se sei invitato alla festa");
//    string nome = Console.ReadLine();
//    bool entrata = false;

//    foreach (string invitation in invitati)
//    {
//        if (nome == invitation)
//        {
//            entrata = true;
//        }

//    }
//    if (entrata)
//    {
//        Console.WriteLine("puoi entrare");
//    }
//    else
//    {
//        Console.WriteLine("Non puoi entrare");
//    }
//}

//Snack7.Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array






//Snack8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

//{
//    int[] numeri = { 3, 5, 7, 9, 11, 13, 15, 17 };
//    int sommaNumeri = 0;
//    string text = "La somma dei numeri pari è: ";

//    for (int i = 0; i < numeri.Length; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sommaNumeri = sommaNumeri + numeri[i];
//        }
//    }
//    Console.WriteLine(text + sommaNumeri);
//}


//Snack9.Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.






