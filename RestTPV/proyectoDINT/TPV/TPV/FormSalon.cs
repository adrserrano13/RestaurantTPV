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
    /// FormSalon
    /// En este form podemos crear las mesas con las que después podremos tomar comanda
    /// Actualizar el número de mesas
    /// Ir a FormTerraza
    /// </summary>
    public partial class FormSalon : Form
    {
        /// <value>
        /// Creamos un boton global
        /// </value>
        Button boton = new Button();

        /// <summary>
        /// Constructor FormSalon
        /// </summary>
        public FormSalon()
        {
            ///<summary>
            ///Inicializamos componentes
            ///</summary>
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            BotonMas.Hide();
            BotonMenos.Hide();
            BotonActualizar.Hide();
            LayoutMesas.BackColor = Color.FromArgb(0, Color.Black);
            LayoutMesas.AutoScroll = true;
            label1.BackColor = System.Drawing.Color.Transparent;

            ///<summary>
            ///Creamos las mesas  existentes cada vez que este form se abre
            /// </summary>
            if (Properties.Settings.Default.MesasSalon != 0)
            {

                crearMesas(Properties.Settings.Default.MesasSalon);
                botonAñadir.Hide();
                BotonActualizar.Show();
            }
            ///<summary>
            ///Si el usuario es el admin, mostramos los botones + y - para que pueda manipular las mesas
            /// </summary>
            if(Properties.Settings.Default.Admin == true)
            {
                BotonMas.Show();
                BotonMenos.Show();
            }
        }
        /// <summary>
        /// Método para crear las mesas la primera vez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAñadir_Click(object sender, EventArgs e)
        {

            FormAñadir añadir = new FormAñadir();


            if (añadir.ShowDialog() == DialogResult.OK)
            {
                LayoutMesas.Controls.Clear();
                Properties.Settings.Default.MesasSalon = añadir.numMesas;
                Properties.Settings.Default.Save();

                crearMesas(Properties.Settings.Default.MesasSalon);
                botonAñadir.Dispose();
                BotonActualizar.Show();
                BotonMas.Show();
                BotonMenos.Show();
            }
        }

        /// <summary>
        /// Método para actualizar el numero de mesas en salon
        /// Solo podrás usar este método si eres admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonActualizar_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.Admin == true)
            {
                FormAñadir añadir = new FormAñadir();
                añadir.StartPosition = FormStartPosition.CenterScreen;

                if (añadir.ShowDialog() == DialogResult.OK)
                {
                    LayoutMesas.Controls.Clear();
                    Properties.Settings.Default.MesasSalon = añadir.numMesas;
                    Properties.Settings.Default.Save();
                    crearMesas(Properties.Settings.Default.MesasSalon);
                    BotonMas.Show();
                    BotonMenos.Show();   

                }
            }
            else
                MessageBox.Show("Debes iniciar sesion como administrador para actualizar las mesas");
        }

        /// <summary>
        /// Botón para acceder a la terraza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonTerraza_Click_1(object sender, EventArgs e)
        {
            FormTerraza terraza = new FormTerraza();
            terraza.Show();
            this.Hide();

        }

        /// <summary>
        /// Botón para poner una mesa más en salón
        /// Solo podrás usarlo si el usuario es admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonMas_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.MesasSalon = Properties.Settings.Default.MesasSalon + 1;
            Properties.Settings.Default.Save();

            boton = new Button();
            boton.Name = String.Format("Boton{0}", Properties.Settings.Default.MesasSalon);
            boton.Width = 125;
            boton.Height = 125;
            boton.Text = String.Format("MESA {0}", Properties.Settings.Default.MesasSalon);
            LayoutMesas.Controls.Add(boton);
        }

        /// <summary>
        /// Botón para poner una mesa menos en salón
        /// Solo podrás usarlo si el usuario es admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonMenos_Click(object sender, EventArgs e)
        {
            LayoutMesas.Controls.RemoveAt(Properties.Settings.Default.MesasSalon - 1);
            Properties.Settings.Default.MesasSalon = Properties.Settings.Default.MesasSalon - 1;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Método para crear mesas de forma dinámica
        /// </summary>
        /// <param name="mesas"></param>
        /// <value>Numero de mesas que el usuario introduce</value>
        public void crearMesas(int mesas)
        {
            for (int i = 0; i < mesas; i++)
            {
                Button boton = new Button();
                boton.Width = 125;
                boton.Height = 125;
                boton.Text = String.Format("MESA {0}", i + 1);
                boton.Left = i * 100;
                LayoutMesas.Controls.Add(boton);
                boton.DialogResult = DialogResult.OK;
                ///<value>Asociamos de forma dinámica 
                ///a cada boton un evento
                ///Donde le pasaremos como parámetro el nombre del boton(número de mesa que es)
                ///</value>
                boton.Click += new EventHandler((sender1, e1) => AbrirMesaSalon(sender1, e1, boton.Text));



            }
        }
        /// <summary>
        /// Método asociado a los eventos de los botones
        /// Con este método abrimos una mesa para poder comandarla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="BotonText"></param>
        /// <value>nombre del boton(número de mesa que es)</value>
        private void AbrirMesaSalon(object sender, EventArgs e, string BotonText)
        {
            
            FormMesa mesa = new FormMesa(BotonText);          
            mesa.Show();
            this.Hide();
            
        }
        /// <summary>
        /// Método para ir al form anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormSalones salones = new FormSalones();

            salones.Show();
            this.Hide();
        }

        /// <summary>
        /// Método para cerrar el programa con la x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSalon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Admin = false;
            Properties.Settings.Default.Save();
            Application.Exit();
        }


    }
}
