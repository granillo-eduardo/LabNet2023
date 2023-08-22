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
        public ExceptionCustom(string message) : base(message)
        {
                
        }
    }
}
