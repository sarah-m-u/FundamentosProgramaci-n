using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.ProgramaciónModular
{
    internal class Program
    {
        static string nombre = "pepe";
        static string apellido = "pepe";
        static void Main(string[] args)
        {
            //programación modular
            //procedimientos sin parámetros
            BorrarPantalla();
            Saludo();
            Saludo(nombre, apellido);
            Console.ReadKey();
            Console.WriteLine($"edad: {CalcularEdad()}");
            Console.WriteLine($"Edad;{CalculadEdadAñoNaciomiento(2026, 1981)}");
        }
            static void BorrarPantalla()
            {
                Console.Clear();
            }
            static void Saludo()
            {
                string nombre = "Pepe";
                Console.WriteLine($"Bienvenido a la clase de programación modular {nombre}");
            }
            //Procedimientos con parámetros 
            static void Saludo (string nombre, string apellidos)
            {

                Console.WriteLine($"Bienvenido a la clase de programación modular {nombre}");
            }
            //funciones sin parámetros

            static int CalcularEdad()
            {
                int añoActual = 2026;
                int añoNacimiento = 1981;

                int edad = añoActual - añoNacimiento;

                return edad;
            }
            //funciones con parámetros
            static int CalculadEdadAñoNaciomiento(int añoActual, int añoNacimiento)
            {
                return añoActual - añoNacimiento;
            }

        }
    }

