using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor=0;

            Console.Write(" Ingrese un valor numérico entero : ");
            valor = int.Parse(Console.ReadLine());

            ThrowExceptions(valor);

        }
        public static void ThrowExceptions(int valor)
        {
            try
            {
                int resultado;
                Console.WriteLine($"\n {valor} / 0 = ");
                resultado = valor / 0;

                //Console.WriteLine($"\n {valor} / 0 = {resultado}");
            }
     
            catch (Exception ex) 
            {
                Console.WriteLine("\n "+ ex.Message);
                //throw ex.Message;
            }

            finally
            {
                Console.WriteLine("\n Finalizo la operación");
            }

            Console.ReadKey();
        }
        
    }
}
