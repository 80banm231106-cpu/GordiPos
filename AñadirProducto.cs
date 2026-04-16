using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace interfaz_de_caja_registradora
{
    public partial class FormAñadirProducto : Form
    {
        // 1. Nuestra bandera para avisarle al inventario que sí se guardó algo
        public bool productoGuardado = false;

        public FormAñadirProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validamos que no dejen el nombre vacío
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, escribe el nombre del producto.");
                return;
            }

            // Validamos que el stock sea un número
            int stock;
            if (!int.TryParse(txtStock.Text.Trim(), out stock))
            {
                MessageBox.Show("El stock debe ser un número válido.");
                return;
            }

            ConexionBD bd = new ConexionBD();
            bd.abrir();

            try
            {
                // Insertamos el nuevo producto en la tabla inventario
                string sql = "INSERT INTO inventario (nombre, existencia) VALUES (@nom, @cant)";
                MySqlCommand comando = new MySqlCommand(sql, bd.conectar);
                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@cant", stock);

                comando.ExecuteNonQuery();

                MessageBox.Show("¡Producto agregado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Encendemos la bandera y cerramos la ventanita
                productoGuardado = true;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
            }
            finally
            {
                bd.cerrar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Simplemente cerramos la ventana sin hacer nada
            this.Close();
        }
    }
}
