using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritno que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario ingresar tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas anteriormente
            /*double calificaciones;
            double suma = 0;
            int contador = 0;
            string opcion;
            double promedio = 0;

            do
            {
                Console.WriteLine("Ingrese una calificación: ");
                calificaciones = double.Parse(Console.ReadLine());

                suma += calificaciones;
                contador++;

                Console.WriteLine("Desea ingresar otra calificación, s= si o n= no");
                opcion = Console.ReadLine();

            } while (opcion == "s");

            if (contador != 0)
            {
                promedio = suma / contador;
            }
            Console.WriteLine($"el promedio es: {promedio}");

            se requiere un algoritmo para demostrar por pantalla los divisores de un número ingresado por el teclado. Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/b el residuo es 0, en C# utilizar el operador Mod para obtener el residuo de una división de dos números. Ejemplo si se ingresa 6 por teclado, se debe mostrar 6,3,2 y 1 que son los divisores del número

            int numero = 0;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("divisores del número");

            for (int contador = numero; contador >= 1; contador--)
                if (numero % contador == 0)
                {
                    Console.WriteLine(contador);
                }
            Console.ReadLine();

            Dados dos números enteros ingresados por teclado: b que es la base y e que es el exponente, se requiere calcular el resultado de la potenciación. Ejemplo: b=2, e=5 > 2'5= 2*2*2*2*2=32

            int baseNum;
            int exponente;
            string opcion;
            int resultado;


            do
            {
                Console.WriteLine("ingrese el número base: ");
                baseNum = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el número exponente: ");
                exponente = int.Parse(Console.ReadLine());

                resultado = 1;

                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= baseNum;
                }
                Console.WriteLine($"Resultado: {resultado} ");

                Console.WriteLine("Desea continuar? s=si o n=no");
                opcion = Console.ReadLine();
            } while (opcion != "n");
            Console.ReadLine();
            
             un entrenador le ha propuesto a un atleta recorrer una ruta de cinco kilómetros durante 10 días, para determinar si es apto debe cumplir las siguientes condiciones: que en ninguna de las pruebas haga un tiempo mayor a 20 min, que al menos en una de las pruebas realice un tiempo menor de 15 min, que su promedio sea menor o igual a 18 min. Diseñar un algoritmo para registrar los datos y decidir si es apto para la competencia*/

            double tiempo;
            double suma = 0;
            bool menor15 = false;
            bool mayor20 = false;

            for (int dia = 1; dia <= 10; dia++)
            {
                Console.WriteLine("Ingrese el tiempo del día" + dia + ":"); 
            }
        }

    }
}
