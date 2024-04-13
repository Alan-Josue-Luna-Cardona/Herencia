using Herencia.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.ClaseHIja
{
    internal class Nintendo : CLSConsola
    {
        public bool esPortable { get; set; }
        public string MostrasDetallesNintendo()
        {
            string detallePadre = MostrarDetalles();
            return detallePadre+" Es portable: "+esPortable;
        }
    }
}
