using Herencia.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.ClaseHIja
{
    internal class Xbox:CLSConsola 
    {
        public bool TieneHalo { get; set; }
        public string MostrarDetalleXbox()
        {
            return MostrarDetalles() + " Tiene Halo: " + TieneHalo;
        }
    }
}
