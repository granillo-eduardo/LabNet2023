using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logic.ThrowExceptionsCustom("Mensaje de Excepcion propia");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Se caputuro la exception : '{ex.Message}' ");
                Console.WriteLine($"\n Excepcion de tipo: {ex.GetType().Name}");
            }

            Console.ReadKey();
        }
    }
}
