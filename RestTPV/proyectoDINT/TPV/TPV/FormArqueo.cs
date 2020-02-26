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
    public partial class FormArqueo : Form
    {
        /// <summary>
        /// Con este form podremos llevar un seguimiento sobre las ventas que realizamos
        /// Podemos comprobar el dinero que generamos


        ///Constructor
        ///
        /// </summary>
        public FormArqueo()
        {
            InitializeComponent();
            labelCambio.Hide();
            labelEfectivo.Hide();
            labelTarjeta.Hide();
            labelTotal.Hide();
            botonCerrarCaja.Hide();
            val_efectivo.Hide();
            val_tarjeta.Hide();
            val_total.Hide();
            val_cambio.Hide();
            labelTotalEfectivo.Hide();
            val_totalEfectivo.Hide();
            botonAcepatr2.Hide();

            if(Properties.Settings.Default.CajaAbierta == true)
            {
                botonCerrarCaja.Show();
                botonAbriCaja.Hide();
                botonAceptar.Hide();
                botonAcepatr2.Show();
            }
            
        }

        /// <summary>
        /// Método para abrir la caja del restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAbriCaja_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CajaAbierta = true;
            Properties.Settings.Default.ContArqueo++;
            Properties.Settings.Default.Save();
            labelCambio.Show();
            val_cambio.Show();
                      
        }

        /// <summary>
        /// Método para cerrar la caja del restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonCerrarCaja_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.CajaAbierta = false;
            Properties.Settings.Default.DineroEfectivo = 0;
            Properties.Settings.Default.DineroTarjeta = 0;
            Properties.Settings.Default.ContArqueo = 0;
            Properties.Settings.Default.Save();
            labelCambio.Hide();
            labelEfectivo.Hide();
            labelTarjeta.Hide();
            labelTotal.Hide();
            botonAbriCaja.Show();
            val_efectivo.Hide();
            val_tarjeta.Hide();
            val_total.Hide();
            val_cambio.Hide();
            labelTotalEfectivo.Hide();
            val_totalEfectivo.Hide();
            MessageBox.Show("Caja cerrada satisfactoriamente");
            this.Close();
        }

        /// <summary>
        /// Método para mostrar recuento de la caja desde que esta se abre hasta que se cierra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ContArqueo++;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.CajaAbierta == true)
            {
                labelEfectivo.Show();
                labelTarjeta.Show();
                labelTotal.Show();
                labelTotalEfectivo.Show();
                val_efectivo.Show();
                val_tarjeta.Show();
                val_total.Show();
                val_totalEfectivo.Show();
                labelCambio.Hide();
                val_cambio.Hide();

                
                val_efectivo.Text = Math.Round(Properties.Settings.Default.DineroEfectivo, 2).ToString();
                val_tarjeta.Text = Math.Round(Properties.Settings.Default.DineroTarjeta, 2).ToString();
                val_totalEfectivo.Text = Math.Round((Properties.Settings.Default.DineroEfectivo + Properties.Settings.Default.DineroTarjeta + Properties.Settings.Default.Cambio),2).ToString();
                val_total.Text = Math.Round((Properties.Settings.Default.DineroEfectivo + Properties.Settings.Default.DineroTarjeta),2).ToString();
            }
            else
                MessageBox.Show("No has hecho movimientos de caja");

        }

        /// <summary>
        /// Método para asignar un valor a al cambio que tenemos en mesas o si la caja está abierta, para ir al form anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CajaAbierta == true)
            {
                int n;
                bool num = Int32.TryParse(val_cambio.Text, out n);

                if (num == true)
                {

                    if (val_cambio.Text != "")
                    {
                        Properties.Settings.Default.Cambio = float.Parse(val_cambio.Text);
                        MessageBox.Show("Caja abierta satisfactoriamente");
                        this.Hide();
                        botonAceptar.Hide();
                        botonAcepatr2.Show();
                    }
                    else
                    {
                        Properties.Settings.Default.CajaAbierta = false;
                        Properties.Settings.Default.Save();
                        labelCambio.Hide();
                        val_cambio.Hide();
                        botonCerrarCaja.Hide();
                        MessageBox.Show("Tienes que introducir un mínimo de cambio en caja");
                    }
                }
                else
                    MessageBox.Show("Datos introducidos incorrectos");
            }
            

        }

        /// <summary>
        /// Método para salir al form anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAcepatr2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
