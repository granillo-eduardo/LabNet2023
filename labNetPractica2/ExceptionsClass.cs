using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanNetPractica2
{
    public class ExceptionsClass
    {
        public static void Dividir(int valor)
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
                Console.WriteLine("\n " + ex.Message);
                //throw ex.Message;
            }

            finally
            {
                Console.WriteLine("\n Finalizo la operación");
            }

        }

        public static void Dividir(Decimal dividendo, Decimal divisor)
        {
            try
            {
                Decimal resultado;
                //divisor = 0;
                //resultado = 15 / divisor;
                resultado = dividendo / divisor;
                Console.WriteLine($"\n {dividendo} / {divisor} = {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n “¡Solo Chuck Norris divide por cero!” ");
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Secapturo {ex.Message}");
                //Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"Stack {ex.StackTrace}");
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"\n “¡Seguro Ingreso una letra o no ingreso nada!”. \n {ex.Message}");
            //}

            //catch (Exception ex)
            //{
            //    //excepcion propia
            //    Console.WriteLine("\n " + ex.Message);               
            //}
            finally
            {
                Console.WriteLine("\n Finalizo la operación");
            }

        }
    }

}

    

