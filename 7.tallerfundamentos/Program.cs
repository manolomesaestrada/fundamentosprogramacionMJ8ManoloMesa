using System;
using System.Diagnostics.Eventing.Reader;


namespace _7.tallerfundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        { //Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar enpantalla los números de menor a mayor.
            /*                int num1, num2, num3;
                            Console.WriteLine("Ingrese el primer número:");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el tercer número:");
                            num3 = int.Parse(Console.ReadLine());
                            if (num1 != num2 && num2 != num3 && num1 != num3) {
                                if (num1 > num2 && num1 > num3 && num3 > num2) {
                                    Console.WriteLine("El número mayor es: " + num1);
                                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num2 + ", " + num3 + ", " + num1);
                                }
                                else if (num1 > num2 && num1 > num3 && num3 < num2) {
                                    Console.WriteLine("El número mayor es: " + num1);
                                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num3 + ", " + num2 + ", " + num1);
                                }
                                else if (num2 > num1 && num2 > num3 && num3 < num1) {
                                    Console.WriteLine("El número mayor es: " + num2);
                                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num3 + ", " + num1 + ", " + num2);
                                }
                                else if (num2 > num1 && num2 > num3 && num3 > num1) {
                                    Console.WriteLine("El número mayor es: " + num2);
                                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num1 + ", " + num3 + ", " + num2);
                                }
                                else if (num3 > num1 && num3 > num2 && num2 < num1) {
                                    Console.WriteLine("El número mayor es: " + num3);
                                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num2 + ", " + num1 + ", " + num3);
                                }
                                else if (num3 > num1 && num3 > num2 && num2 > num1) {
                                    Console.WriteLine("El número mayor es: " + num3);
                                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num1 + ", " + num2 + ", " + num3);
                                }  
                            }
                        else if (num1 == num2 && num2 == num3 && num1 == num3) {
                            Console.WriteLine("Los números no son diferentes.");
                            }*/
            //El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si cuenta con munición y si se encuentra en estado invencible, crear un programa que:
            /*            byte estado;
                        byte municion;
                        Console.WriteLine("Ingrese el estado del personaje (invencible (1) o vulnerable (0):");
                        estado = byte.Parse(Console.ReadLine());
                        Random random = new Random();
                        municion = (byte)random.Next(1, 11);
                        Console.WriteLine("El personaje tiene " + municion + " balas de munición.");
                        if (estado == 1 && municion > 0) {
                            Console.WriteLine("El personaje esta disparando.");
                        }
                        else {
                            Console.WriteLine("El personaje no puede disparar.");
                        }*/
            //Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1, y1), P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1 P3.La distancia entre dos puntos está dada por la siguiente formula: d = √((x2 - x1)² +(y2 - y1)²) Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con dichas distancias se puede construir un triángulo, consultar las condiciones que se deben cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las condiciones no se cumplen.
            /*int x1, y1, x2, y2, x3, y3;
            Console.WriteLine("Ingrese las coordenadas del primer punto (x1, y1):");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del segundo punto (x2, y2):");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del tercer punto (x3, y3):");
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            //Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1
            //P3.La distancia entre dos puntos está dada por la siguiente formula:
            //d = √((x2 - x1)² +(y2 - y1)²) 
            if (x1 == x2 && y1 == y2 || x2 == x3 && y2 == y3 || x1 == x3 && y1 == y3) {
                Console.WriteLine("Los puntos no son diferentes.");
            }
            else {
                double d12 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double d23 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                double d13 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                Console.WriteLine("La distancia entre P1 y P2 es: " + d12);
                Console.WriteLine("La distancia entre P2 y P3 es: " + d23);
                Console.WriteLine("La distancia entre P1 y P3 es: " + d13);
                if (d12 + d23 > d13 && d12 + d13 > d23 && d23 + d13 > d12) {
                    Console.WriteLine("Se puede construir un triángulo con las distancias calculadas.");
                }
                else {
                    Console.WriteLine("No se puede construir un triángulo con las distancias calculadas.");
                }

            }*/

            //El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha), 
            //grama que muestre en la consola un mensaje diciendo si el personaje se mueve
            //hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
            // Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
            //derecha
            // Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
            // En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
            //dirección
            /*        string direccion;
                    Console.WriteLine("Ingrese la dirección del personaje (d para derecha, i para izquierda):");
                    direccion = Console.ReadLine();
                        if (direccion == "d") {
                            Console.WriteLine("El personaje se mueve hacia la derecha.");
                        }
                        else if (direccion == "i") {
                            Console.WriteLine("El personaje se mueve hacia la izquierda.");
                        }
                        else {
                            Console.WriteLine("No me puedo mover en otra dirección.");
                        }*/
//El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
//el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
// Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. 
//(Función Random)
// Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego.En
//caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
//ninguna acción”. 
// Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
//carácter que se ingrese: 
//o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando” 
//o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana” 
//o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo” 
//o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible”         
        byte vidas;
        string accion;
            Random random = new Random();
            vidas = (byte)random.Next(0, 6);
            if (vidas == 0) {
                Console.WriteLine("el personaje no posee vidas, y no puede realizar ninguna acción");
            } else {
                Console.WriteLine("el personaje tiene " + vidas + " vidas");
                Console.WriteLine("Ingrese la acción que desea realizar (c, x, t, i):");
                accion = Console.ReadLine();
                switch (accion) {
                    case "c":
                        Console.WriteLine("el personaje está disparando");
                        break;
                    case "x":
                        Console.WriteLine("el personaje está hablando con la Rata");
                        break;
                    case "t":
                        Console.WriteLine("el personaje está en modo Turbo");
                        break;
                    case "i":
                        Console.WriteLine("el personaje es Invencible");
                        break;
                    default:
                        Console.WriteLine("ERROR ACCION NO VALIDA");
                        break;
                }
            }
        }
    }
}