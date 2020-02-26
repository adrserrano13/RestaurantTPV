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
    /// FormGestión
    /// En este form podremos añadir un producto o eliminarlo
    /// </summary>
    public partial class Form2Gestion : Form
    {
        /// <summary>
        /// Constructor Form2Gestión
        /// </summary>
        public Form2Gestion()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Método en el que mostramos el form AnadirProductos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAñadir_Click(object sender, EventArgs e)
        {
            AnadirProductos añadir = new AnadirProductos();
            añadir.Show();
            this.Hide();
        }
        /// <summary>
        /// Método para salir al form anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Método en el que mostramos el form FormEliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonBorrar_Click(object sender, EventArgs e)
        {
            FormEliminar eliminar = new FormEliminar();
            eliminar.Show();
            this.Hide();
        }
    }
}
