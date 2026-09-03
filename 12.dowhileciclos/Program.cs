using System;


namespace _12.dowhileciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //algoritmo que le pida a un grupo de usuarios su nombre, numero de cuenta y saldo;para cada usuario se debe hacer lo siguiente: si el saldo es mayor a 3000000, se le debe cobrar un impuesto del 5% y mostrar el saldo final; si el saldo es menor o igual a 3000000, se le debe cobrar un impuesto del 10% y mostrar el saldo final. El programa debe terminar cuando el usuario ingrese "salir" como nombre y que al final muestre el promedio de todas las personas que entraron
            //.
            string nombre;
            Console.Write("Ingrese su nombre o (n) para salir:");
            nombre = Console.ReadLine();
            int personas = 1;
            int numeroCuenta;
            double saldo = 0;
            double sumaSaldos = saldo;
            while (nombre != "n")
            {
                Console.Write("Ingrese numero de cuenta ");
                numeroCuenta = int.Parse(Console.ReadLine());
                Console.Write("Ingrese su saldo:");
                saldo = double.Parse(Console.ReadLine());
                // Procesar los datos del usuario


                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Numero de cuenta: {0}", numeroCuenta);
                Console.WriteLine("Saldo: {0}", saldo.ToString("C"));
                if (saldo >= 3000000)
                {
                Console.WriteLine("eres apto para el credito");
                 
                }
                else
                {
                    Console.WriteLine("no eres apto para el credito");
                }
                

                Console.Write("Ingrese su nombre o (n) para salir: ");
                nombre = Console.ReadLine();
                personas++;
                sumaSaldos += saldo;
            }
            if (nombre == "n")
            {
                double promedio = sumaSaldos / (personas - 1); // Restamos 1 para no incluir el usuario "salir"
                Console.WriteLine("Promedio de saldos: {0}", promedio.ToString("C"));
            }
        }
    }
}
