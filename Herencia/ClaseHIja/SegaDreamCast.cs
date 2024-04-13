using Herencia.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.ClaseHIja
{
    internal class SegaDreamCast:CLSConsola
    {
        public bool ControlconPantallita { get; set; }
        public string MostrarDetalleXbox()
        {
            return MostrarDetalles() + " El control tiene Pantallita: " + ControlconPantallita;
        }
    }
}
