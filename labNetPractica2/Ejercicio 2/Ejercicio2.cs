using lanNetPractica2;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1;

namespace Ejercicio_2
{
    public class Ejercicio2
    {
        static void Main(string[] args)
        {  
            Decimal dividendo;
            Decimal divisor;

            try
            {
                Console.Write(" Ingrese un valor para el dividendo : ");
                dividendo = Convert.ToDecimal(Console.ReadLine());
                
                Console.Write("\n Ingrese un valor para el divisor : ");
                divisor = Convert.ToDecimal(Console.ReadLine());

                ExceptionsClass.Dividir(dividendo, divisor);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"\n {ex.Message}");
                Console.WriteLine("\n ¡Seguro Ingreso una letra o no ingreso nada!");
            }           

            Console.ReadKey();
        }
        

    }
}
