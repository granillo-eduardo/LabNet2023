using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanNetPractica2
{
    public class ExceptionsClass:Exception
    {
        public static void Dividir(int valor)
        {
            string mensaje="";

            try
            {
                int resultado;
                Console.WriteLine($"\n {valor} / 0 = ");
                resultado = valor / 0;

                mensaje="La operacion fue exitosa";
            }

            catch (Exception ex)
            {
                Console.WriteLine("\n " + ex.Message);
                mensaje = "La operacion no fue exitosa";
            }

            finally
            {
                Console.WriteLine($"\n Finalizo:  {mensaje} ");
            }

        }

        public static void Dividir(Decimal dividendo, Decimal divisor)
        {
            try
            {
                Decimal resultado;
              
                resultado = dividendo / divisor;
                Console.WriteLine($"\n {dividendo} / {divisor} = {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n “¡Solo Chuck Norris divide por cero!” ");
            }
            catch (Exception ex)
            {   
                Console.WriteLine($"Stack {ex.StackTrace}");
            }
            
            finally
            {
                Console.WriteLine("\n Finalizo la operación");
            }

        }

        public static void ThrowCustomExeption()
        {
            throw new Exception();
        }
    }

}

    

