using MySql.Data.MySqlClient;
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
    /// Método para eliminar un producto
    /// </summary>
    public partial class FormEliminar : Form
    {
        /// <value>
        /// Metodo que usaremos para asignar el textbox.Text
        /// </value>
        string nombre;
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            nombre = val_eliminarProd.Text;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "restaurante";

            ///<summary>
            ///Abrimos base de datos para poder eliminar el producto(Si este existe)
            /// </summary>
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand query = conn.CreateCommand();
            conn.Open();
            string codigo = Properties.Settings.Default.cod_prod.ToString();
            query.CommandText = "Select nombre from productos where nombre= '"+ nombre +"' ";

            try
            {
                
                MySqlDataReader r = query.ExecuteReader();
                if(r.Read() == true)
                {
                    conn.Close();
                    try
                    {
                        conn.Open();
                        query.CommandText = "Delete from productos where nombre = '" + nombre + "' ";
                        query.ExecuteNonQuery();
                        MessageBox.Show("Producto eliminado");
                    }
                    ///<exception cref="MySqlException">Error con la base de datos</exception>
                    catch (MySqlException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                ///<summary>
                ///Si el nombre del prodcto que quiere borrar el usuario no existe, salta este mensaje
                ///</summary>
                else
                    MessageBox.Show("No existe un producto con ese nombre");
               
                this.Close();

            }
            ///<exception cref="MySqlException">Error base de datos</exception>
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        
        }
    }
}
