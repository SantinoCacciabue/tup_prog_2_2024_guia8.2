using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.models
{
    internal class Cuota
    {
        public int Numero { get; private set; }
        public double ValorAPagar { get; private set; }
        public DateTime FechaPago { get; private set; }
        public Cuota(int nro,double valorAPagar, DateTime f)
        {
            FechaPago = f;
            ValorAPagar = valorAPagar;
            Numero = nro;
        }
        public override string ToString()
        {
            return $"Cuota: {Numero+1}({FechaPago}) ${ValorAPagar:F2}";
        }

    }
}
