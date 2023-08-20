using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            respuesta.Text = (Int64.Parse(numero1.Text) + Int64.Parse(numero2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            respuesta.Text = (Int64.Parse(numero1.Text) * Int64.Parse(numero2.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valor, potencia, resultado;
            valor = Convert.ToDouble(numero1.Text);
            potencia = Convert.ToDouble(numero2.Text);
            resultado = Math.Pow(valor, potencia);
            respuesta.Text = resultado.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            respuesta.Text = (Int64.Parse(numero1.Text) % Int64.Parse(numero2.Text)).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string aux;
            aux = numero1.Text;
            numero1.Text = numero2.Text;
            numero2.Text = aux;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numero1.Text = "";
            numero2.Text = "";
            respuesta.Text = "";
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            respuesta.Text = (float.Parse(numero1.Text) - float.Parse(numero2.Text)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            respuesta.Text = (float.Parse(numero1.Text) / float.Parse(numero2.Text)).ToString();
        }

        private void Radicar_Click(object sender, EventArgs e)
        {
            double valor, resultado;
            valor = Convert.ToDouble(numero1.Text);
            resultado = Math.Sqrt(valor);
            respuesta.Text = resultado.ToString();
        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
