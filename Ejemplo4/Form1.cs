using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class Ejemplo4 : Form
    {
        Graphics area;

        public Ejemplo4()
        {
            InitializeComponent();
            area = areaDibujo.CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);
            switch (cmbColor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }

            int iteraciones = int.Parse(txtCantidad.Text);
            int espacio = int.Parse(txtEspaciado.Text);
            int puntoinicio = decimal.ToInt32(numericUpDown1.Value);
            int puntofin = decimal.ToInt32(numericUpDown2.Value);
            area.Clear(Color.White);

            for(int i=0; i<iteraciones; i++)
            {
                area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 300, puntofin + (espacio * i));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
