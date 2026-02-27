using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CondicionalesMúltiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*char diaSemana = ' ';
            float totalCompra = 0;
            float descuento = 0;
            Console.WriteLine("Ingrese el dia de la semana. l=luenas, m=martes, x=miércoles, j=jueves, v=viernes, s=sábado, d=domingo");
            diaSemana = Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de la compra");
            totalCompra = Single.Parse(Console.ReadLine());

            switch (diaSemana)
            {
                case 'l':
                    descuento = totalCompra * 0.1f;
                    Console.WriteLine($"Hoy es Lunes, el descuento es de {descuento}, el total de la compra es {totalCompra}");
                    break;
                case 'm':
                    descuento = totalCompra * 0.15f;
                    Console.WriteLine($"Hoy es Martes, el descuento es de {descuento}, el total de la compra es {totalCompra}");
                    break;
                case 'x':
                    descuento = totalCompra * 0.1f;
                    Console.WriteLine($"Hoy es Miércoles, el descuento es de {descuento}, el total de la compra es {totalCompra}");
                    break;
                case 'j':
                    descuento = totalCompra * 0.15f;
                    Console.WriteLine($"Hoy es Jueves, el descuento es de {descuento}, el total de la compra es {totalCompra}");
                    break;
                case 'v':
                    descuento = totalCompra * 0.2f;
                    Console.WriteLine($"Hoy es Viernes, el descuento es de {descuento}, el total de la compra es {totalCompra}");
                    break;
                case 's':
                    descuento = totalCompra * 0.2f;
                    Console.WriteLine($"Hoy es Sábado, el descuento es de {descuento}, el total de la compra es {totalCompra}");
                    break;
                case 'd':
                    descuento = 0;
                    Console.WriteLine($"Hoy es Domingo, el descuento es de {descuento}, el total de la compra es {totalCompra}");
                    break;
                default:
                    Console.WriteLine("Seleccione un día correcto de la semana");
                    break;*/

            /*char operacion = ' ';
            float primerNumero = 0;
            float segundoNumero = 0;
            float resultado = 0;
            Console.WriteLine("Ingrese la operación a realizar. s=Suma, r=Resta, m=Multiplicación, d=División");
            operacion = Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer número de la operación");
            primerNumero = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número de la operación");
            segundoNumero = Single.Parse(Console.ReadLine());

            switch (operacion)
            {
                case 's':
                    resultado = primerNumero + segundoNumero;
                    Console.WriteLine($"El resultado entre la suma entre ambos números es {resultado}");
                    break;
                case 'r':
                    resultado = primerNumero - segundoNumero;
                    Console.WriteLine($"El resultado entre la resta entre ambos números es {resultado}");
                    break;
                case 'm':
                    resultado = primerNumero * segundoNumero;
                    Console.WriteLine($"El resultado entre la multiplicación entre ambos números es {resultado}");
                    break;
                case 'd':
                    resultado = primerNumero / segundoNumero;
                    Console.WriteLine($"El resultado entre la división entre ambos números es {resultado}");
                    break;
                default:
                    Console.WriteLine("Seleccione la operación correcta a realizar");
                    break;*/

            /*int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Ingrese el valor del número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 > num2 ? $"El número mayor es: {num1}" : $"El número mayor es: {num2}");*/

            /*if (num1>num2)
            {
                Console.WriteLine($"El número mayor es: num1");
            }
            else
            {
                Console.WriteLine($"El número mayor es: num2");
            }*/

            int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(edad > 18 ? "Bienvenido a mi sitio web" : "No es apto para el contenido de este sitio web" );

        }

            }
        }
    
