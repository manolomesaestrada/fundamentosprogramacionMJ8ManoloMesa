using System;


namespace _7._1while
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //1. escribir un algoritmo que permita generar los primeros 5 numeros enteros positivos
            int contador = 1;
            int acumulador = 1;
            while (contador <= 5) {

                contador++;
                acumulador = acumulador + contador;
            }
            Console.WriteLine("La suma de los primeros 5 números enteros positivos es: " + acumulador);*/

            //crear un algoritmo que permita calcular la factorial de un numero dado por el usuario (5! = 5*4*3*2*1)
            int factorial = 1;
            int contador = 1;
            Console.WriteLine("Ingrese un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());
            while (numero > 1) {
                factorial *= numero;
                contador++;
            }
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);

        }
    }
}
