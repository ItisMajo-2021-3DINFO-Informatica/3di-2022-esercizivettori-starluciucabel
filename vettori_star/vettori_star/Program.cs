using System;

namespace vettori_star
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 400;
            int i = 0;
            Random generatore = new Random();  
            for (i = 0; i < dimensione; i++)
            {
                int numerocasuale = generatore.Next(0, 101);
                Console.WriteLine($"{numerocasuale}");
            }

            
        }
    }
}
