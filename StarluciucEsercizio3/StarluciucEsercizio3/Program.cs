using System;

namespace StarluciucEsercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 30;
            int somma = 0;
            int media = 0;
            int[] vett = new int[dimensione];
            for (int a = 0; a < dimensione; a++)
            {
                Random generatore = new Random();
                int numero = generatore.Next(0, 50);
                vett[a] = numero;

                somma = somma + numero;
                media = somma / 30;

            }
            for (int a = 0; a < dimensione; a++)
            {
                Console.WriteLine($"il numero: {a + 1} = {vett[a]}");
            }
            Console.WriteLine($"la media dei numeri casuali e :{media}");
        }
    }
}
