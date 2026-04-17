using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] numeros = new int[2, 3];
            numeros [0, 0] = 15;
            numeros [0, 1] = 15;
            numeros [0, 2] = 23;
            numeros [1, 0] = 36;
            numeros [1, 1] = 22;
            numeros[1, 2] = 100;
            string[,] nombres =
            {
                {"Ferney","Ana" },
                {"Juan", "Carlos" },
                {"Yuli", "Esteban" }
            };
            Char[,] simbolos = new char[2, 5];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Ingrese el simbolos para la p{i}.{j}:");
                    simbolos[ i, j] = char.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            //Recorrer la matriz para recuperar los datos

            for (int i = 0;i < 2;i++) //GetLength(0) obtiene el número de filas
            {
                for (int j = 0;j < 5;j++) //GetLength(1) obtiene el número de columnas 
                {
                    Console.WriteLine(simbolos[i, j] + "|");
                }
                Console.WriteLine();
            }*/

            //Escribe un programa que realice la suma de dos matrices de dimensiones 2x3. Requisitos del programa: Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas; solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3); calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices; Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas)
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] suma = new int[2, 3];


            Console.WriteLine("Ingrese los valores de la PRIMERA matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.WriteLine("Ingrese los valores de la SEGUNDA matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("MATRIZ RESULTADO (SUMA):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(suma[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
