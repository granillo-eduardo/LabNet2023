using lanNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Presentacion
    {
        static void Main(string[] args)
        {
            try
            {
                ExceptionsClass.ThrowCustomExeption();
            }
            catch (Logic ex)
            { 
                
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Se caputuro la exception custom: '{ex.Message}'");
                Console.WriteLine(ex.ToString());
            }
            
            Console.ReadKey();  
        }
    }
}
