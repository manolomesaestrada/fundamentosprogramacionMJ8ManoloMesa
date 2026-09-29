using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


namespace taller_matricez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla las filas de numeros antes de sumar la suma de los elementos de cada columna.
            int[,] matriz = new int[10, 20];
            int[] sumaColumnas = new int[20];

            // Inicializar la matriz con valores aleatorios
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                }
            }

            // Calcular la suma de cada columna
            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    sumaColumnas[j] += matriz[i, j];
                }
            }
            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write($"{matriz[i, j],4}");
                }
                Console.WriteLine();
            }
            // Mostrar la suma de cada columna
            Console.WriteLine("Suma de los elementos de cada columna:");
            for (int j = 0; j < 20; j++)
            {
                
                Console.Write($"Columna {j + 1}: {sumaColumnas[j]} ");
            }
        }
    }*/
            //Desarrollar un programa que crea una matriz de n filas *m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y laxmatriz con el intercambio de filas.
            /*            int filas;
                        int columnas;
                        Console.Write("Ingrese el número de filas: ");
                        filas = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el número de columnas: ");
                        columnas = int.Parse(Console.ReadLine());
                        int[,] matriz = new int[filas, columnas];
                        Console.WriteLine("Ingrese los elementos de la matriz:");
                        for (int i = 0; i < filas; i++) {
                            for (int j = 0; j < columnas; j++) {
                                Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                                matriz[i, j] = int.Parse(Console.ReadLine());
                            }
                        }
                        // el programa debe intercambiar la primera fila con la última fila de la matriz
                        for (int j = 0; j < columnas; j++) {
                            int temp = matriz[0, j];
                            matriz[0, j] = matriz[filas - 1, j];
                            matriz[filas - 1, j] = temp;
                        }
                        // Imprimir la matriz original
                        Console.WriteLine("Matriz original:");
                        for (int i = 0; i < filas; i++) {
                            for (int j = 0; j < columnas; j++) {
                                Console.Write($"{matriz[i, j],4}");
                            }
                            Console.WriteLine();
                        }
                        // Imprimir la matriz con el intercambio de filas
                        Console.WriteLine("Matriz con el intercambio de filas:");
                        for (int i = 0; i < filas; i++) {
                            for (int j = 0; j < columnas; j++) {
                                Console.Write($"{matriz[i, j],4}");
                            }
                            Console.WriteLine();
                        }*/
            /*            //Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 5x5 llena de números aleatorios.
                        int[,] matriz = new int[5, 5];
                        int[] frecuencia = new int[10];
                        Random rand = new Random();
                        for (int i = 0; i < 5; i++) {
                            for (int j = 0; j < 5; j++) {
                                matriz[i, j] = rand.Next(1, 11);
                                frecuencia[matriz[i, j] - 1]++;
                            }
                        }
                        // Imprimir la matriz
                        Console.WriteLine("Matriz generada:");
                        for (int i = 0; i < 5; i++) {
                            for (int j = 0; j < 5; j++) {
                                Console.Write($"{matriz[i, j],4}");
                            }
                            Console.WriteLine();
                        }
                        // Imprimir la frecuencia de cada número
                        Console.WriteLine("Frecuencia de cada número:");
                        for (int i = 0; i < 10; i++) {
                            Console.WriteLine($"Número {i + 1}: {frecuencia[i]}");*/
            //Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en posiciones aleatorias.Luego, el algoritmo le debe permitir al usuario intentar adivinar la posición de una "X".
            /*            char[,] tablero = new char[5, 5];

                        Random random = new Random();

                        // Llenar tablero con espaciosfor (int i = 0; i < 5; i++)
                        for (int i = 0; i < 5; i++) {
                            for (int j = 0; j < 5; j++) {
                                tablero[i, j] = '-';
                            }
                        }

                        // Colocar 3 X sin repetir posicionesint xColocadas = 0;
                        int xColocadas = 0;
                        while (xColocadas < 3) {
                            int fila = random.Next(0, 5);
                            int columna = random.Next(0, 5);

                            if (tablero[fila, columna] != 'X') {
                                tablero[fila, columna] = 'X';
                                xColocadas++;
                            }
                        }

                        bool acierto = false;

                        // Tres intentosfor
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine($"\nIntento {intento}");

                            Console.Write("Ingrese la fila (1-5): ");
                            int filaUsuario = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese la columna (1-5): ");
                            int columnaUsuario = int.Parse(Console.ReadLine());

                            // Convertir de 1-5 a índices 0-4filaUsuario--;
                            columnaUsuario--;

                            if (filaUsuario >= 0 && filaUsuario < 5 &&
                                columnaUsuario >= 0 && columnaUsuario < 5) {
                                if (tablero[filaUsuario, columnaUsuario] == 'X') {
                                    Console.WriteLine("¡ÉXITO! Encontraste una X.");
                                    Console.WriteLine(
                                        $"La X estaba en la posición [{filaUsuario + 1},{columnaUsuario + 1}]");

                                    acierto = true;
                                    break;
                                }
                                else {
                                    Console.WriteLine("No hay una X en esa posición.");
                                }
                            }
                            else {
                                Console.WriteLine("Coordenadas inválidas.");
                            }
                        }

                        // Si no acertó, mostrar matrizif (!acierto)
                        if (!acierto)    {
                            Console.WriteLine("\nERROR. No encontraste ninguna X.");
                            Console.WriteLine("La matriz era:");

                            for (int i = 0; i < 5; i++) {
                                for (int j = 0; j < 5; j++) {
                                    Console.Write(tablero[i, j] + " ");
                                }

                                Console.WriteLine();
                            }
                        }
                    }
                }*/

            //Desarrollar un programa e C# que: 
// Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz de enteros 
/*int filas, columnas;
            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            // Cargue los datos de la matriz ingresándolos por teclado
            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++) {
                for (int j = 0; j < columnas; j++) {
                    Console.Write($"Ingrese el elemento [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Muestre la matriz ingresada 
            Console.WriteLine("La matriz ingresada es:");
            for (int i = 0; i < filas; i++) {
                for (int j = 0; j < columnas; j++) {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser ahora la columna 1.
            Console.WriteLine("La matriz transpuesta es:");
            int[,] transpuesta = new int[columnas, filas];
            for (int i = 0; i < filas; i++) {
                for (int j = 0; j < columnas; j++) {
                    transpuesta[j, i] = matriz[i, j];
                }
            }
            // Mostrar la nueva matriz
            for (int i = 0; i < columnas; i++) {
                for (int j = 0; j < filas; j++) {
                    Console.Write(transpuesta[i, j] + " ");
                }
                Console.WriteLine();
            }
            //imprimir la matriz transpuesta*/


        }
    }
}
 