using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCondicionales2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            int x3 = 0;
            int y3 = 0;
            float distanciaP1P2 = 0;
            float distanciaP1P3 = 0;
            float distanciaP2P3 = 0;

            Console.WriteLine("Ingrese tres coordenadas x,y");
            Console.WriteLine("Ingrese el valor de x de la primera coordenada");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y de la primera coordenada");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de x de la segunda coordenada");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y de la segunda coordenada");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de x de la tercera coordenada");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y de la tercera coordenada");
            y3 = Convert.ToInt32(Console.ReadLine());

            distanciaP1P2 = ((float)Math.Sqrt(((x2 - x1)* (x2 - x1))+ ((y2 - y1) * (y2 - y1))));
            distanciaP1P3 = ((float)Math.Sqrt(((x3 - x1) * (x3 - x1)) + ((y3 - y1) * (y3 - y1))));
            distanciaP2P3 = ((float)Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2))));

            if (distanciaP1P2 + distanciaP1P3 > distanciaP2P3 && distanciaP1P3 + distanciaP2P3 > distanciaP1P2 && distanciaP1P2 + distanciaP2P3 > distanciaP1P3)
            {
                Console.WriteLine("Los puntos pueden formar un triangulo, ya que P1 + P2 > P3, P2 + P3 > P1 y P1 + P3 > P2");
            }
            else
            {
                Console.WriteLine("Los puntos no pueden formar un triángulo ya que no cumple P1 + P2 > P3, P2 + P3 > P1 y P1 + P3 > P2");
            }


            char MovPersonaje = ' ';

            Console.WriteLine("El personaje del juego se  mueve de forma horizontal, presiona d para moverlo a la derecha y presiona i para moverlo a la izquierda");
            MovPersonaje = char.Parse(Console.ReadLine());
       
            switch (MovPersonaje)
            {
                case 'd':
                    MovPersonaje = 'd';
                    Console.WriteLine("El personaje se mueve hacia la derecha");
                    break;
                case 'i':
                    MovPersonaje = 'i';
                    Console.WriteLine("El personaje se mueve hacia la izquierda");
                    break;

                default:
                    Console.WriteLine("El personaje no puede moverse a esa dirección");

                    break;*/

            int vidas;
            char acciones = ' ';

            Console.WriteLine("Elige la acción que quieres que realice tu personaje, si este posee vidas, puede realizarlo. Ingresa c = disparar, x = hablar con la Rana, t = Activar modo turbo, i = Invicibilidad");
            acciones = char.Parse(Console.ReadLine());

            Random rnd = new Random();
            vidas = rnd.Next(0, 5);
           
            if (vidas > 0)
            {
                Console.WriteLine($"El personaje tiene {vidas} vidas");
                switch (acciones)
                {
                    case 'c':
                        acciones = 'c';
                        Console.WriteLine("El personaje está disparando");
                        break;

                    case 'x':
                        acciones = 'x';
                        Console.WriteLine("El personaje está hablando con la rana");
                        break;

                    case 't':
                        acciones = 't';
                        Console.WriteLine("El personaje está en modo Turbo");
                        break;

                    case 'i':
                        acciones = 'i';
                        Console.WriteLine("El personaje es invencible");
                        break;

                    default:
                        Console.WriteLine("Por favor ingrese una acción válida");

                        break;
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas, no puede realizar ninguna acción");
            }
        }
    }
    }

