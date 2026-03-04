using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //punto1
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese tres valores diferentes entre sí");

            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine($"El número mayor entre los tres es: {num1}");
                }
                else
                if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"El número mayor entre los tres es: {num2}");
                }
                else
                if (num3 > num2 && num3 > num1)
                {
                    Console.WriteLine($"El número mayor entre los tres es: {num3}");
                }

                if (num1 > num2 && num2 > num3)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor irían: {num3}, {num2}, {num1}");
                }
                else

                if (num2 > num1 && num1 > num3)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor irían: {num3}, {num1}, {num2}");
                }
                else

                if (num3 > num2 && num2 > num1)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor irían: {num1}, {num2}, {num3}");
                }
                else

                 if (num1 > num3 && num3 > num2)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor irían: {num2}, {num3}, {num1}");
                }
                else

                 if (num2 > num3 && num3 > num1)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor irían: {num1}, {num3}, {num2}");
                }

            }
            else
            
            if (num1 == num2 && num1 == num3 && num2 == num3)
            {
                Console.WriteLine("Debe ingresar 3 números diferentes entre sí");
            }*/

            //punto2

            int estado = 0;
            int numero;

            Console.WriteLine("Ingrese el estado del personaje: 1 = Invencible / 2 = Vencible ");
            estado= int.Parse(Console.ReadLine());

            Random rnd = new Random();
            numero = rnd.Next(1, 10);
            Console.WriteLine(numero);

            if (estado == 1 && numero > 0)
            {
                Console.WriteLine("El estado del personaje es Invensible y tiene munición, por lo que está disparando");
            }
            else

            if (estado != 1 && numero < 0)

            {
                Console.WriteLine("El personaje no se encuentra disparando");
            }
        }
    }
}
