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
        #region 
        //public static void ThrowExceptions(int valor)
        //{
        //    try
        //    {
        //        int resultado;
        //        Console.WriteLine($"\n {valor} / 0 = ");
        //        resultado = valor / 0;

        //        //Console.WriteLine($"\n {valor} / 0 = {resultado}");
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("\n " + ex.Message);
        //        //throw ex.Message;
        //    }

        //    finally
        //    {
        //        Console.WriteLine("\n Finalizo la operación");
        //    }

        //    Console.ReadKey();
        //}
        #endregion
        
    }
}
