using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CondicionalesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos, mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje "Persona exenta de impuestos".*//*

            string nombre = " ";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el valor del sueldo");
            sueldo = Single.Parse(Console.ReadLine());//Convertir a float utilizando la clase single

            if (sueldo>=3000)
            {
                //Cuando la condición es VERDADERA
                Console.WriteLine($"La persona {nombre} debe abonar impuestos");
            }
            else
            {
                //Cuando la condición es FALSA
                Console.WriteLine("Persona exenta de impuestos");
            }*/

            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Ingrese primer número");
            n1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número");
            n2 = Single.Parse(Console.ReadLine());

            if (n1 >= n2)
            {
                n1 += n2;

                Console.WriteLine("La suma etre el primer y el segundo número es", n1+=n2);
                
                n1 -= n2;

            }

        }
    }
}
