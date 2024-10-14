using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.models
{
    internal class Cliente:IComparable
    {
        public int DNI { get; set; }
        public string ApellidosNombres { get; set; }
        public Cliente(int dNI, string apellidosNombres)
        {
            DNI = dNI;
            ApellidosNombres = apellidosNombres;
        }
        public override string ToString()
        {
            return $"{ApellidosNombres}({DNI})";
        }

        public int CompareTo(object obj)
        {
            Cliente c = obj as Cliente;
            if(c!= null)
            {
                return DNI.CompareTo(c.DNI);
            }
            return -1;
        }
    }
}
