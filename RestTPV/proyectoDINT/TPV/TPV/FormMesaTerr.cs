using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TPV
{

    /// <summary>
    /// Este form es muy parecido a FormMesa
    /// Lo que cambia de este form es que en la base de datos, insertamos los productos en la base de datos productosmesa con tipo t
    /// Esto lo hemos decidido hacer así para controlar que mesa con que productos esta abierta en salon o en terraza
    /// Para ver alguna mesa de salón tenemos que poner en la consulta de la base de datos tipo= 's'
    /// Para ver alguna mesa de salón tenemos que poner en la consulta de la base de datos tipo= 't'
    /// Con esto conseguimos separar las mesas del salón con las de terraza
    /// </summary>
    public partial class FormMesaTerr : Form
    {
        string nombre = "", descripcion, categoria;
        float coste, precio;
        int cod_prod, cantidad;
        byte[] foto;
        public string numMesa;
        string precioTotal = "", precioMesa;
        int id;
        double total { get; set; }
        ControlProd control;
        Menu menu;
        int cont = 0;


        public FormMesaTerr(string numMesa)
        {
            this.numMesa = numMesa;
            InitializeComponent();
            val_total.Text = "0";
            LabelMesa.Text = numMesa;
            this.WindowState = FormWindowState.Maximized;
            total = 0;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "restaurante";
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand query = conn.CreateCommand();
            try
            {

                conn.Open();
                query.CommandText = String.Format("Select nombre,precioMesa,precioTotal,id,tipo from productosmesa where numMesa = '{0}' and tipo='{1}' ", LabelMesa.Text, "t");
                query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                MySqlDataReader r = query.ExecuteReader();

                while (r.Read())
                {
                    Properties.Settings.Default.MesaAbiertaSalon = true;
                    Properties.Settings.Default.Save();
                    nombre = (string)r[0];
                    precioMesa = (string)r[1];
                    precioTotal = (string)r[2];
                    id = (int)r[3];

                    Properties.Settings.Default.IdProd = id;
                    Menu menu = new Menu(nombre, precioMesa.Replace(".", ","), Properties.Settings.Default.IdProd);
                    Properties.Settings.Default.Save();
                    menu.BorrarEnMenu += new EventHandler((sender1, e1) => LanzarEvento2(sender1, e1));
                    this.panel3.Controls.Add(menu);
                }
                if (precioTotal.Equals(""))
                {

                }

                else
                    val_total.Text = precioTotal.Replace(".", ",");
                r.Close();
                conn.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtonBebidas_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='bebida' ");
        }

        private void BtnApreritivos_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='aperitivo' ");
        }

        private void BtnBocadillos_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='bocadillos' ");
        }

        private void BtnPlatos_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='platos' ");
        }

        private void BtnCafe_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='cafes' ");
        }

        private void BotonMarchar_Click(object sender, EventArgs e)
        {
            FormTerraza terraza = new FormTerraza();
            terraza.Show();
            this.Hide();

            cont = 0;
        }

        private void BotonCobrar_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CajaAbierta == true)
            {
                Properties.Settings.Default.DineroEfectivo += Convert.ToDouble(val_total.Text);
                Properties.Settings.Default.Save();

                FormCambio cambio = new FormCambio(val_total.Text);
                if (cambio.ShowDialog() == DialogResult.OK)
                {

                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = "localhost";
                    builder.UserID = "root";
                    builder.Password = "";
                    builder.Database = "restaurante";
                    MySqlConnection conn = new MySqlConnection(builder.ToString());
                    MySqlCommand query = conn.CreateCommand();
                    try
                    {

                        conn.Open();
                        query.CommandText = String.Format("delete from productosmesa where numMesa = '{0}' and tipo='{1}' ", LabelMesa.Text, "t");
                        query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                        query.ExecuteNonQuery();

                        total = 0;
                        panel3.Controls.Clear();
                        val_total.Text = "0";
                        conn.Close();
                        FormTerraza terraza = new FormTerraza();
                        terraza.Show();
                        this.Hide();
                    }
                    catch (MySqlException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }

            }
            else
                MessageBox.Show("Tienes que abrir la caja para poder cobrar");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormTerraza terraza = new FormTerraza();
            terraza.Show();
            this.Hide();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            FormTerraza terraza = new FormTerraza();
            terraza.Show();
            this.Hide();
        }

        private void BtnCobrarTarjeta_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CajaAbierta == true)
            {
                Properties.Settings.Default.DineroTarjeta += float.Parse(val_total.Text);
                Properties.Settings.Default.Save();

                total = 0;
                panel3.Controls.Clear();
            }
            else
                MessageBox.Show("Tienes que abrir la caja para poder cobrar");

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "restaurante";
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand query = conn.CreateCommand();
            try
            {
                conn.Open();
                query.CommandText = String.Format("delete from productosmesa where numMesa = '{0}' and tipo='{1}' ", LabelMesa.Text, "t");
                query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                query.ExecuteNonQuery();

                total = 0;
                panel3.Controls.Clear();
                val_total.Text = "0";
                conn.Close();

            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }

            FormTerraza terraza = new FormTerraza();
            terraza.Show();
            this.Hide();
        }

        private void BtonPostres_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='postres' ");
        }

        public void ConectaBD(string consulta)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "restaurante";
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand query = conn.CreateCommand();
            try
            {

                conn.Open();
                query.CommandText = consulta;
                MySqlDataReader r = query.ExecuteReader();
                while (r.Read())
                {
                    nombre = (string)r[0];
                    descripcion = (string)r[1];
                    coste = (float)r[2];
                    cod_prod = (int)r[3];
                    precio = (float)r[4];
                    cantidad = (int)r[5];
                    foto = (byte[])r[6];
                    categoria = (string)r[7];

                    control = new ControlProd(foto, nombre, precio);
                    this.Panel2.Controls.Add(control);
                    this.control.PulsarImagen += new EventHandler((sender1, e1) => LanzarEvento(sender1, e1));
                }

                r.Close();
                conn.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public void LanzarEvento(object sender, EventArgs e)
        {

            menu = new Menu(Properties.Settings.Default.NombreMenu, Properties.Settings.Default.PrecioMenu.ToString().Replace(".", ","), Properties.Settings.Default.IdProd);
            Properties.Settings.Default.Save();
            menu.BorrarEnMenu += new EventHandler((sender1, e1) => LanzarEvento2(sender1, e1));
            panel3.Controls.Add(menu);

            if (val_total.Text.Equals("0"))
            {
                total += Convert.ToDouble(Properties.Settings.Default.PrecioMenu.ToString());
                val_total.Text = total.ToString();
            }
            else
            {
                if (cont == 0)
                {
                    total = Convert.ToDouble(val_total.Text);
                    cont++;
                }
                total += Convert.ToDouble(Properties.Settings.Default.PrecioMenu.ToString().Replace(".", ","));
                val_total.Text = total.ToString();
            }

            ConectaBD("INSERT INTO productosmesa (numMesa,nombre,precioMesa,precioTotal,id,tipo) value ('" + LabelMesa.Text + "','" + Properties.Settings.Default.NombreMenu + "','" + Properties.Settings.Default.PrecioMenu.ToString().Replace(",", ".") + "','" + val_total.Text.Replace(",", ".") + "','" + Properties.Settings.Default.IdProd + "','" + 't' + "' )");

        }

        public void LanzarEvento2(object sender, EventArgs e)
        {
            panel3.Controls.Remove(Properties.Settings.Default.lineaMenu);
            total = Convert.ToDouble(Convert.ToDouble((val_total.Text)) - Properties.Settings.Default.CambioPrecio);
            val_total.Text = total.ToString();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "restaurante";
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand query = conn.CreateCommand();
            try
            {

                conn.Open();
                query.CommandText = String.Format("DELETE FROM productosmesa where numMesa= '" + LabelMesa.Text + "' AND id='" + Properties.Settings.Default.ContolBorrado + "' AND tipo= 't' ");
                query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                query.ExecuteNonQuery();

                try
                {
                    query.CommandText = String.Format("Update productosmesa set precioTotal='" + total + "' where id = " + Properties.Settings.Default.IdProd + " And numMesa=  '" + LabelMesa.Text + "' AND tipo ='t' ");
                    query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                    query.ExecuteNonQuery();

                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            query.ExecuteNonQuery();
            conn.Close();
        }
        private void FormMesaTerr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Admin = false;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

    }
}