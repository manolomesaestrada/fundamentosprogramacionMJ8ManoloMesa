using System;


namespace _5.condicionalesAnidadosdiagramadeflujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condicionales anidados y diagrama de flujo
            //b. disenar un algoritmo que lea tres numeros a, b y c y determine cual es el mayor de los tres numeros

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("debe ingresar tres numeros");
            Console.WriteLine("Ingrese el valor del numero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 2:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 3:");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                //verdad
                if (num1 > num3)
                {
                    Console.WriteLine("el numero mayor es: " + num1);
                }
                else
                {
                    Console.WriteLine("el numero mayor es: " + num3);
                }
            }
            else
            {
               
                //falso
                if (num2 > num3)
                {
                  Console.WriteLine("el numero mayor es: " + num2);
                }
                else
                {
                    Console.WriteLine("el numero mayor es: " + num3);
                }
                
            }
        }
    }


