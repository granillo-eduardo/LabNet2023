using lanNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_3;

namespace Ejercicio_3
{
    internal class Presentacion
    {
        static void Main(string[] args)
        {
            try
            {
                Logic.DispararExcepcion();                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Se caputuro la exception : '{ex.Message}'");
                Console.WriteLine($"\n La excepcion es del tipo: {ex.GetType().Name}");   
            }
            
            Console.ReadKey();  
        }
    }
}
