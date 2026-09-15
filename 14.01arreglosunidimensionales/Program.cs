using System;


namespace _14._01arreglosunidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            int[] numeros = new int[5];
                        numeros[0] = 15;
                        numeros[1] = 56;
                        numeros[2] = 20;
                        numeros[3] = 47;
                        numeros[4] = 27;    
                        Console.WriteLine("el dato en la posición 3 es: " + numeros[3]);
                        float[] notas = new float[3];
                        notas[0] = 4.5f;
                        notas[1] = 5.0f;
                        notas[2] = 3.5f;
                        char[] simbolos = new char [] { '?', '(', '5', 'f' };
                        bool[] valores = { true, false, true, true, false };
                        string[] nombres = new string[7];
                        for (int i = 0; i < 7; i++) {
                            Console.WriteLine($"Ingrese un nombre para la posición {i+1}: I{i} ");
                            nombres[i] = Console.ReadLine();
                        }
                        for (int i = 0; i < nombres.Length; i++) {
                            Console.WriteLine($"El nombre en la posición {i + 1} es: {nombres[i]}");
                        }*/
            // crear arreglo enteros de 100 elementos asignar el numero 10 en cada uno de las posiciones del arreglo. leer el contenido de cada elemento y mostrarlo en pantalla
            int[] numeros = new int[100];
            for (int i = 0; i < numeros.Length; i++) {
                numeros[i] = 10;
            }
            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine($"El número en la posición {i + 1} es: {numeros[i]}");
            }
        }
    }
}
