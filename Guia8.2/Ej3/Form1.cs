using Ej3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Financiera f = new Financiera()
        {
            TasaAnual = 3
        };
        private void button1_Click(object sender, EventArgs e)
        {
            f.OtorgarCredito(12345, 500000, "Pablito", 3);
            for (int i = 0; i < f.CantidadCreditos; i++)
            {
                Credito c = f[i];
                listBox1.Items.AddRange(c.VerDatos());
            }
        }
    }
}
