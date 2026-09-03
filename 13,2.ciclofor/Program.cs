using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2.ciclofor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que permita imprimir por pantalla los números múltiplos de 5, el usuario debe ingresar por el teclado el rango de números a evaluar. 
            int acumulator = 0;
            int count = 0;
            for (int multiplo = 0; multiplo < 10; multiplo++)
            {
                if (multiplo % 5 == 0)
                {
                    Console.WriteLine(multiplo);
                    acumulator += multiplo;
                    count++;
                }
            }
            Console.WriteLine("La suma de los múltiplos de 5 es: " + acumulator);
            Console.WriteLine("El número de múltiplos de 5 es: " + count);
        }
    }
}
