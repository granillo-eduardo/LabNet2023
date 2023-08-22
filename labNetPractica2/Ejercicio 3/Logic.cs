using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public class Logic: Exception
    {
        public Logic() :base("Mensaje de Error personalizada")
        { 
        
        }
    }
}
