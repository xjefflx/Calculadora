using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObtenerValores(out double num1, out double num2)
        {
            bool val1 = double.TryParse(txtNum1.Text, out num1);
            bool val2 = double.TryParse(txtNum2.Text, out num2);

            if (!val1 || !val2)
            {
                MessageBox.Show("Por favor, ingrese números válidos en ambos campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
                txtResultado.Text = (n1 + n2).ToString();
        }

       private void btnModulo_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
            {
                if (n2 == 0)
                {
                    MessageBox.Show("No se puede calcular el módulo entre cero.", "Error matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResultado.Text = "Error";
                }
                else
                {
                    // Calcula el residuo de la división y lo muestra en el cuadro de texto
                    txtResultado.Text = (n1 % n2).ToString();
                }
            }
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
                txtResultado.Text = (n1 - n2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
                txtResultado.Text = (n1 * n2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
            {
                if (n2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.", "Error matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResultado.Text = "Error";
                }
                else
                {
                    txtResultado.Text = (n1 / n2).ToString();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();
        }

    private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}