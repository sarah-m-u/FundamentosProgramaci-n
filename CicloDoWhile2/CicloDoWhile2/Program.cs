using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloDoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14, crear un algoritmo que permita calcular y mostrar por pantalla los números primos hasta el número 100
            int contadorNumeros = 1;
            int contador = 1;
            int divisores = 0;
            do
            {
                do
                {
                    if (contadorNumeros % contador == 0)
                    {
                        divisores++;
                      
                    }
                    contador++;
                    Console.WriteLine($"Residuo: {contadorNumeros%contador}%{contadorNumeros%contador}");

                } while (contador <= contadorNumeros);
                contador = 1;
              
                
                if (divisores==2)
                {
                    Console.WriteLine(contadorNumeros);
                }
                divisores = 0;
                
                contadorNumeros++;

            } while (contadorNumeros <= 100);*

            /*Escribe un algoritmo que actue como una calculadora básica. El algoritmo le debe permitir al usuario elegir una operación (suma, resta, multiplicación, división), y luego debe ingresar dos números, el ciclo debe continuar permitiendo al usuario realizar más cálculos hasta que elija salir

            int num1 = 0;
            int num2 = 0;
            char suma = 's';
            char resta = 'r';
            char multiplicacion = 'm';
            char division = 'd';

            Console.WriteLine("Elija el tipo de operación que desea realizar");
            Console.ReadLine();*/

            /*Crear un algoritmo que permita ingresar los números:
             contar cuántos son pares y cuántos son impares
            calcular el promedio de todos los números ingresados
            terminar cuando el usuario lo indique*/

            int numero = 0;
            int suma = 0;
            int contadorNumeros = 0;
            int par = 0;
            int impar = 0;
            string continuar;
         

            do
            {
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());

                contadorNumeros++;

                if (numero % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                Console.WriteLine("Desea seguir ingresando números? Ingrese si o no dependiendo de su respuesta");
                continuar = Console.ReadLine();

            } while (continuar == "si");

            if (contadorNumeros != 0)
            { 
            
            }

        }
    }
}
