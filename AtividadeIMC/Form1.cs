using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNumero1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.Coral;
            // Variaveis para Armazenar os Valores dos Campos:
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;

            if (txtPeso.Text != "" && txtAltura.Text != "")
            {
                n1 = double.Parse(txtPeso.Text);
                n2 = double.Parse(txtAltura.Text);
            }
            resultado = n1 / (n2 * n2);
            txtIMC.Text = resultado.ToString();

            if (resultado < 18.5)
            {
                lblResultado.Text = ("Você está abaixo do Peso: ");
            }
            else if (resultado >= 18.6 && resultado <= 24.9)
            {
                lblResultado.Text = (" Peso ideal: ");
            }
            else if (resultado >= 25.0 && resultado <= 29.9)
            {
                lblResultado.Text = ("Levemente Acima do Peso: ");
            }
            else if (resultado >= 30.0 && resultado <= 34.9)
            {
                lblResultado.Text = ("Obesidade Grau 1: ");
            }
            else if (resultado >= 35.0 && resultado <= 39.9)
            {
                lblResultado.Text = ("Obesidade Grau 2 Severa: ");
            }
            else if (resultado >= 40)
            {
                lblResultado.Text = ("Obesidade 3 Gordasso: ");
            }
        }
    }
}
