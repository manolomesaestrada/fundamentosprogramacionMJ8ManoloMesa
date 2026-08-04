using System;


namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operador numerico
            //Incremento decremento
            int dato1 = 0;
            dato1++;//dato1= dato1 + 1; incremento
            dato1--;//dato1= dato1 - 1; decremento
            dato1 += 5;//dato1= dato1 + 5; incremento
            dato1 *= 3;//dato1= dato1 * 3; incremento
            dato1 /= 2;//dato1= dato1 / 2; incremento
            dato1 += dato1;//dato1= dato1 + dato1; incremento

            //operador evaluacion de operadores numericos
            float dato2 = 4/3 * 2f;
            float dato3 = 4f * (2 / 3f);
            float dato4 = 4f + 6 * 2f;
            float dato5 = (4f - 6) * 2 + 3f;
            float dato6 = dato2 * dato3 - dato4 / dato5;
            //Operadores logicos
            //Conjuncion - AND - Y - &&
            Console.WriteLine("-------------TABLA DE LA CONJUNCION----------------");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("---------------------------------------------------");
            //Disyuncion - OR - O - ||
            Console.WriteLine("-------------TABLA DE LA DISYUNCION----------------");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("---------------------------------------------------");
            //Negacion - NOT - NO - !
            Console.WriteLine("-------------TABLA DE LA NEGACION------------------");
            Console.WriteLine("!V = " + (!true));
            Console.WriteLine("!F = " + (!false));
            Console.WriteLine("---------------------------------------------------");

            //OPERADORES COMPARACION
            bool dato7 = true;
            bool dato8 = !dato7;
            bool dato9 = 5 > 4;
            bool dato10 = 100 <= 99;
            bool dato11 = 25 == 25;//esto es igual a
            bool dato12 = 4 != 4;//esto es diferente de
            bool dato13 = 5 < 4 && dato7 ;
            bool dato14 = 0 == 1 || 12 > 3 && dato9;


        }
    }
}
