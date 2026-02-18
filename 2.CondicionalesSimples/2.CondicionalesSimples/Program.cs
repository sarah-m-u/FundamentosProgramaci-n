using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   string nombre = " ";
               float sueldo = 0;
               Console.WriteLine("Ingrese el nombre de usuario");
               nombre = Console.ReadLine();//Todo lo que el usuario ingresa desde la consola llega como una cadena de crácteres

               Console.WriteLine("Ingrese el valor del sueldo");
               sueldo = Convert.ToSingle (Console.ReadLine() );


               if (sueldo>=3000)
               {
                   Console.WriteLine($"Elusuario {nombre}, debe abonar impuestos");
               }*/

            float edad = 0;
            Console.WriteLine("Ingrese edad del usuario");
            edad = Convert.ToSingle(Console.ReadLine());

            if (edad>=18)
            {
                Console.WriteLine($"Bienvenido a mi sitio web");
            }

        }
    }
}
