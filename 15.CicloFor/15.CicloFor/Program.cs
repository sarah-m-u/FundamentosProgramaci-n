using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int acumulador = 0;

             for (int contador = 0; contador <=5 ; contador++)
             {
                 acumulador += contador;
             }

             Console.WriteLine($"La suma de los cinco primeros números enteros es {acumulador}");

             Realizar un programa que permita obtener la factorial de un número entero ingresado por teclado 

            int factorial = 1;
            int numero;

            Console.WriteLine("Ingrese un número entero; ");
            numero = int.Parse(Console.ReadLine());

            for (int contador  = 1; contador <= numero; contador++)
            {
                factorial *= contador;
            }
            Console.WriteLine($"El facorial de {numero} es: {factorial}");
            
             Realizar un programa que permita imprimir por pantalla los números múltiplos de 5, el usuario debe ingresar por el teclado el rango de números a evaluar*/

            int numinicial;
            int numfinal;

            Console.WriteLine("ingrese el numero inicial del rango");
            numinicial = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero final del rango");
            numfinal = int.Parse(Console.ReadLine());

            for (int contador = numinicial; contador <= numfinal; contador++)
            {
                if (contador % 5 == 0)
                {
                    Console.WriteLine(contador);
                }
            }



        }
    }
}
