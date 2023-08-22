using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class ExceptionCustom : Exception
    {
        //misma clase tendrá un constructor con un parámetro del tipo
        // string donde se permitirá ingresar un mensaje personalizado. También se debe hacer 
        // una sobrecarga al “Message” Agregando algún mensaje al comienzo del mensaje de la 
        // clase base. Mostrar el mensaje de la excepción en una caja de texto.

        public ExceptionCustom(string message) : base(message)
        {
                
        }
    }
}
