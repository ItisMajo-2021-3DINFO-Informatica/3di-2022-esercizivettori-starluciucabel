using System;

namespace Starluciuc_es_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 100;
            int massimo = 0;
            int minimo = int.MaxValue;
            int[] vett = new int[dimensione];
            for(int a = 0; a < dimensione; a++)
            {
                Random generatore = new Random();
                int numero = generatore.Next(1000, 3000);
                vett[a] = numero;
                if (minimo > vett[a])
                {
                    minimo = vett[a];
                }
                if (massimo < vett[a])
                {
                    massimo = vett[a];
                }
            }
            Console.WriteLine($"il più grande e :{massimo} il più piccolo è: {minimo}");
        }
    }
}
