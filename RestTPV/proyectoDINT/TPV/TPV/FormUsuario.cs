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
    /// Form para poder asignar el valor de los datos que introduce el usuario
    /// </summary>
    public partial class FormUsuario : Form
    {
        /// <value>
        /// Variables con setters y getters par poder usarlas desde otro form
        /// </value>
        public string user { get; set;}
        public string pwd { get; set;}
        public FormUsuario()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e)
        {   
                user = val_usuario.Text;
                pwd = val_pwd.Text;
            
        }
    }
}
