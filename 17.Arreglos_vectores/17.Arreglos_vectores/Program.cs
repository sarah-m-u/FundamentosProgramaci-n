using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Arreglos_vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //vectores
             int[] numeros = new int[4]; //Declarado e iniciando el vector
             //Llenar el vector
             numeros[0] = 15;
             numeros[1] = 3;
             numeros[2] = 4;
             numeros[3] = 18;
             //numeros[4] = 2; el índice 4 está por fuera del rango del vector
             string[] nombres = new string[5];
             //otras formas de declarar e inicializar vectores
             char[] simbolos = new char[] { 'd','%','#','t','w','i' }; //rango 6
             float[] notas = { 4.5f, 2.3f, 1.9f, 3.8f, 4.8f };
             string [] estudiantes = new string[7];
             //recorrer el vector estudiantes para llenarlo

             for (int i = 0; i < 7; i++)
             {
                 Console.WriteLine($"ingrese el nombre para la posicion {i + 1} con indice {i}");
                 estudiantes[i]=Console.ReadLine();
             }
             //Recorrer para recuperar los valores que hay en cada posicion guardados
             for (int i = 0;i < numeros.Length ;i++)
             {
                 Console.Write(numeros[i] + "|");
             }

            //crear un arreglo llamado "numeros" de 100 elementos asignar el numero 10 en cada una de las posiciones del arreglo.Leer el contenido de cada elemento y escribirlo en pantalla

            int[] numeros = new int[100];

      
            for (int i = 0; i < 100; i++)
            {
                numeros[i] = 10;
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Posicion {i}: {numeros[i]}");
            } */

            //Llene un arreglo con 15 numeros ingresados por teclado, una vez registrado el total de valores. muestre en pantalla todos los elementos del arreglo, finalmente determine cual es el numero mayor y cual es el numero menor, junto con la posicion que ocupa cada uno dentro del arreglo
            int[] numeros = new int[15];
            int mayor = 0;
            int menor = 0;
            int[] posiciones = new int [2];


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para la posicion {i + 1} con indice {i}");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(numeros[i] + "|");

                if (i == 0)
                {
                    mayor = numeros[0];
                    menor = numeros[0];
                    posiciones[0] = i;
                    posiciones[1] = i;
                }

                else
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                        posiciones[0] = i;
                    }
                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                        posiciones[1] = i;
                    }
                }

                for (int i = 0; i < numeros.Length;i++)
                {
                    Console.Write(numeros[i] + "|");
                }

                Console.WriteLine($"\nEl numero mayor es {mayor} en la posicion {posiciones[0]+1}");
                Console.WriteLine($"\nEl numero mayor es {menor} en la posicion {posiciones[1] + 1}");
            }
        }
    }
            
}
