using System;
using System.Xml.Linq;


namespace ParcialDeCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El programa debe solicitar al usuario los siguientes datos:
            //Objetivo
            //El programa debe:
            //Solicitar el mes de nacimiento.
            //Solicitar el signo zodiacal.
            //Analizar los datos ingresados.
            //Determinar el elemento correspondiente.
            //Mostrar en pantalla el resultado obtenido o el mensaje correspondiente cuando los datos no coincidan con ningún elemento.
            //El estudiante podrá utilizar las estructuras condicionales estudiadas en clase que considere adecuadas para resolver el problema.
            int mesNacimiento;
            string signoZodiacal;
            Console.WriteLine("Ingrese su mes de nacimiento (1-12):");
            mesNacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su signo zodiacal:");
            signoZodiacal = Console.ReadLine();
            string elemento = "";
            if ((mesNacimiento == 3 && signoZodiacal == "aries") || (mesNacimiento == 4 && signoZodiacal == "aries") || (mesNacimiento == 7 && signoZodiacal == "aries") || (mesNacimiento == 8 && signoZodiacal == "aries")  || (mesNacimiento == 11 && signoZodiacal == "aries") || (mesNacimiento == 12 && signoZodiacal == "aries")
                || (mesNacimiento == 3 && signoZodiacal == "leo") || (mesNacimiento == 4 && signoZodiacal == "leo") || (mesNacimiento == 7 && signoZodiacal == "leo") || (mesNacimiento == 8 && signoZodiacal == "leo")  || (mesNacimiento == 11 && signoZodiacal == "leo") || (mesNacimiento == 12 && signoZodiacal == "leo")
                || (mesNacimiento == 3 && signoZodiacal == "sagitario") || (mesNacimiento == 8 && signoZodiacal == "sagitario") || (mesNacimiento == 11 && signoZodiacal == "sagitario") || (mesNacimiento == 12 && signoZodiacal == "sagitario")
                ) {
                elemento = "fuego";
            }
            else if ((mesNacimiento == 1 && signoZodiacal == "tauro") || (mesNacimiento == 4 && signoZodiacal == "tauro") || (mesNacimiento == 5 && signoZodiacal == "tauro") || (mesNacimiento == 8 && signoZodiacal == "tauro") || (mesNacimiento == 9 && signoZodiacal == "tauro") || (mesNacimiento == 12 && signoZodiacal == "tauro")
                || (mesNacimiento == 1 && signoZodiacal == "virgo") || (mesNacimiento == 4 && signoZodiacal == "virgo") || (mesNacimiento == 5 && signoZodiacal == "virgo") || (mesNacimiento == 8 && signoZodiacal == "virgo") || (mesNacimiento == 9 && signoZodiacal == "virgo") || (mesNacimiento == 12 && signoZodiacal == "virgo")
                || (mesNacimiento == 1 && signoZodiacal == "capricornio") || (mesNacimiento == 4 && signoZodiacal == "capricornio") || (mesNacimiento == 5 && signoZodiacal == "capricornio") || (mesNacimiento == 8 && signoZodiacal == "capricornio") || (mesNacimiento == 9 && signoZodiacal == "capricornio") || (mesNacimiento == 12 && signoZodiacal == "capricornio")
                ) {
                elemento = "tierra";
            }
            else if ((mesNacimiento == 5 && signoZodiacal == "geminis") || (mesNacimiento == 6 && signoZodiacal == "geminis") || (mesNacimiento == 9 && signoZodiacal == "geminis") || (mesNacimiento == 10 && signoZodiacal == "geminis") || (mesNacimiento == 1 && signoZodiacal == "geminis") || (mesNacimiento == 2 && signoZodiacal == "geminis")
                || (mesNacimiento == 5 && signoZodiacal == "libra") || (mesNacimiento == 6 && signoZodiacal == "libra") || (mesNacimiento == 9 && signoZodiacal == "libra") || (mesNacimiento == 10 && signoZodiacal == "libra") || (mesNacimiento == 1 && signoZodiacal == "libra") || (mesNacimiento == 2 && signoZodiacal == "libra")
                || (mesNacimiento == 5 && signoZodiacal == "acuario") || (mesNacimiento == 6 && signoZodiacal == "acuario") || (mesNacimiento == 9 && signoZodiacal == "acuario") || (mesNacimiento == 10 && signoZodiacal == "acuario") || (mesNacimiento == 1 && signoZodiacal == "acuario") || (mesNacimiento == 2 && signoZodiacal == "acuario")) {
                elemento = "aire";
            }
            else if ((mesNacimiento == 3 && signoZodiacal == "cancer") || (mesNacimiento == 6 && signoZodiacal == "geminis") || (mesNacimiento == 7 && signoZodiacal == "geminis") || (mesNacimiento == 10 && signoZodiacal == "geminis") || (mesNacimiento == 11 && signoZodiacal == "geminis") || (mesNacimiento == 2 && signoZodiacal == "geminis")
                || (mesNacimiento == 3 && signoZodiacal == "escorpio") || (mesNacimiento == 6 && signoZodiacal == "libra") || (mesNacimiento == 7 && signoZodiacal == "libra") || (mesNacimiento == 10 && signoZodiacal == "libra") || (mesNacimiento == 11 && signoZodiacal == "libra") || (mesNacimiento == 2 && signoZodiacal == "libra")
                || (mesNacimiento == 3 && signoZodiacal == "piscis") || (mesNacimiento == 6 && signoZodiacal == "acuario") || (mesNacimiento == 7 && signoZodiacal == "acuario") || (mesNacimiento == 10 && signoZodiacal == "acuario") || (mesNacimiento == 11 && signoZodiacal == "acuario") || (mesNacimiento == 2 && signoZodiacal == "acuario")) {
                elemento = "agua";
            }
            else {
                elemento = "Datos no coinciden con ningún elemento.";
            }
            Console.WriteLine($"El elemento correspondiente es: {elemento}");
        }
    }
}
