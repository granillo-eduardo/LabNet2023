using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanNetPractica2
{
    public class Divisions
    {
        public static void DividirEnCero(decimal valor)
        {
            int divisor = 0;
            decimal dividendo;

            if (divisor == 0)
            {
                try
                {
                    dividendo = valor / divisor;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public static decimal Dividir(decimal valor1, decimal valor2)
        {
            return valor1 / valor2;
        }
            }
}
