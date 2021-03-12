using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*double numero1, numero2, numero3;
        string resultado;
        bool secuencia = true, p = true;
        string operacion, borrado;
        double memoria = 0, memoriaAux = 0;*/
        float x, y, z;
        string resultado;
        double raiz;
        string op, borrado;
        bool punto = true;
        bool operacion = true;
        bool secuencia = false;
        bool p = true;
        int cont = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // NUMEROS DE LA CALCULADORA APARTIR DE AQUI ......................
        private void button1_Click(object sender, EventArgs e)
        {
            if(operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "1";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "2";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "3";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "4";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "5";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "6";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "7";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "8";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                TxtResultado.Text = "";
                TxtResultado.Text = "9";
                operacion = false;
                p = true;
            }
            else
            {
                TxtResultado.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text == "0")
            {
                return;
            }
            else
            {
                if (operacion == true)
                {
                    TxtResultado.Text = "";
                    TxtResultado.Text = "0";
                }
                else
                {
                    TxtResultado.Text += "0";
                }
            }
        }


        // BOTONES DE OPERACIONES APARTIR DE AQUI .......
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            // SI NO ENCUENTRA PUNTO NOS DEBE DEJAR COLOCAR UN PUNTO
            operacion = false;
            if (TxtResultado.Text.IndexOf('.') > 0)
            {
                MessageBox.Show("Solo se permite un punto");
            }
            else
            {
                TxtResultado.Text += ".";
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if (operacion == false && secuencia == false)
            {
                x = float.Parse(TxtResultado.Text);
                op = "+";
                operacion = true;
                secuencia = true;
            }
            if (operacion == false && secuencia == true)
            {
                y = float.Parse(TxtResultado.Text);
                if (op == "+")
                {
                    x = x + y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "-")
                {
                    x = x - y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "*")
                {
                    x = x * y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "/")
                {
                    x = x / y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }

            }
            op = "+";
            punto = true;
            p = false;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (operacion == false && secuencia == false)
            {
                x = float.Parse(TxtResultado.Text);
                op = "-";
                operacion = true;
                secuencia = true;
            }
            if (operacion == false && secuencia == true)
            {
                y = float.Parse(TxtResultado.Text);
                if (op == "+")
                {
                    x = x + y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "-")
                {
                    x = x - y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "*")
                {
                    x = x * y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "/")
                {
                    x = x / y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
            }
            op = "-";
            punto = true;
            p = false;
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (operacion == false && secuencia == false)
            {
                x = float.Parse(TxtResultado.Text);
                op = "*";
                operacion = true;
                secuencia = true;
            }
            if (operacion == false && secuencia == true)
            {
                y = float.Parse(TxtResultado.Text);
                if (op == "+")
                {
                    x = x + y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "-")
                {
                    x = x - y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "*")
                {
                    x = x * y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "/")
                {
                    x = x / y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
            }
            op = "*";
            punto = true;
            p = false;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (operacion == false && secuencia == false)
            {
                x = float.Parse(TxtResultado.Text);
                op = "-";
                operacion = true;
                secuencia = true;
            }
            if (operacion == false && secuencia == true)
            {
                y = float.Parse(TxtResultado.Text);
                if (op == "+")
                {
                    x = x + y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "-")
                {
                    x = x - y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "*")
                {
                    x = x * y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }
                if (op == "/")
                {
                    x = x / y;
                    TxtResultado.Text = x.ToString();
                    operacion = true;
                    secuencia = true;
                }

            }
            op = "/";
            punto = true;
            p = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // boton de raiz cuadrada
            raiz = Math.Sqrt(double.Parse(TxtResultado.Text));
            TxtResultado.Text = raiz.ToString();
            operacion = true;
        }

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            x = float.Parse(TxtResultado.Text);
            x *= x;
            TxtResultado.Text = x.ToString();
            operacion = true;
        }


        // OPERACIONES DE LA CALCULADORA
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            y = float.Parse(TxtResultado.Text);
            if (op == "+")
            {
                z = x + y;
                resultado = z.ToString();
                TxtResultado.Text = resultado;
            }
            if (op == "-")
            {
                z = x - y;
                resultado = z.ToString();
                TxtResultado.Text = resultado;
            }
            if (op == "*")
            {
                z = x * y;
                resultado = z.ToString();
                TxtResultado.Text = resultado;
            }
            if (op == "/")
            {
                z = x / y;
                resultado = z.ToString();
                TxtResultado.Text = resultado;
            }
            p = true;
            operacion = false;
            secuencia = false;
            punto = true;
            x = z;
        }

        // BOTONES ESPECIALES........

        private void buttonRetroceso_Click(object sender, EventArgs e)
        {
            int cls = 0;
            borrado = TxtResultado.Text;
            cls = borrado.Length - 1;
            borrado = borrado.Substring(0, cls);
            TxtResultado.Text = borrado;

            if (TxtResultado.Text == "")
            {
                TxtResultado.Text = "0";
                operacion = true;
            }
            if (TxtResultado.Text == "-")
            {
                TxtResultado.Text = "0";
                operacion = true;
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "0";
            x = 0;
            y = 0;
            operacion = true;
        }
    }
}