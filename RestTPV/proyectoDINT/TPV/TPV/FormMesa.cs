using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TPV
{
    /// <summary>
    /// Form en el que podremos comandar una mesa en salón
    /// </summary>
    public partial class FormMesa : Form
    {
        /// <value>
        /// Variables para leer los productos desde la basde de datos
        /// </value>
        string nombre = "", descripcion, categoria;
        float coste, precio;
        int cod_prod, cantidad;
        byte[] foto;
        public string numMesa;
        string precioTotal = "", precioMesa;
        /// <value>
        /// Variable para saber que producto eliminar en la base de datos por su id
        /// </value>
        int id;

        /// <value>
        /// Variable que acumula el precio total según los productos que vamos añadiendo
        /// </value>
        double total { get; set; }

        /// <value>
        /// Variable global Control de usuario ControlProd
        /// </value>
        ControlProd control;

        /// <value>
        /// Variable global Control de usuario Menu
        /// </value>
        Menu menu;

        /// <value>
        /// Contador para administrar el proceso
        /// </value>
        int cont = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numMesa"></param>
        /// <value> Numero de mesa que abrimos en el form anterior</value>
        public FormMesa(string numMesa)
        {
            this.numMesa = numMesa;
            InitializeComponent();
            val_total.Text = "0";
            LabelMesa.Text = numMesa;
            this.WindowState = FormWindowState.Maximized;
            total = 0;

            ///<summary>
            ///Abrimos base de datos y creamos el formulario con sus productos ya comandados(Si ya ha sido usada esta mesa anteriormente)
            /// </summary>
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
                query.CommandText = String.Format("Select nombre,precioMesa,precioTotal,id,tipo from productosmesa where numMesa = '{0}' and tipo='{1}' ", LabelMesa.Text, "s");
                query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                MySqlDataReader r = query.ExecuteReader();

                while (r.Read())
                {
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
            ///<exception cref="MySqlException">Error con la base de datos</exception>
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Método para insertar en el panel2 todos los productos con categoría bebida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtonBebidas_Click(object sender, EventArgs e)
        {

            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='bebida' ");

        }


        /// <summary>
        /// Método para insertar en el panel2 todos los productos con categoría aperitivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnApreritivos_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='aperitivo' ");
        }


        /// <summary>
        /// Método para insertar en el panel2 todos los productos con categoría bocadillos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBocadillos_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='bocadillos' ");
        }


        /// <summary>
        /// Método para insertar en el panel2 todos los productos con categoría platos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlatos_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='platos' ");
        }

        /// <summary>
        /// Método para insertar en el panel2 todos los productos con categoría cafés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCafe_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='cafes' ");



        }

        /// <summary>
        /// Método para insertar en el panel2 todos los productos con categoría postres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtonPostres_Click(object sender, EventArgs e)
        {

            Panel2.Controls.Clear();
            ConectaBD("select * from productos where categoria ='postres' ");
        }

        /// <summary>
        /// Método para poder cobrar una mesa y que al cobrarla, el precio total se acumule en el arqueo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                        ///<summary>
                        ///Borramos estos productos de la base de datos una vez se haya pagado la mesa
                        /// </summary>
                        conn.Open();
                        query.CommandText = String.Format("delete from productosmesa where numMesa = '{0}' and tipo='{1}' ", LabelMesa.Text, "s");
                        query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                        query.ExecuteNonQuery();

                        total = 0;
                        panel3.Controls.Clear();
                        val_total.Text = "0";
                        conn.Close();
                        FormSalon salon = new FormSalon();
                        salon.Show();
                        this.Hide();
                    }
                    ///<exception cref="MySqlException">Error con la base de datos</exception>
                    catch (MySqlException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }

            }
            ///<summary>
            ///No se puede cobrar una mesa si no has abierto la caja anteriormente
            ///Esto hemos decidirlo así para que antes de cobrar metas el cambio que hay en la caja.
            ///Con esto, podemos controlar el efectivo total que hay en caja y el efectivo generado ese dia
            ///</summary>

            ///<example>
            ///
            /// Total facturado ====> Efectivo generado por ventas desde que se abre la caja hasta que se cierra
            /// 
            /// Total efectivo ===> Efectivo generado por las ventas desde que se abre la caja hasta que se cierra + cambio en caja
            /// 
            /// </example>
            else
                MessageBox.Show("Tienes que abrir la caja para poder cobrar");




        }

        /// <summary>
        /// Método para llevar un seguimiento en las ventas de tarjeta y luego mostrarlo en arqueo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCobrarTarjeta_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CajaAbierta == true)
            {
                Properties.Settings.Default.DineroTarjeta += float.Parse(val_total.Text);
                Properties.Settings.Default.Save();

                total = 0;
                panel3.Controls.Clear();
            }


            ///<summary>
            ///No se puede cobrar una mesa si no has abierto la caja anteriormente
            ///Esto hemos decidirlo así para que antes de cobrar metas el cambio que hay en la caja.
            ///Con esto, podemos controlar el efectivo total que hay en caja y el efectivo generado ese dia
            ///</summary>
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

                ///<summary>
                ///Borramos estos productos de la base de datos una vez se haya pagado la mesa
                /// </summary>
                conn.Open();
                query.CommandText = String.Format("delete from productosmesa where numMesa = '{0}' and tipo='{1}' ", LabelMesa.Text, "s");
                query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                query.ExecuteNonQuery();

                total = 0;
                panel3.Controls.Clear();
                val_total.Text = "0";
                conn.Close();

            }
            ///<exception cref="MySqlException">Error con la base de datos</exception>
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }

            FormSalon salon = new FormSalon();
            salon.Show();
            this.Hide();

        }




        private void BotonMarchar_Click(object sender, EventArgs e)
        {
            FormSalon salon = new FormSalon();
            salon.Show();
            this.Hide();
           
           cont = 0;

        }

        /// <summary>
        /// Método creado que usamos para conectarnos a la base de datos y no repetir código
        /// </summary>
        /// <param name="consulta"></param>
        /// <value>String que pasaremos como parámetro, este string será la propia consulta</value>
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

                    ///<summary>
                    ///Creamos un evento para cada evento personalizado
                    ///</summary>
                    this.control.PulsarImagen += new EventHandler((sender1, e1) => LanzarEvento(sender1, e1));
                }
                
                r.Close();
                conn.Close();
            }
            ///<exception cref="MySqlException">Error con la base de datos</exception>
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        /// <summary>
        /// Este evento hará que cuando le pinchemos sobre una imagen cargada de la base de datos
        /// el nombre y el precio se muestre en el ticket (panel3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LanzarEvento(object sender, EventArgs e)
        {
            
            menu = new Menu(Properties.Settings.Default.NombreMenu, Properties.Settings.Default.PrecioMenu.ToString().Replace(".",","),Properties.Settings.Default.IdProd);
            Properties.Settings.Default.Save();

            ///<summary>
            ///Creamos evento para cada evento personalizado Menu
            /// </summary>
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

            ConectaBD("INSERT INTO productosmesa (numMesa,nombre,precioMesa,precioTotal,id,tipo) value ('" + LabelMesa.Text + "','" + Properties.Settings.Default.NombreMenu + "','" + Properties.Settings.Default.PrecioMenu.ToString().Replace(",", ".") + "','" + val_total.Text.Replace(",", ".") + "','" + Properties.Settings.Default.IdProd + "','" + 's' + "' )");

        }

        /// <summary>
        /// Evento para control personalizado Menu
        /// Con este evento borraremos un producto del ticket dandole a la x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                query.CommandText = String.Format("DELETE FROM productosmesa where numMesa= '" + LabelMesa.Text + "' AND id='" + Properties.Settings.Default.ContolBorrado + "' AND tipo= 's' ");
                query = new MySql.Data.MySqlClient.MySqlCommand(query.CommandText, conn);
                query.ExecuteNonQuery();

                try
                {
                    query.CommandText = String.Format("Update productosmesa set precioTotal='" + total + "' where id = " + Properties.Settings.Default.IdProd + " And numMesa=  '" + LabelMesa.Text + "' AND tipo ='s' ");
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

        /// <summary>
        /// Evento para cerrar programa si pulsamo la x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMesa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Admin = false;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
        
    }
}


