using labNetPractica1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> colectivos = new List<TransportePublico>();
            List<TransportePublico> moviles = new List<TransportePublico>();

            int cantidadPasajerosOmnibus = 1;
            int cantidadPasajerosTaxi = 1;

            int contador = 0;
            int contador2 = 1;

            while (cantidadPasajerosOmnibus < 6)
            {
                Console.WriteLine("                     Ingrese la candidad de pasajeros del Omnibus: {0}", cantidadPasajerosOmnibus);

                int cantidad = int.Parse(Console.ReadLine());

                if (cantidad <= 100)
                {
                    if (cantidad >= 0)
                    {
                        colectivos.Add(new Omnibus(cantidad));
                        cantidadPasajerosOmnibus++;
                    }
                    else
                    {
                        Console.WriteLine("                         Ingrese una cantidad de pasajeros válida");
                    }

                }
                else
                {
                    Console.WriteLine("                     Ingrese una cantidad de pasajeros inferior a 100");
                }
            }

            Console.WriteLine("\n");

            while (cantidadPasajerosTaxi < 6)
            {
                Console.WriteLine("                    Ingrese la candidad de pasajeros para el taxi: {0}", cantidadPasajerosTaxi);
                int cantidad = int.Parse(Console.ReadLine());

                if (cantidad <= 5)
                {
                    if (cantidad >= 0)
                    {
                        moviles.Add(new Taxi(cantidad));
                        cantidadPasajerosTaxi++;
                    }
                    else
                    {
                        Console.WriteLine("                        Ingrese una cantidad de pasajeros válida");
                    }

                }
                else
                {
                    Console.WriteLine("                     Ingrese una cantidad de pasajeros inferior a 5");
                }

            }

            Console.WriteLine("\n                            LISTA DE PASAJEROS DE OMNIBUS \n");


            foreach (var item in colectivos)
            {
                contador++;
                Console.WriteLine("                               OMNIBUS {1}             {0}", item.pasajeros, contador);
            }

            Console.WriteLine("\n                             LISTA DE PASAJEROS DE TAXIS \n");

            foreach (var item in moviles)
            {
                Console.WriteLine("                                TAXI {0}                {1}", contador2, item.pasajeros);
                contador2++;
            }

            Console.ReadKey();

        }
    }
}
