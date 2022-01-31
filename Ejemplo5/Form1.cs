using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5
{
    public partial class Ejemplo5 : Form
    {
        enum Posicion
        {
            izquierda,derecha,arriba,abajo
        }

        private int x;
        private int y;
        private Posicion objposicion;
        private int maxLimitWidth;
        private int maxLimitHeight;

        public Ejemplo5()
        {
            InitializeComponent();
            x = 50;
            y = 50;
            objposicion = Posicion.abajo;
            maxLimitWidth = this.Size.Width - 80;
            maxLimitHeight = this.Size.Height - 80;
        }

        private void Ejemplo5_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                objposicion = Posicion.izquierda;
            }
            else if(e.KeyCode == Keys.Right)
            {
                objposicion = Posicion.derecha;
            }
            else if(e.KeyCode == Keys.Up)
            {
                objposicion = Posicion.arriba;
            }
            else if(e.KeyCode == Keys.Down)
            {
                objposicion = Posicion.abajo;
            }
        }

        private void timerMov_Tick(object sender, EventArgs e)
        {
            if(objposicion == Posicion.derecha)
            {
                if (x < maxLimitWidth)
                {
                    x += 10;
                }
                else
                {
                    objposicion = Posicion.izquierda;
                }
            }
            else if(objposicion == Posicion.izquierda)
            {
                if (x > 0)
                {
                    x -= 10;
                }
                else
                {
                    objposicion = Posicion.derecha;
                }
            }
            else if(objposicion == Posicion.arriba)
            {
                if (y > 0)
                {
                    y -= 10;
                }
                else
                {
                    objposicion = Posicion.abajo;
                }
            }
            else if(objposicion == Posicion.abajo)
            {
                if (y < maxLimitHeight)
                {
                    y += 10;
                }
                else
                {
                    objposicion = Posicion.arriba;
                }
            }

            Invalidate();
        }

        private void Ejemplo5_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("birrete.png"), x, y, 65, 65);
        }
    }
    //asunto: PED104 Guia1 Carnet, enviar enlace de git y pdf con pantalla de funcionamiento
    //armando.nieto@udb.edu.sv
}
