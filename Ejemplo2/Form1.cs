using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Button boton1;

        public Form1()
        {
            boton1 = new Button();
            boton1.Size = new Size(80, 40);
            boton1.Location = new Point(30, 30);
            boton1.Text = "Presione aqui";
            this.Controls.Add(boton1);
            boton1.Click += new EventHandler(boton1_Click);
        }

        private void boton1_Click(Object sender,EventArgs e)
        {
            MessageBox.Show("Se ha creado un boon por codigo");
        }
    }
}
