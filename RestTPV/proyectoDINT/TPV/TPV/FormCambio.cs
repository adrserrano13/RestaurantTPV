using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    /// <summary>
    /// Form para poder calcular el cambio que hay que devolver
    /// 
    /// Podemos calcular el cambio o directamente darle a aceptar para cobrar la mesa
    /// 
    /// </summary>
    public partial class FormCambio : Form
    {
        string precioMesa;
        public FormCambio(string precioMesa)
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.precioMesa = precioMesa;
            

            textBoxPrec.Text = precioMesa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "9";
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text = textBoxDinero.Text.Remove(textBoxDinero.TextLength - 1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text += ",";
        }

        private void ButtonBorrarTodo_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text = "";
        }

        private void buttonCambio_Click(object sender, EventArgs e)
        {
            txtboxDev.Text = "";
            double devolucion;
            if (textBoxPrec.Text != "" && textBoxDinero.Text != "")
            {
                double dinero = Convert.ToDouble(textBoxDinero.Text);
                double precio = Convert.ToDouble(textBoxPrec.Text);
                if (precio <= dinero)
                {
                    devolucion = dinero - precio;
                    txtboxDev.Text = devolucion.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Dinero introducido insuficiente");
                }
            }
            else
            {
                MessageBox.Show("Los campos deben tener una cantidad");
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
