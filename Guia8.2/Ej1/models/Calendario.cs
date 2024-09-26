using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Calendario
    {
        private ArrayList feriados = new ArrayList();
        public int CantFeriados
        {
            get
            {
                return feriados.Count;  
            }
        }
        public Feriado this[DateTime dia]
        {
            get
            {
                for(int i = 0;i< CantFeriados; i++)
                {
                    Feriado f = feriados[i] as Feriado;
                    if (f.Fecha.Year == dia.Year && f.Fecha.Month == dia.Month && f.Fecha.Day == dia.Day)
                    {
                        return f;
                    }
                    
                }
                return null;
            }
        }
        public Feriado this[int i]
        {
            get
            {
                if(i>=0 && i< CantFeriados)
                {
                    Feriado f = feriados[i] as Feriado;
                    return f;
                }
                return null;
            }
        }
        public Feriado AgregarFeriado(DateTime dia, string desc)
        {
            Feriado f = new Feriado(dia, desc);
            feriados.Add(f);
            return f;
        }
        public Feriado VerFeriado(int i)
        {
            return feriados[i] as Feriado;
        }
    }
}
