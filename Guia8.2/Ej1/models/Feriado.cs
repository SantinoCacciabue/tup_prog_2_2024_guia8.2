using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Feriado
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public Feriado(DateTime fecha, string descripcion)
        {
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }
}
