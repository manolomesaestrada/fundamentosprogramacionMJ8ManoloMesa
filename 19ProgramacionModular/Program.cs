using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ProgramacionModular
{
    internal class Program
    {

            static void Main(string[] args)
            {
                Mostrarmenu();
                CapturarOpcion();
            }
        static float Division()
        {
            Console.WriteLine("Ingrese un numero");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }
        static float Resta()
        {
            Console.WriteLine("Ingrese un numero");
            float numero1=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2;
        }
        static float Multiplicacion()
        {
            float multiplicacion = 1;
            char respuesta = ' ';
            float numero = 0;
            do {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea ingresar otro numero? (s/n)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's' || respuesta == 'S');
            return multiplicacion;
        }
        static float Suma()
        {
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;
            do {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea ingresar otro numero? (s/n)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's' || respuesta == 'S');
            return suma;
        }

        static void RealizarOperacion(int opcion)
        {
            while (opcion != 0) {
                switch (opcion) {
                    case 1:
                        Console.WriteLine($"Suma: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"Resta: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"Multiplicacion: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"Division: {Division()}");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Mostrarmenu();
                opcion = CapturarOpcion();
            }
        }
                 
        static void Mostrarmenu()
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1.Suma            2.Resta");
                Console.WriteLine("3.Multiplicacion  4.Division");
                Console.WriteLine("0.Salir");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Ingrese una opcion del menu");
            }
            static int CapturarOpcion()
            {
                return int.Parse(Console.ReadLine());
            }
        }
    }

