using System;
using OperazioniMatematica;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            try
            {
                double risultato;
                Console.WriteLine("Quale operazione si vuole fare? (Add/Sot/Mol/Div/Pot/Min/Max)");
                string risposta = Console.ReadLine();
                if (risposta == "Add")
                {
                    risultato = OperazioniMatematica.OperazioniMatematica.Somma(n1, n2);
                }
                else if (risposta == "Sot")
                {
                    risultato = OperazioniMatematica.OperazioniMatematica.Differenza(n1, n2);
                }
                else if (risposta == "Mol")
                {
                    risultato = OperazioniMatematica.OperazioniMatematica.Moltiplicazione(n1, n2);
                }
                else if (risposta == "Div")
                {
                    risultato = OperazioniMatematica.OperazioniMatematica.Divisione(n1, n2);
                }
                else if (risposta == "Pot")
                {
                    risultato = OperazioniMatematica.OperazioniMatematica.Potenza(n1, n2);
                }
                else if (risposta == "Min")
                {
                    risultato = OperazioniMatematica.OperazioniMatematica.Minimo(n1, n2);
                }
                else if (risposta == "Max")
                {
                    risultato = OperazioniMatematica.OperazioniMatematica.Massimo(n1, n2);
                }
                else risultato = double.NaN;
                Console.WriteLine(risultato);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
