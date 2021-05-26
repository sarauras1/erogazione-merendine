using System;
using System.Collections.Generic;
////Erogazione Merendine(usare Dictionary):
////Mostrare un menu all’utente per far scegliere la merendina desiderata (scelta tra 4 merendine):
////Esempio:

////Scegli:

////1 per Buondì: prezzo 1 €

////2 per Patatine: prezzo 0.5 €

////..Una volta scelta la merendina, chiedere all’utente di inserire i soldi.

////Se i soldi inseriti sono meno del prezzo allora chiedere di nuovo 
//l’aggiunta di soldi e sommarli a quelli già inseriti quindi rieffettuare il 
//controllo fino al raggiungimento o superamento del prezzo della merendina scelta.

////Se il totale dei soldi inseriti è uguale al prezzo della merendina allora mostrare 
///a video “Erogazione merendina”.

////Se il totale dei soldi supera il prezzo della merendina, mostrare a video “Erogazione merendina” 
///ed anche il messaggio con il resto “Resto erogato : X.XX €”.
namespace Merendine
{
    class Program
    {
        static void Main(string[] args)
        {
            var cassa = new Dictionary<int, double>();

            var d = new Dictionary<int, string>()
            {
                [1] = "Buondi",
                [2] = "Patatine"

            };


            double moneyB = 1;
            double moneyP = 0.5;



            do
            {
                Console.WriteLine("Scegli un opzione:");
                Console.WriteLine("A -- per il Buondi");
                Console.WriteLine("B -- per le Patatine");
                Console.WriteLine("D -- per Visualizzare i prodotti rimasti");
                Console.WriteLine("C -- per uscire");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'A':

                        Buondi(moneyB, cassa, d);
                        break;

                    case 'B': Patatine(moneyP, cassa, d);
                        break;

                    case 'D': foreach (var items in d)
                        {
                            Console.WriteLine($"i nostri prodotti -- {items}");
                        }
                        break;

                    case 'C': return;

                }
            }
            while (true);

           

        }

        private static void Buondi(double moneyB, Dictionary<int, double> cassa, Dictionary<int, string> d)
        {

            Console.WriteLine("---insersci £ 1---");
            double euro = double.Parse(Console.ReadLine());


            if (euro == moneyB)
            {
                Console.WriteLine("Erogazione prodotto, ritirare prodotto");
                cassa.Add(1, 1);
                d.Remove(1);
            }
            else if (euro > moneyB)
            {
                Console.WriteLine($"Ecco il tuo Resto -- {euro - moneyB}");
                Console.WriteLine($"Erogazione prodotto");
                cassa.Add(1, 1);
                d.Remove(1);
            }
            else if (euro < moneyB)
            {


                Console.WriteLine($"inserici -- {moneyB - euro}");
                double euro1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"inserito il rimanente di -- {Math.Round(euro1)}");
                cassa.Add(1, 1);
                d.Remove(1);
                Console.WriteLine("Ergazione prodotto");
            }





            }// buondi

        private static void Patatine(double moneyP, Dictionary<int, double> cassa, Dictionary<int, string> d)
        {

            Console.WriteLine("--insersci £ 0.5--");
            double euro2 = double.Parse(Console.ReadLine());


            if (euro2 == moneyP)
            {
                Console.WriteLine("Grazie Erogazione prodotto");
                d.Remove(2);
                cassa.Add(2, 0.5);
            }
            else if (euro2 > moneyP)
            {
                Console.WriteLine($"Ecco il tuo Resto -- {euro2 - moneyP}");
                Console.WriteLine($"Erogazione prodotto");
                d.Remove(2);
                cassa.Add(2, 0.5);
            }
            else if (euro2 < moneyP)
            {
              
                    Console.WriteLine($"Inserisci il rimanente di -- {moneyP - euro2}");
                    double euro1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"inserito il rimanente -- {Math.Round(euro1)}");              
                
                   d.Remove(2);
                   cassa.Add(2, 0.5);
                  Console.WriteLine("Ergazione prodotto");

            }

        }//patatine

       
      
      
    }
}
