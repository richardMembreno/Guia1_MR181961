using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3
{
    public partial class Ejemplo3 : Form
    {
        int x, y;
        Random aleatorio = new Random();
        int alto, ancho, tamCirculo;
        int rojo, verde, azul;

        public Ejemplo3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

            if(listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(rojo, verde, azul));
                g.DrawEllipse(lapiz, x - 50, y - 50, tamCirculo, tamCirculo);
                g.FillEllipse(sb, x - 50, y - 50, tamCirculo, tamCirculo);
            }
            if(listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(rojo, verde, azul));
                g.DrawRectangle(lapiz, x - 50, y - 50, ancho, alto);
                g.FillRectangle(sb, x - 50, y - 50, ancho, alto);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            alto = aleatorio.Next(55, 150);
            ancho = aleatorio.Next(90, 240);
            tamCirculo = aleatorio.Next(55, 150);
            rojo = aleatorio.Next(255);
            verde = aleatorio.Next(255);
            azul = aleatorio.Next(255);
            panel1.Invalidate();
        }
    }
}
