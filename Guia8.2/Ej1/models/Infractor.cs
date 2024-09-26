using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Infractor
    {
        public int Dni {  get; set; }   
        public string ApellidosYNombres { get; set; }
        public Infractor(int dni, string apellidosYNombres)
        {
            Dni = dni;
            ApellidosYNombres = apellidosYNombres;
        }

        public override string   ToString()
        {
            return $"Nombre: {ApellidosYNombres}\r\nDni:{Dni}";
        }

    }
}
