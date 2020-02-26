using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class AnadirProductos : Form
    {
        double valor1, valor3;
        int valor2;
        byte[] foto;
        public AnadirProductos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
      

        private void txtprecio_TextChanged_1(object sender, EventArgs e)
        {
            txtprecio.ForeColor = Color.Black;
        }

        private void txtcantidad_TextChanged_1(object sender, EventArgs e)

        {
            txtcantidad.ForeColor = Color.Black;
        }

        private void txtcoste_TextChanged_1(object sender, EventArgs e)
        {
            txtcoste.ForeColor = Color.Black;
        }

        private void insertFot_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult rs = fo.ShowDialog();

            if (rs == DialogResult.OK)
            {
                    imgprod.Image = Image.FromFile(fo.FileName);
                    using (MemoryStream mStream = new MemoryStream())
                    {
                        imgprod.Image.Save(mStream, imgprod.Image.RawFormat);
                        foto = mStream.ToArray();
                    }
                
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            añadir_prod();
            
        }
        public void añadir_prod()
        {

            bool cost = Double.TryParse(txtcoste.Text, out valor1);
            bool pre = Double.TryParse(txtprecio.Text, out valor3);
            bool cant = Int32.TryParse(txtcantidad.Text, out valor2);


            if (txtnombre.Text != "" && txtprecio.Text != "" && txtcantidad.Text != "" && comboBoxCateg.SelectedIndex != -1)
            {

                if (cost == true && pre == true && cant == true)
                {
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = "localhost";
                    builder.UserID = "root";
                    builder.Password = "";
                    builder.Database = "restaurante";

                    MySqlConnection conn = new MySqlConnection(builder.ToString());
                    MySqlCommand query = conn.CreateCommand();
                    conn.Open();
                    string codigo = Properties.Settings.Default.cod_prod.ToString();
                    query.CommandText = "INSERT INTO productos(nombre,descripcion,coste,cod_prod,precio,cantidad,foto,categoria)values(@nombre,@descripcion,@coste,@cod_prod,@precio,@cantidad,@foto,@categoria)";

                    query.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    query.Parameters.AddWithValue("@descripcion", textdesc.Text);
                    query.Parameters.AddWithValue("@coste", txtcoste.Text);
                    query.Parameters.AddWithValue("@cod_prod", codigo);
                    query.Parameters.AddWithValue("@precio", txtprecio.Text);
                    query.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                    query.Parameters.AddWithValue("@foto", foto);
                    query.Parameters.AddWithValue("@categoria", comboBoxCateg.Text);

                    try
                    {
                        query.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Producto añadido correctamente");
                        this.Close();
                        Properties.Settings.Default.cod_prod++;
                        Properties.Settings.Default.Save();

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                    MessageBox.Show("Error al introducir los datos. Comprueba que los datos introducidos sean correcto ");
            }
            else
                MessageBox.Show("Tienes que rellenar todos los datos");




        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

