using System;


namespace _13.ciclofor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for (int contador = 1; contador <= 5; contador++) {
                acumulador += contador;
            }

            Console.WriteLine($"La suma de los primeros 5 números es: {acumulador}");
        }
    }
}
