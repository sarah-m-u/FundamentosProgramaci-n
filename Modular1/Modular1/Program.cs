using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            int opcion = CapturarOpcion();
            RealizarOperacion(opcion);
        }
    
    static void MostrarMenu()
        {
            Console.WriteLine("------------------MENÚ OPERACIONES------------------");
            Console.WriteLine("1. Suma                       2. Resta              ");
            Console.WriteLine("3. Multiplicación             4. División           ");
            Console.WriteLine("----------------------------------------------------");
        }

        static int CapturarOpcion()
        {
            Console.WriteLine("Ingrese una opción del menú");
            return int.Parse(Console.ReadLine());
        }
        static void RealizarOperacion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                default:
                    break;
            }
        }
        static void Suma()
        {
            Console.WriteLine("Usted va a sumar");
        }
        static void resta ()
        {
            Console.WriteLine("Usted va a restar");
        }
        static void multiplicacion()
        {
            Console.WriteLine("Usted va a multiplicar");
        }
        static void Division()
        {
            Console.WriteLine("Usted va a dividir");
        }
    }
}

