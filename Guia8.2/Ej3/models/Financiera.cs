using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.models
{
    internal class Financiera
    {
        private List<Credito> creditos = new List<Credito>();
        private List<Cliente> clientes = new List<Cliente>();
        public int CantidadCreditos
        {
            get
            {
                return creditos.Count;
            }
        }
        public int CantidadClientes
        {
            get
            {
                return clientes.Count;
            }
        }
        public double TasaAnual { get; set; }
        public Credito this[int i]
        {
            get
            {
                return creditos[i];
            }
        }
        public Credito OtorgarCredito(int dni, double valorSolicitado,string nombre, int cuotas)
        {
            DateTime fecha = DateTime.Now;
            clientes.Sort();
            Cliente c;
            int i = clientes.BinarySearch(new Cliente(dni, ""));
            if(i == -1)
            {
                c = new Cliente(dni, nombre);
            }
            else
            {
                c = clientes[i];
            }
            Credito cre = new Credito(c, valorSolicitado, TasaAnual, cuotas );
            creditos.Add(cre);
            return cre;
        }
        public Cliente AgregarCliente(int dni, string nom)
        {
            Cliente c = new Cliente(dni, nom);
            clientes.Add(c);
            return c;
        }
        public Cliente VerCliente(int i)
        {
            return clientes[i];
        }
    }
}
