using System;


namespace _16.arreglosbidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales - Matrices/*            int[,] numeros= new int[2, 3];            //numeros [2, 1] = 45; No se puede almacenar porque el índice de la fila no existe            //numeros [1, 4] = 20; No se puede almacenar porque el índice de la columna no existe            numeros[0, 0] = 12;            numeros[0, 1] = 89;            numeros[0, 2] = 46;            numeros[1, 0] = 2;            numeros[1, 1] = 54;            numeros[1, 2] = 25;            //Recuperar dato de una posición            Console.WriteLine($"El número almacenado en numeros[1, 0] es: {numeros[1, 0]}");            //Recorrer matriz para llenar            char[,] simbolos= new char[3, 2];            for ( int i = 0; i<3; i++) //Recorrer las filas            {                for(int j = 0; j < 2; j++) //Recorrer las columnas                {                    Console.WriteLine($"Escriba el carácter para los simbolos[{i}, {j}]: ");                    simbolos[i, j] = char.Parse(Console.ReadLine());                }               }            Console.Clear();            //Recorrer para recuperar los datos            for (int i=0; i<simbolos.GetLength(0); i++)            {                for (int j=0; j<simbolos.GetLength(1); j++)                {                    Console.WriteLine($"{simbolos[i, j]} |");                }                Console.WriteLine();            }            //Otra forma de declarar e inicializar matrices            string[,] nombres = new string[2, 3] {                                                     { "Juan", "Pedro", "Luis" },                                                    { "Ana", "Maria", "Luisa" }                                                  };*///1. Crear una matriz [10,20], en cada posición de la matriz poner el valor número 100; mostrar la matriz en consola./*            int[,] matriz = new int[10, 20];            for (int i=0;i<matriz.GetLength(0);i++)            {                for (int j=0;j<matriz.GetLength(1);j++)                {                    matriz[i, j] = 100;                }            }            // Mostrar la matriz            for (int i = 0; i < matriz.GetLength(0); i++)            {                for (int j = 0; j < matriz.GetLength(1); j++)                {                    Console.Write(matriz[i, j] + " ");                }                Console.WriteLine();            }*///2. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.int[,] matriz1 = new int[2, 3];
         int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];

            int[,] suma = new int[2, 3];



            //primera matrizConsole.WriteLine("Ingrese los digitos de la primera matriz:");

            for (int i = 0; i < matriz1.GetLength(0); i++) {

                for (int j = 0; j < matriz1.GetLength(1); j++) {

                    Console.Write($"Digito [{i},{j}]: ");

                    matriz1[i, j] = int.Parse(Console.ReadLine());

                }

            }


            //segunda matrizConsole.WriteLine("Ingrese los digitos de la segunda matriz:");

            for (int i = 0; i < matriz2.GetLength(0); i++) {

                for (int j = 0; j < matriz2.GetLength(1); j++) {

                    Console.Write($"Digito [{i},{j}]: ");

                    matriz2[i, j] = int.Parse(Console.ReadLine());

                }

            }


            // Sumafor (int i = 0; i < suma.GetLength(0); i++)

            {

                for (int j = 0; j < suma.GetLength(1); j++) {

                    suma[i, j] = matriz1[i, j] + matriz2[i, j];

                }

            }


            //ResultadoConsole.WriteLine("\nMatriz resultante:");


            for (int i = 0; i < suma.GetLength(0); i++) {

                for (int j = 0; j < suma.GetLength(1); j++) {

                    Console.Write(suma[i, j] + "\t");

                }


                Console.WriteLine();

            }
        }
    }
}
