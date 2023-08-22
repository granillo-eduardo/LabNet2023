using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1;
using lanNetPractica2;

namespace Ejercicio1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int valor = 0;

            Console.Write(" Ingrese un valor numérico entero : ");
            valor = int.Parse(Console.ReadLine());
            
            ExceptionsClass.Dividir(valor);

            Console.ReadKey();
        }
        
    }
}
