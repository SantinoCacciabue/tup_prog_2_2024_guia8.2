using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calendario c = new Calendario();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCalendario fCalenadario = new FormCalendario();

            for (int i = 0; i < c.CantFeriados; i++)
            {
                fCalenadario.monthCalendar1.AddBoldedDate(c[i].Fecha);
            }
            
            fCalenadario.ShowDialog();
            while (fCalenadario.DialogResult == DialogResult.OK || fCalenadario.DialogResult == DialogResult.Yes)
            {
                
                DateTime fecha = fCalenadario.monthCalendar1.SelectionStart;
                Feriado fer = c[fecha];

                if (fCalenadario.DialogResult == DialogResult.OK)
                {
                   

                    if (fer != null)//si existe lo actualizo
                    {
                        fer.Descripcion = fCalenadario.tBdesc.Text;
                    }
                    else //sino existe lo agrego
                    {
                        c.AgregarFeriado(fecha, fCalenadario.tBdesc.Text);
                        fCalenadario.monthCalendar1.AddBoldedDate(fecha);
                    }
                }
                fCalenadario.tBdesc.Clear();
                if (fCalenadario.DialogResult == DialogResult.Yes)
                {
                    if (fer != null)//si existe lo actualizo
                    {
                        fCalenadario.tBdesc.Text = fer.Descripcion;
                    }
                }

                fCalenadario.ShowDialog();
            }
            fCalenadario.Dispose();
        }
    }
}
