using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TPV
{
    /// <summary>
    /// Form que se crea dinámicamente, mostrando los productos de la base de datos según su categoría
    /// </summary>
    public partial class ControlProd : UserControl
    {

        public event EventHandler PulsarImagen;
        byte[] foto;
        public string nombre;
        public float precio;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ControlProd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al constructor le pasamos como parámetro
        /// la foto del producto de la base de datos
        /// el nombre del producto de la base de datos
        /// el precio del producto de la base de datos
        /// </summary>
        /// <param name="foto"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        public ControlProd(byte[] foto, string nombre, float precio)
        {
            this.foto = foto;
            this.nombre = nombre;
            this.precio = precio;

            InitializeComponent();
            nombre_val.Text = nombre;
            precio_val.Text = precio.ToString();
            MemoryStream ms = new MemoryStream(foto);
            pictureBox1.Image = Image.FromStream(ms);
        }

        /// <summary>
        /// Método al que le asiganamos el evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IdProd++;
            Properties.Settings.Default.NombreMenu = nombre;
            Properties.Settings.Default.PrecioMenu = precio;
            Properties.Settings.Default.Save();

    
            PulsarImagen?.Invoke(this, e);
        }
    }
}
