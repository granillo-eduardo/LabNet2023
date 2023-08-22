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

            Console.Write(" Ingrese un valor para el dividendo : ");
            dividendo = Convert.ToDecimal(Console.ReadLine());

            Console.Write(" Ingrese un valor para el divisor : ");
            divisor = Convert.ToDecimal(Console.ReadLine());

            //Dividir(dividendo, divisor);

            ExceptionsClass.Dividir(dividendo,divisor);
            Console.ReadKey();
        }
        #region MyRegion
        //public static void Dividir(string dividendo, string divisor)
        //{
        //    try
        //    {
        //        Double resultado;

        //        resultado = Convert.ToDouble(dividendo) / Convert.ToDouble(divisor);
        //        Console.WriteLine($"\n {dividendo} / {divisor} = {resultado}");
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("\n “¡Solo Chuck Norris divide por cero!” ");
        //    }
        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine($"Secapturo {ex.Message}");
        //        //Console.WriteLine(Environment.NewLine);
        //        Console.WriteLine($"Stack {ex.StackTrace}");
        //    }
        //    //catch (FormatException ex)
        //    //{
        //    //    Console.WriteLine($"\n “¡Seguro Ingreso una letra o no ingreso nada!”. \n {ex.Message}");
        //    //}

        //    //catch (Exception ex)
        //    //{
        //    //    //excepcion propia
        //    //    Console.WriteLine("\n " + ex.Message);               
        //    //}
        //    finally
        //    {
        //        Console.WriteLine("\n Finalizo la operación");
        //    }

        //}
        #endregion 

    }
}
