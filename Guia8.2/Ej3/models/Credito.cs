using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.models
{
    internal class Credito
    {
        public ArrayList cuotas = new ArrayList();
        public Cliente OtorgadoA { get; set; }
        public DateTime OtorgadoEn { get; private set; }
        public double ValorCreditoConIntereses
        {
            get
            {
                double acum = 0;
                foreach(Cuota c in cuotas)
                {
                    acum += c.ValorAPagar;
                }
                return acum;
            }
        }
        public double ValorSolicitado { get; private set; }
        public double TasaAnual { get; private set; }
        public int CantidadCuotas
        {
            get
            {
                return cuotas.Count;
            }
        }
        public Cuota this[int i]
        {
            get
            {
                return cuotas[i] as Cuota;
            }
        }
        public Credito(Cliente otorgadoA, double valorSolicitado, double tasaAnual, int cCuotas)
        {
            OtorgadoA = otorgadoA;
            OtorgadoEn = DateTime.Today;
            ValorSolicitado = valorSolicitado;
            TasaAnual = tasaAnual;

            for(int i = 0;i<cCuotas;i++)
            {
                double valor = CalcularValorCuota(cCuotas);
                DateTime fechaCuota = CalcularFechaPago(i);
                Cuota c = new Cuota(i, valor,fechaCuota);
                cuotas.Add(c);
            }

        }
        private DateTime CalcularFechaPago(int numeroCuota)
        {
            DateTime fechaPago = new DateTime(OtorgadoEn.Year, OtorgadoEn.Month, 1);
            fechaPago = fechaPago.AddMonths(numeroCuota+1).AddDays(4);
            return fechaPago;
        }
        protected double CalcularValorCuota(int cCuotas)
        {

            double tasaMensual = (Math.Pow(TasaAnual/100 + 1, 1.0 / 12.0)) - 1;
            double valorCuota =tasaMensual * ValorSolicitado / (1-Math.Pow(1 + (tasaMensual), -cCuotas));
            return valorCuota;
        }
        public string[] VerDatos()
        {
            string[] a = new string[CantidadCuotas+2];
            a[0] = $"{OtorgadoA} en {OtorgadoEn}";
            for (int i = 1; i < CantidadCuotas+1; i++)
            {
                a[i] = cuotas[i-1].ToString();
            }
            a[a.Length-1] = $"Total: {ValorCreditoConIntereses:F2}";
            return a;

        }
    }
}
