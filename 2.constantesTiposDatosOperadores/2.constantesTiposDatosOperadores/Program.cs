using System;
using System.Management.Instrumentation;


namespace _2.constantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constantes
            const string iva = "19%";
            string name = "Manolo";
            name = "mesa";
            //iva = "20%"; a una constante NO le puedo cambiar el valor
            //tipos de datos
            byte dato1 = 255;
            int dato2 = -1000;
            long dato3 = 1000000000000;
            float dato4 = 3.14f;
            double dato5 = 3.14159d;
            decimal dato6 = 3.141592653589793238462643383279502884197169399375105820974944592307M;
            char dato7 = 'ñ';//solo un caracter caution!!!
            string dato8 = "w pereira chad chad chad";
            bool dato9 = true;// solo true o false
            object dato10 = new object();

            // OPERADORES
            //Operadores numericos
            //Cambio de signo
            int dato11= 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11: {0}, dato12: {1}",dato11,dato12);
            int dato13 = 3 + 5;
            Console.WriteLine("La suma es: {0}", dato13);
            int dato14 = dato13 - 4;
            Console.WriteLine("La resta es: {0}", dato14);
            int dato15 = 3 * 4;
            Console.WriteLine("La multiplicación es: {0}", dato15);
            float dato16 =(float) 5 / 4;//float dato16 = 5 / 4f;
            Console.WriteLine("La división es: {0}", dato16);





        }
    }
}
