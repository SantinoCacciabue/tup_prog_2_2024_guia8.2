using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Cuota
    {
        public int Numero { get; private set; }
        private double montoBase;
        public double MontoBase
        {
            get
            {
                return montoBase;
            }
            set
            {
                montoBase = value;
            }
        }
        public double MontoVoluntario
        {
            get
            {
                return montoBase * 0.05;
            }
        }

        public DateTime FechaPrimerVencimiento { get; set; }
        public double MontoPrimerVen
        {
            get
            {
                return MontoBase * 0.2;
            }
        }

    }
}
