using System;// Libreria del framework .Net 5 

namespace Users //namespace è lo spazio dei nomi di tipo identificativo
{
    //La classe per inziiare a creare l'oggetto Program
    class Program
    {
        /// <summary>
        /// Questo codice calcola la divizione tra le caramelle e le persone,
        /// passando dei valori come parametri, da parte dell'utente
        /// </summary>
        /// <returns>string</returns>
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il valore delle caramelle: ");// Scrivo a video il testo per inserire le caramelle -> Input
            decimal valoreLettoDalVideoDelleCaramelle= Convert.ToDecimal(Console.ReadLine()); // Leggo la linea con i valori inseriti dall'utente per le caramelle
            decimal candies = valoreLettoDalVideoDelleCaramelle;  //variabile di tipo intero(numero) con valore 10 -> Input
            Console.WriteLine("Inserisci il valore delle persone: ");//Scrivo a video il testo per inserire il numero di persone -Input
            decimal valoreLettoDalVideoDellePersone= Convert.ToDecimal(Console.ReadLine()); //Leggo la linea con i valori inseriti dall'utente per il numero di persone.
            decimal people = valoreLettoDalVideoDellePersone; //variabile di tipo intero(numero) con valore 5 -> Input
            string testo = " e' il risultato della divisione";// variabile di tipo stringa con un valore di tipo lettere -> Input
                       
            decimal quantity = candies / people;//logica di operazione aritmetica di tipo divisione -> Logica
            Console.WriteLine(quantity.ToString() + testo);// Stampa a video il risultato(Output)
        }
    }
}
