using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1.models
{
    internal class PlanDePago:IComparable
    {
        private List<Cuota> cuotas = new List<Cuota>();
        public Infractor Destinatario;
        private int cantCuotas;
        public int CantidadCuotas
        {
            get
            {
                return cantCuotas;
            }
            set
            {
                cantCuotas = value;
            }
        }
        public DateTime FechaAlta { get;private set; }
        private DateTime PrimerDiaHabilMesSiguiente(DateTime actual,Calendario feriado)
        {
            actual = DateTime.Now;
            DateTime fecha = new DateTime(actual.Year, actual.Month, 1);
            fecha.AddMonths(1);
            fecha = DeterminarDiaHabil(actual, feriado);
            return fecha;


        }
        private DateTime DeterminarDiaHabil(DateTime actual,Calendario feriado)
        {
            actual = DateTime.Now;
            if(actual.DayOfWeek == DayOfWeek.Sunday || actual.DayOfWeek == DayOfWeek.Saturday || feriado[actual] != null)
            {
                actual = DeterminarDiaHabil(actual.AddDays(1),feriado);
            }
            return actual;
        }
        private DateTime CalcularFechaVenc(DateTime mesActual, int cantDiasHabiles,Calendario feriado)
        {
            DateTime venc = mesActual;
            int diasHabiles = 1;
            while (diasHabiles < cantDiasHabiles)
            {
                if (feriado[diasHabiles] != null)
                {
                    venc.AddDays(1);
                }
                diasHabiles++;
            }
            return venc;
        }
        public PlanDePago(double monto, int cantCuot, DateTime fechaAlta, Infractor destinatario, Calendario calendario)
        {
            Destinatario = destinatario;
            cantCuotas = cantCuot;
            FechaAlta = fechaAlta;

            if (cantCuotas == 0)
                throw new Exception("La cantidad de cuotras debe ser mayor a cero");

            double montoCuota = monto / cantCuotas;

            DateTime fechaMesProximo = PrimerDiaHabilMesSiguiente(fechaAlta, calendario);

            int nroCuota = 1;
            while (nroCuota <= cantCuotas)
            {
                DateTime primerVenc = CalcularFechaVenc(fechaMesProximo, 8, calendario);
                DateTime segundoVenc = CalcularFechaVenc(primerVenc, 15, calendario);

                Cuota cuota = new Cuota(nroCuota, montoCuota, primerVenc, segundoVenc);

                cuotas.Add(cuota);

                fechaMesProximo = PrimerDiaHabilMesSiguiente(fechaMesProximo, calendario);
                nroCuota++;
            }
        }



    }
}
