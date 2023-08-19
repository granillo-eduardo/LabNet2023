using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public abstract class TransportePublico
    {
        //PROPIEDADES DE LA CLASE
        public int pasajeros { get; set; }

        //CONSTRUCTORES
        public TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros; //CANTIDAD DE PASAJEROS 
        }

        //METODOS
        public abstract bool Avanzar();

        public abstract bool Detenerse();

    }
}


