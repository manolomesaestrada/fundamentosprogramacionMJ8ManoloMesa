using System;


namespace _11.ciclosdowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //algoritmo que solicita un numero y genere su correspondiente tabla de multiplicar del 1 al 10. y asi sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.
            /*            int numero;
                        int contador = 0;
                        int acumulador;
                        char selector;

                        Console.WriteLine("Ingrese un numero para generar su tabla de multiplicar: ");
                        numero = int.Parse(Console.ReadLine());

                        do {
                            acumulador = numero * contador;

                            Console.WriteLine($"{numero} x {contador} = {acumulador}");
                            contador++;

                        } while (contador <= 10);
                        Console.WriteLine("Desea generar otra tabla de multiplicar? (s) de lo contrario ponga cualquier caracter");
                        selector = char.Parse(Console.ReadLine());
                        if (selector == 's' || selector == 'S') {
                            Main(args);
                        }
                        else {
                            Console.WriteLine("Gracias por usar el programa.");
                        */

            // crear un algoritmo que permita calcular y mostrar por pantalla los numeros primos comprendidos entre 1 y 100.
            int numero = 2;
            int contador;
            bool esPrimo = true;
            Console.WriteLine("Los numeros primos comprendidos entre 1 y 100 son: ");
            do {
                contador = 2;
                esPrimo = true;
                while (contador <= Math.Sqrt(numero)) {
                    if (numero % contador == 0) {
                        esPrimo = false;
                        break;
                    }
                    contador++;
                }
                if (esPrimo) {
                    Console.WriteLine(numero);
                }
                numero++;
            } while (numero <= 100);
            Console.WriteLine("Gracias por usar el programa.");
        }
    }
}