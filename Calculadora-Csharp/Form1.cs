﻿using System;
using System.Windows.Forms;
using Operadores;
using System.Globalization;

namespace Calculadora_Csharp
{
    public partial class Background : Form
    {
        public double primeiro { get; set; }
        public double segundo { get; set; }
        public string operador { get; set; }

        public Background()
        {
            InitializeComponent();
        }

        Soma soma = new Soma();
        Divisao div = new Divisao();
        Multiplicacao mul = new Multiplicacao();
        Subtracao sub = new Subtracao();

        private void bttnN0_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";
        }

        private void bttnN1_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";
        }

        private void bttnN2_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";
        }

        private void bttnN3_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";
        }

        private void bttnN4_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";
        }

        private void bttnN5_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void bttnN6_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void bttnN7_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void bttnN8_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void bttnN9_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void bttnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(result.Text);
            switch (operador) 
            {
                case "+":
                    result.Text = soma.RealizarSoma(primeiro, segundo).ToString("F2");
                    break;
                case "-":
                    result.Text = sub.RealizaSub(primeiro, segundo).ToString();
                    break;
                case "X":
                    result.Text = mul.RealizaMulti(primeiro, segundo).ToString();
                    break;
                case "/":
                    result.Text = div.RealizaDiv(primeiro, segundo).ToString();
                    break;
            }
        }

        private void bttnMais_Click(object sender, EventArgs e)
        {
            operador = "+";
            primeiro = double.Parse(result.Text);
            result.Clear();

        }

        private void bttnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiro = double.Parse(result.Text);
            result.Clear();
        }

        private void bttnMultiplicacao_Click(object sender, EventArgs e)
        {
            operador = "X";
            primeiro = double.Parse(result.Text);
            result.Clear();
        }

        private void bttnDivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            primeiro = double.Parse(result.Text);
            result.Clear();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            string aux = result.Text;
            aux = aux.Remove(aux.Length - 1);
            result.Text = aux;
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            primeiro = 0;
            segundo = 0;
            result.Clear();
        }

        private void bttnPonto_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + ",";
        }
    }
}
