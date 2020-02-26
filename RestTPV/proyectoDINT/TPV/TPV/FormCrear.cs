using System;
using MySql.Data.MySqlClient;
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
    /// En este form podremos ir a salon o a terraza
    /// Podemos registrarnos como administrador
    /// Agregar o eliminar productos(Si has iniciado sesión como admin
    /// Hacer arqueo de la caja
    /// </summary>
    public partial class FormSalones : Form
    {
        /// <value> 
        /// Variables globales que inicializaremos al los getters de FormUsuarios y FormSesion 
        /// </value>
        string NombreSesion;
        string pwdSesion;
        string valorNombre;
        string ValorPwd;

       /// <value>
       /// Variable para identificar un boton
       /// </value>
        private string botonArrastrando = "";

        /// <summary>
        /// Constructor form salones
        /// </summary>
        public FormSalones()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(90, Color.Black);
            BotonCerrarSesion.Hide();
            if(Properties.Settings.Default.Admin == true)
            {
                BotonCerrarSesion.Show();
                pictureBox3.Hide();
            }
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Point l = this.PointToClient(Cursor.Position);
            if (((Button)sender).Name == botonArrastrando)
            {
                ((Button)sender).Location = l;
            }
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            botonArrastrando = ((Button)sender).Name;
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            botonArrastrando = "";
        }

        private void butonSalon_Click(object sender, EventArgs e)
        {
            FormSalon salon = new FormSalon();

            salon.Show();
            FormSalones form = new FormSalones();
            this.Hide();

        }
        /// <summary>
        /// Método para acceder a terraza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTerraza_Click(object sender, EventArgs e)
        {
            FormTerraza terraza = new FormTerraza();
               
            terraza.Show();
            this.Hide();
        }

        /// <summary>
        /// Método de administración de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ///<value> cont solo sirve para que la primera vez que accedas, te muestre un form para crear un usuario</value>
            if (Properties.Settings.Default.cont == 0)
            {
                FormUsuario usuario = new FormUsuario();

                if (usuario.ShowDialog() == DialogResult.OK)
                {
                    string user = usuario.user;
                    string pwd = usuario.pwd;

                    ///<summary>
                    ///Conectamos con la base de datos
                    ///</sumary>
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = "localhost";
                    builder.UserID = "root";
                    builder.Password = "";
                    builder.Database = "restaurante";

                    MySqlConnection conn = new MySqlConnection(builder.ToString());
                    MySqlCommand query = conn.CreateCommand();

                    ///<summary>
                    ///Si ya hay una cuenta de admin, antes de añadir otra, borramos la que hay previamente
                    /// </summary>
                    query.CommandText = "Delete from usuarios";
                    try
                    {
                        conn.Open();
                        query.ExecuteNonQuery();
                    }

                    ///<exception cref="MySqlException">Error al insertar en la base de datos</exception>
                    catch (MySqlException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    ///<sumary>
                    ///Insertamos en la base de datos los valores intoducidos por el usuario
                    /// </sumary>

                    if (usuario.user != "" && usuario.pwd != "")
                    {

                        query.CommandText = "INSERT INTO usuarios (nombUsuario,contraseña) value ('" + usuario.user + "','" + usuario.pwd + "')";

                        try
                        {
                            Properties.Settings.Default.cont++;
                            Properties.Settings.Default.Save();
                            query.ExecuteNonQuery();
                            MessageBox.Show("Usuario creado correctamente");

                        }
                        ///<exception cref="MySqlException">Error al insertar en la base de datos</exception>
                        catch (MySqlException exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                    else
                        MessageBox.Show("No has introducido ningún valor");
                }
            }
            else
            {
                ///<summary> 
                ///Si ya hemos creado un usuario anteriormente, iremos  este form
                /// </summary>
                FormSesion sesion = new FormSesion();

                ///<summary>
                ///Abrimos formSesion
                /// </summary>
                if (sesion.ShowDialog() == DialogResult.OK)
                {
                    ///<value>
                    ///Valores que el usuario introduce en FormSesiones
                    ///sesion.NombreAdmin, sesion.pwd son getters de la clase sesion
                    /// </value>
                    NombreSesion = sesion.NombreAdmin;
                    pwdSesion = sesion.pwd;
                    ///<exception cref="MySqlException">Error al insertar en la base de datos</exception>
                    try
                    {
                        ///<summary>
                        ///Abrimos base de datos
                        /// </summary>
                        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                        builder.Server = "localhost";
                        builder.UserID = "root";
                        builder.Password = "";
                        builder.Database = "restaurante";

                        MySqlConnection conn = new MySqlConnection(builder.ToString());
                        MySqlCommand query = conn.CreateCommand();
                        conn.Open();

                        query.CommandText = "SELECT nombUsuario,contraseña from usuarios";
                        MySqlDataReader reader = query.ExecuteReader();
                        ///<summary>
                        ///Leemos las filas que devuelve la consulta
                        /// </summary>
                        while (reader.Read())
                        {
                            ///<value>
                            ///Valores que devuelven la consulta
                            /// </value>
                            valorNombre = (string)reader[0];
                            ValorPwd = (string)reader[1];
                        }


                        ///<sumary>
                        ///Aqui comprobamos que si los valores que introduce
                        ///son válidos o no
                        /// </sumary>
                        if (valorNombre != null && ValorPwd != null)
                        {
                            if (valorNombre.Equals(NombreSesion) && ValorPwd.Equals(pwdSesion))
                            {

                                Properties.Settings.Default.Admin = true;
                                BotonCerrarSesion.Show();
                                pictureBox3.Hide();

                                ///<summary>
                                ///Cerramos reader y conexion
                                /// </summary>
                                reader.Close();
                                conn.Close();

                            }
                            else
                            {
                                ///<summary> 
                                ///Si no son válidos los valores introducidos
                                /// </summary>
                                MessageBox.Show("Nombre o contraseña incorrecta");
                                reader.Close();
                                conn.Close();
                            }
                        }
                        ///<summary> 
                        ///Si el usuario no introduce ningún dato
                        /// </summary>
                        else
                            MessageBox.Show("No se han introducido valores para usuario y/o contraseña");
                    }
                    catch(MySqlException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    
                    
                }
            

            }

        }

        /// <summary>
        /// Método para abrir formGestion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarProductos_Click(object sender, EventArgs e)
        {
            ///<value>
            ///Properties.Settings.Default.Admin
            ///Con esta variable gestionaremos el inicio de sesión de el usuario
            /// </value>
            if (Properties.Settings.Default.Admin == true)
            {
                Form2Gestion gestion = new Form2Gestion();
                gestion.Show();
            }
            else
                MessageBox.Show("Debes iniciar sesion como administrador");
        }

        /// <summary>
        /// Método para mostrar FormArqueo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Admin == true)
            {
                FormArqueo arqueo = new FormArqueo();
                arqueo.ShowDialog();
            }
            else
                MessageBox.Show("Debes iniciar sesión como administrador");
        }

        /// <summary>
        /// Método que el usuario usa para cerrar sesión manualmente por medio de un boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Admin = false;
            Properties.Settings.Default.Save();
            pictureBox3.Show();
            BotonCerrarSesion.Hide();
        }

        /// <summary>
        /// Método para cerrar el programa con la x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSalones_FormClosed(object sender, FormClosedEventArgs e)
        {
            ///<summary>
            ///Cerramos la sesión del administrador si el programa acaba
            /// </summary>
            Properties.Settings.Default.Admin = false;
            Properties.Settings.Default.Save();
            Application.Exit();
        }



    }
}
