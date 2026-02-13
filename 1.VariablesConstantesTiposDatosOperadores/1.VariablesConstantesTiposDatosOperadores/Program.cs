using System;
using System.Data;
using System.Runtime.InteropServices;


namespace _1.VariablesConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES NUMÉRICOS
            //Cambio de signo
            int dato1 = 5;
            int dato2 = -dato1;
            Console.Write(dato1 + "//" + dato2);
            //Aritméticos
            int dato3 = 5 + 6;
            int dato4 = 120 - 231;
            int dato5 = 12 * 56;
            float dato6 = 5f / 3f; //(5 / 3f); (5f /3); (float) 5 / 3;
            Console.Write("\nsuma: {0}, Resta:{1}, Multiplicar: {2}, División; {3}", dato3,dato4,dato5,dato6);
            //incremento - decremento
            dato3++; //dato3 = dato3+1;
            Console.WriteLine("\nIncremento: {0}", dato3);
            dato4--;// dato4 = dato4-1;
            Console.WriteLine("Decremento: {0}", dato4);
            dato5 += 4; //dato5 = dato5+4;
            dato3 -= 5; //dato3 = dato3-5;
            dato5 *= dato3;//dato=dato5*dato3;
            dato6 /= dato3; //dato6=dato6/dato3;
            //orden de evaluación operadores númericos
            float dato7 = 4 * 3 / 2;
            Console.WriteLine(dato7);
            float dato8 = 4f * (3.0f / 5.0f);
            Console.WriteLine(dato8);
            float dato9 = 4 + 6 * (2 - 1);
            Console.WriteLine(dato9);
            //operadores lógicos - conjunción (y) _ disyunción (O)
            Console.WriteLine("TABLA DE CONJUNCIÓN");
            Console.WriteLine("V Y V = " + (true && true));
            Console.WriteLine("V Y f = " + (true && false));
            Console.WriteLine("F Y V = " + (false && true));
            Console.WriteLine("F Y F = " + (false && false));
            Console.WriteLine("-----------------");

            Console.WriteLine("TABLA DE DISYUNCIÓN");
            Console.WriteLine("V O V = " + (true || true));
            Console.WriteLine("V O f = " + (true || false));
            Console.WriteLine("F O V = " + (false || true));
            Console.WriteLine("F O F = " + (false || false));
            Console.WriteLine("-----------------");

            //OPERADORES DE COMPARACIÓN

            bool dato10 = 5 > 3;
            Console.WriteLine(dato10);
            bool dato11 = 4 < -32;
            Console.WriteLine(dato11);
            bool dato12 = 5 <= -5;
            Console.WriteLine(dato12);
            bool dato13 = 4 != 4;
            Console.WriteLine(dato13);
            bool dato14 = dato10 && dato11 || dato12;
            Console.WriteLine(dato14);


        }
    }
}
