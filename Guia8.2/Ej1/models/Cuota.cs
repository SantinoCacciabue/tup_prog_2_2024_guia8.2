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
                return MontoBase + MontoVoluntario;
            }
        }
        public DateTime FechaSegundoVencimiento { get; set; }
        public double MontoSegundoVen
        {
            get
            {
                return MontoBase + MontoVoluntario;
            }
        }
        public double MontoSegundoVencConSobr
        {
            get
            {
                return MontoSegundoVen + (MontoSegundoVen * 0.2);
            }
        }
        public Cuota(int numero, double montoBase, DateTime fechaPrimerVencimiento, DateTime fechaSegundoVencimiento)
        {
            Numero = numero;
            MontoBase = montoBase;
            FechaPrimerVencimiento = fechaPrimerVencimiento;
            FechaSegundoVencimiento = fechaSegundoVencimiento;
        }
        public override string ToString()
        {
            string linea = $@"{$"Cuota número: {Numero}"}
{$"Valor Cuota: ",-33}${MontoBase,15:f2}
{$"Donación voluntaria: ",-33}${MontoVoluntario,15:f2}
{$"Primer Venc. ({FechaPrimerVencimiento:dd/MM/yy})",-33}${MontoPrimerVen,15:f2}

{$"Base. segundo Venc. ",-33}${MontoSegundoVen,15:f2}
{$"Segundo Venc con sobrecargo. ({FechaSegundoVencimiento:dd/MM/yy})",-33}${MontoSegundoVencConSobr,15:f2}";
            return linea;
        }
    }
}
