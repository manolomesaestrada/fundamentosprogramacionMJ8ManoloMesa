using System;


namespace _8.ciclowhilel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // realizar un programa que solicite al usuario ingresar números enteros positivos y los sume. El programa debe continuar solicitando números hasta que el usuario ingrese un número negativo, momento en el cual se mostrará la suma total de los números ingresados.
            /*   int sumaenterospositivos = 0;
            int numero;
                Console.Write("Ingrese un número entero positivo (o un -1 para terminar): ");
                numero = int.Parse(Console.ReadLine());
                while (numero >= 0) {

                    sumaenterospositivos += numero;
                    Console.Write("Ingrese un número entero positivo (o un -1 para terminar): ");
                    numero = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("La suma de los números ingresados es: " + sumaenterospositivos);*/
        //realizar un algoritmo que le pida al usuario ingresar por teclado numeros enteros al azar. al usuario le corresponde ingresar la cantidad de numeros que va a ingresar. el programa debe mostrar la suma de los numeros ingresados y el promedio de los mismos.
            int cantidadnumeros = 0;
            int contador = 0;
            int numero = 0;
            int contadorpositivos = 0;
            int contadornegativos = 0;
            int contadorceros = 0;
            Console.Write("Ingrese la cantidad de números enteros que desea ingresar: ");
            cantidadnumeros = int.Parse(Console.ReadLine());
            while (cantidadnumeros >= contador) {
                contador++;
                Console.Write("Ingrese un número entero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0) {
                    contadornegativos++;
                }
                else {
                    if (numero > 0) {
                    contadorpositivos++;
                    }
                    else {
                    contadorceros++;
                    }
                }
            }
            Console.WriteLine("La suma de los números ingresados es: " + contador);
            Console.WriteLine("Cantidad de números positivos: " + contadorpositivos);
            Console.WriteLine("Cantidad de números negativos: " + contadornegativos);
            Console.WriteLine("Cantidad de números ceros: " + contadorceros);
        }
    }
}

    

