using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
             int numero1, numero2;

            // Verificar que los números ingresados sean válidos
            if (int.TryParse(txtNumero1.Text, out numero1) && int.TryParse(txtNumero2.Text, out numero2))
            {
                int resultado = Multiplicar(numero1, numero2);
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private int Multiplicar(int a, int b)
        {
            int resultado = 0;

            for (int i = 0; i < Math.Abs(b); i++)
            {
                resultado += a;
            }

            return (b < 0) ? -resultado : resultado;
        }
    }
}
