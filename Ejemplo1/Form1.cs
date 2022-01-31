using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Ejemplo1 : Form
    {
        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int Operacion;

        public Ejemplo1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        public void limpiar_pantalla()
        {
            pantalla.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 0;
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere dos operandos");
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 1;
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere dos operandos");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 2;
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere dos operandos");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 3;
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere dos operandos");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if(Operacion == 0)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "+").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                else if(Operacion == 1)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "-").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un operación para realizar");
                    }
                }
                else if(Operacion == 2)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "*").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un operación para realizar");
                    }
                }
                else if(Operacion == 3)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        if (Num2 != 0)
                        {
                            actualizar_pantalla(operar(Num1, Num2, "/").ToString());
                            Is1 = false;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir entre cero");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un operación para realizar");
                    }
                }
                else if (Operacion == 4)
                {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "sin").ToString());
                        Is1 = false;
                }
                else if (Operacion == 5)
                {
                    Num2 = obtener_valor();
                    actualizar_pantalla(operar(Num1, Num2, "cos").ToString());
                    Is1 = false;
                }
                else if (Operacion == 6)
                {
                    Num2 = obtener_valor();
                    actualizar_pantalla(operar(Num1, Num2, "tan").ToString());
                    Is1 = false;
                }
                else if (Operacion == 7)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "^").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                else if (Operacion == 8)
                {
                    Num2 = obtener_valor();
                    actualizar_pantalla(operar(Num1, Num2, "log").ToString());
                    Is1 = false;
                }
                else if (Operacion == 9)
                {
                    Num2 = obtener_valor();
                    actualizar_pantalla(operar(Num1, Num2, "logn").ToString());
                    Is1 = false;
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere dos operandos");
            }
        }

        public double operar(double operador1, double operador2, String signo)
        {
            double Resultado = 0.0;

            switch (signo)
            {
                case "+":
                    Resultado = operador1 + operador2;
                    break;
                case "-":
                    Resultado = operador1 - operador2;
                    break;
                case "*":
                    Resultado = operador1 * operador2;
                    break;
                case "/":
                    Resultado = operador1 / operador2;
                    break;
                case "sin":
                    if (Is1)
                    {
                        Resultado = operador1 * (Math.Sin(operador2));
                    }
                    else
                    {
                        Resultado = Math.Sin(operador2);
                    }
                    break;
                case "cos":
                    if (Is1)
                    {
                        Resultado = operador1 * (Math.Cos(operador2));
                    }
                    else
                    {
                        Resultado = Math.Cos(operador2);
                    }
                    break;
                case "tan":
                    if (Is1)
                    {
                        Resultado = operador1 * (Math.Tan(operador2));
                    }
                    else
                    {
                        Resultado = Math.Tan(operador2);
                    }
                    break;
                case "^":
                    Resultado = Math.Pow(operador1, operador2);
                    break;
                case "log":
                    if (Is1)
                    {
                        Resultado = operador1 * (Math.Log10(operador2));
                    }
                    else
                    {
                        Resultado = Math.Log10(operador2);
                    }
                    break;
                case "logn":
                    if (Is1)
                    {
                        Resultado = operador1 * (Math.Log(operador2));
                    }
                    else
                    {
                        Resultado = Math.Log(operador2);
                    }
                    break;
                default:
                    break;
            }
            return Resultado;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                Num1 = 0.0;
                Is1 = false;
                Operacion = 4;
            }
            else
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 4;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                Num1 = 0.0;
                Is1 = false;
                Operacion = 5;
            }
            else
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 5;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                Num1 = 0.0;
                Is1 = false;
                Operacion = 6;
            }
            else
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 6;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 7;
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere dos operandos");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                Num1 = 0.0;
                Is1 = false;
                Operacion = 8;
            }
            else
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 8;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                Num1 = 0.0;
                Is1 = false;
                Operacion = 9;
            }
            else
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 9;
            }
        }

        public double obtener_valor()
        {
            double valor = Convert.ToDouble(pantalla.Text);
            limpiar_pantalla();
            return valor;
        }

        public void actualizar_pantalla(String texto)
        {
            pantalla.Text = pantalla.Text + texto;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");
        }
    }
}
