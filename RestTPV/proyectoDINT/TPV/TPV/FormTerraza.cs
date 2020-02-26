using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class FormTerraza : Form
    {

        Button boton = new Button();
        public FormTerraza()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            label1.BackColor = System.Drawing.Color.Transparent;
            BotonMas.Hide();
            BotonMenos.Hide();
            BotonActualizar.Hide();
            LayoutMesas.BackColor = Color.FromArgb(0, Color.Black);
            label1.BackColor = System.Drawing.Color.Transparent;

            if (Properties.Settings.Default.MesasTerraza != 0)
            {
                crearMesas(Properties.Settings.Default.MesasTerraza);
                botonAñadir.Dispose();
                BotonActualizar.Show();
                BotonMas.Show();
                BotonMenos.Show();
            }
        }

        private void botonAñadir_Click(object sender, System.EventArgs e)
        {
            FormAñadir añadir = new FormAñadir();

            if (añadir.ShowDialog() == DialogResult.OK)
            {
                LayoutMesas.Controls.Clear();
                Properties.Settings.Default.MesasTerraza = añadir.numMesas;
                Properties.Settings.Default.Save();

                crearMesas(Properties.Settings.Default.MesasTerraza);
                botonAñadir.Hide();
                BotonActualizar.Show();
            }
            if(Properties.Settings.Default.Admin == true)
            {
                BotonMas.Show();
                BotonMenos.Show();
            }
        }

        private void BotonActualizar_Click(object sender, System.EventArgs e)
        {

            if (Properties.Settings.Default.Admin == true)
            {
                FormAñadir añadir = new FormAñadir();
                añadir.StartPosition = FormStartPosition.CenterScreen;

                if (añadir.ShowDialog() == DialogResult.OK)
                {
                    LayoutMesas.Controls.Clear();
                    Properties.Settings.Default.MesasTerraza = añadir.numMesas;
                    Properties.Settings.Default.Save();
                    crearMesas(Properties.Settings.Default.MesasTerraza);
                    BotonMas.Show();
                    BotonMenos.Show();

                }
            }
            else
                MessageBox.Show("Debes iniciar sesion como administrador para actualizar las mesas");
        }

        private void BotonMenos_Click(object sender, System.EventArgs e)
        {
            LayoutMesas.Controls.RemoveAt(Properties.Settings.Default.MesasTerraza - 1);
            Properties.Settings.Default.MesasTerraza = Properties.Settings.Default.MesasTerraza - 1;
            Properties.Settings.Default.Save();
        }

        private void BotonMas_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.MesasTerraza = Properties.Settings.Default.MesasTerraza + 1;
            Properties.Settings.Default.Save();

            boton = new Button();
            boton.Name = string.Format("Boton{0}", Properties.Settings.Default.MesasTerraza);
            boton.Width = 125;
            boton.Height = 125;
            boton.Text = string.Format("MESA {0}", Properties.Settings.Default.MesasTerraza);
            LayoutMesas.Controls.Add(boton);
        }

        private void BotonSalon_Click(object sender, System.EventArgs e)
        {
            FormSalon salon = new FormSalon();
            salon.Show();
            this.Hide();
        }
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
                boton.Click += new EventHandler((sender1, e1) => AbrirMesaTerraza(sender1, e1, boton.Text));

            }
        }
        private void AbrirMesaTerraza(object sender, EventArgs e,string BotonText)
        {
            FormMesaTerr terraza = new FormMesaTerr(BotonText);
            terraza.Show();
            this.Hide();
        }

        private void FormTerraza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Admin = false;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.MesaAbiertaSalon = false;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSalones salones = new FormSalones();

            salones.Show();
        }
    }
}
