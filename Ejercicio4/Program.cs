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
                Logic.ThrowExceptionsCustom("mensaje propio");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se caputuro la exception : '{ex.Message}'");
                Console.WriteLine(ex.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
