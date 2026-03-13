using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que permita obtener la suma de todos los números impares hasta el 99

            /* int contador = 1;
             int acumulador = 0;


         while (contador <= 99)
             {
                 acumulador += contador;
                 contador += 2;

                 Console.WriteLine($"suma impares: {acumulador}");

             }*/

            /*Realizar un algoritmo que permita al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir
             El algoritmo debe escribir en pantalla:
            La cantidad de números mayores que 0, menores que 0 e iguales a 0*/


            /* int contador = 0;
             int cantidadnumeros = 0;
             int numero = 0;
             int ceros = 0;
             int mayorCero = 0;
             int menorCero = 0;
             Console.WriteLine("El usuario debe ingresar 5 números");
           cantidadnumeros = int.Parse(Console.ReadLine());

             while (contador <= cantidadnumeros)
             {
                 Console.WriteLine($"Ingrese el valor del número {contador}");
                 numero = int.Parse(Console.ReadLine());
                 contador++;

                 if (numero == 0)
                 {
                     ceros++;
                 }
                 else
                 {
                     if (numero > 0)
                     {
                         mayorCero++;
                     }
                     else
                     {
                         menorCero++;
                     }
                 }
                 contador++;
             }
             Console.WriteLine($"Ceros: {ceros}, mayores que cero: {mayorCero}, menores que cero: {menorCero}");*/


            /*Realiza un algoritmo para determinar cuanto ahorrará una persona en un año si al final de cada mes deposita cantidades variables de dinero;
         además, se quiere saber cuánto lleva ahorrado cada mes*/

            float acumuladorAhorro = 0;
            int contadorMeses = 1;
            float ahorro = 0;

            while (contadorMeses <= 12)
            {
                Console.WriteLine($"En el mes {contadorMeses}, cuánto desea ahorrar:");
                ahorro = Single.Parse( Console.ReadLine() );

                acumuladorAhorro += ahorro;

                Console.WriteLine($"Este mes usted ahorro ${ahorro}, para el mes {contadorMeses} usted tiene ahorrado ${acumuladorAhorro}");
                contadorMeses++;
            }


        }
    }
}
