using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class Menu : UserControl
    {
        string nombre;
        string precio;
        public int id { get; set;  }
        public event EventHandler BorrarEnMenu;
        //public event EventHandler CambiarUnidades;

        /// <summary>
        /// 
        /// Constructor al que le pasaremos los parámetros
        /// nombre de producto
        /// precio de producto
        /// id de producto
        /// 
        /// </summary
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="id"></param>
        public Menu(string nombre, string precio,int id)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.id = id;

            InitializeComponent();
            val_nombre.Text = nombre;
            val_precio.Text = precio;
            val_Id.Text = id.ToString();
            val_Id.Hide();

        }

        /// <summary>
        /// Método en el cual asignamos el id que está ejecutando este método para poder borrarlo en la base de datos por el id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IdProd--;
            Properties.Settings.Default.lineaMenu = this;
            Properties.Settings.Default.CambioPrecio = Convert.ToDouble(this.val_precio.Text);
            Properties.Settings.Default.ContolBorrado = int.Parse(this.val_Id.Text);
            Properties.Settings.Default.Save();
            BorrarEnMenu?.Invoke(this, e);
        }

    }
}
