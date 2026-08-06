using System;


namespace _4.condicionalsimpledoble
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Estructura de control condicional simple



            /*            byte edad = 0;
                        Console.WriteLine("Ingrese su edad:");
                        edad = Convert.ToByte(Console.ReadLine());
                        if (edad >= 18)
                        {
                            //si la condicion es verdadera
                            Console.WriteLine("Bienvenido al polnito lico");
                        }
                        else 
                        { Console.WriteLine("tiene 5 minutos para cerrar la pagina o seras arrestado por un agente del mossad"); 

                        } 
                        //Crear algorigmo ingresar el nombre y el sueldo de una persona y si el sueldo es mayor a 3000 mostrar un mensaje de felicitaciones y si es menor a 1000 mostrar un mensaje de que debe mejorar su sueldo



            */
            string nombre =String.Empty;
            double sueldo = 0;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo:");
            sueldo = Convert.ToDouble(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine(nombre + " a pagar los impuestos GG.");
            }
            else
            {
                Console.WriteLine(nombre + " Maldito pobre.");
            }
        }


    }
}
