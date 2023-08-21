using System;

public class Class1
{
	public Class1()
	{
        public static void Dividir(string dividendo, string divisor)
        {
            try
            {
                Double resultado;

                resultado = Convert.ToDouble(dividendo) / Convert.ToDouble(divisor);
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
