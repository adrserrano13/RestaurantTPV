using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TPV
{   
    /// <summary>
    /// Este form es la vista 0, es decir, explicamos lo que podemos realizar con nuestro programa
    /// </summary>
    public partial class explicacio_2_cs : Form
    {
        /// <value>Valor de transparencia para los paneles</value>
        public const int Trans = 90;
        public explicacio_2_cs()
        { 
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(Trans, Color.Black);
            panel2.BackColor = Color.FromArgb(Trans, Color.Black);
            panel3.BackColor = Color.FromArgb(Trans, Color.Black);
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;

        }

        /// <summary>
        /// Método para pasar al siguiente form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            FormSalones form3 = new FormSalones();
            form3.Show();
            this.Hide();
           

        }

        /// <summary>
        /// Método para cerrar el programa dandole a la x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void explicacio_2_cs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
