using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;


namespace _14.tallerciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario, introducir tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente.
            /*            int calificacion;
                        double suma = 0;
                        int contador = 0;
                        char continuar;
                        string nombre; 
                        Console.WriteLine("Ingrese el nombre del estudiante: ");
                        nombre = Console.ReadLine();
                        do
                        {
                            Console.Write("Ingrese la calificación: ");
                            calificacion = int.Parse(Console.ReadLine());
                            suma += calificacion;
                            contador++;
                            Console.Write("¿Desea ingresar otra calificación? (s/n): ");
                            continuar = char.Parse(Console.ReadLine());
                        } while (continuar == 's' || continuar == 'S');
                        double promedio = suma / contador;
                        Console.WriteLine($"El promedio de {nombre} de las calificaciones es: {promedio, 2}");*/
            //Se requiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado. 
            /*int numero;
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Los divisores de {0} son:", numero);
            for (int contador = 1; contador <= numero; contador++) {
                if (numero % contador == 0) {
                    Console.WriteLine(contador);
                }
            }*/
            //Dados dos números enteros ingresados por teclado: b que es la base y e que es el exponente, se requiere calcular el resultado de la potenciación. Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32 Mostrar por pantalla el resultado de la potenciación.  Seguir pidiendo por teclado la base y el exponente y realizar la potenciación correspondiente, hasta que el usuario ingrese por teclado el carácter de escape ‘n’ 
            /*            int numero;
                        int potencia = 1;
                        int exponente;
                        char continuar;
                        do {
                            Console.WriteLine("Ingrese la base: ");
                            numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el exponente: ");
                            exponente = int.Parse(Console.ReadLine());
                            for (int contador = 1; contador <= exponente; contador++) {
                                potencia *= numero;
                            }
                            Console.WriteLine("El resultado de la potenciación es: {0}", potencia);
                            Console.WriteLine("ingrese s salir del programa y ciualquier caracter para continuar ");
                            continuar = char.Parse(Console.ReadLine());
                        }
                        while (continuar != 's' && continuar != 'S');
                        Console.WriteLine("Gracias por usar el programa");
                    */
            //Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco kilómetros durante 10 días, para determinar si es apto para la prueba de 5 kilómetros.Para considerarlo apto debe cumplir las siguientescondiciones:  Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos. Que al menos en una de las pruebas realice un tiempo menor de 15 minutos. Que su promedio sea menor o igual a 18 minutos.
            /*            int tiempo;
                        int suma = 0;
                        int contador = 0;
                        bool menor = false;
                        bool mayor = false;
                        for (int dias = 0; dias < 10; dias++) {
                            Console.WriteLine("Ingrese el tiempo del día {0} en minutos: ", dias + 1);
                            tiempo = int.Parse(Console.ReadLine());
                            suma += tiempo;
                            contador++;
                            if (tiempo < 15) {
                                menor = true;
                            }
                            if (tiempo > 20) {
                                mayor = true;   
                            }
                        }
                        double promedio = suma / contador;
                        if (promedio <= 18 && menor && !mayor) {
                            Console.WriteLine("El promedio del atleta es: {0} minutos.", promedio);
                            Console.WriteLine("El atleta es apto para la prueba de 5 kilómetros.");
                        }
                        else {
                            Console.WriteLine("El promedio del atleta es: {0} minutos.", promedio);
                            Console.WriteLine("El atleta no es apto para la prueba de 5 kilómetros.");
                        }*/
            //Se aplicó una encuesta a n personas solicitando su opinión sobre el tema del servicio militar obligatorio para las mujeres. Las opciones de respuesta fueron: a favor, en contra y no responde. Se solicita un algoritmo que calcule qué porcentaje de los encuestados marcó cada una de las respuestas.   
        int personas;
        int afavor = 0;
        int encontra = 0;
        int noresponde = 0;
        char respuesta; 
        Console.WriteLine("Ingrese la cantidad de personas encuestadas: ");
        personas = int.Parse(Console.ReadLine());
            for (int acumulador = 0; acumulador < personas; acumulador++) {
                Console.WriteLine("Ingrese la respuesta del encuesta afavor (a/A), en contra (e/E) o no responde (n/N): ", acumulador + 1);
                respuesta = char.Parse(Console.ReadLine());
                if (respuesta == 'a' || respuesta == 'A') {
                    afavor++;
                }
                else if (respuesta == 'e' || respuesta == 'E') {
                    encontra++;
                }
                else if (respuesta == 'n' || respuesta == 'N') {
                    noresponde++;
                }
                else {
                    Console.WriteLine("Respuesta inválida. Por favor ingrese a, e o n.");
                    acumulador--;
                }
            }
            double porcentajeAfavor = (double)afavor / personas * 100;
            double porcentajeEncontra = (double)encontra / personas * 100;
            double porcentajeNoResponde = (double)noresponde / personas * 100;
            Console.WriteLine("El porcentaje de personas a favor es: {0:F2}%", porcentajeAfavor);
            Console.WriteLine("El porcentaje de personas en contra es: {0:F2}%", porcentajeEncontra);
            Console.WriteLine("El porcentaje de personas que no respondieron es: {0:F2}%", porcentajeNoResponde);
        }
    }
}



    

