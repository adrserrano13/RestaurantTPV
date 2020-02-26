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
    public partial class FormSesion : Form
    {
        public string NombreAdmin { get; set; }
        public string pwd { get; set; }
        public FormSesion()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             NombreAdmin = val_pwd.Text;
             pwd = val_admin.Text;
        }
    }
}
