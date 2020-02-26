using System;
using System.Windows.Forms;

namespace TPV
{
    public partial class FormAñadir : Form
    {
        /// <value>
        /// Variable con getter y setter
        /// Con esto conseguimos recuperar el valor de la variable desde otro form
        /// </value>
        public int numMesas { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public FormAñadir()
        {

            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Con este método le damos valor a la variable creada anteriormente
        /// Además comprobamos que el usuario introduzca un entero 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            int n;
            bool num = Int32.TryParse(val_mesas.Text ,out n);

            if (num == true)
            {
                numMesas = int.Parse(val_mesas.Text);
            }
            else
            {
                MessageBox.Show("Valor introducido no valido");
                DialogResult = DialogResult.Cancel;
            }
                
        }
    }
}

