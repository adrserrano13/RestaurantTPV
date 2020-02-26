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
    /// Form1 es la primera vista del programa
    /// Es un form simple en el que podemos ver el logo y el nombre del programa
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
        
        }
        /// <summary>
        /// Método para pasar al siguiente form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            explicacio_2_cs form2 = new explicacio_2_cs();
            form2.Show();
            this.Hide();

        }
        /// <remarks>
        /// Método para personalizar boton 
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_MouseHover(object sender, EventArgs e)
        {
            buttonNext.BackColor = Color.FromArgb(90,Color.Black);
        }

    }
}
