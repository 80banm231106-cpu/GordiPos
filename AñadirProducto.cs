using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace interfaz_de_caja_registradora
{
    public partial class FormAñadirProducto : Form
    {
        // 1. Nuestra bandera para avisarle al inventario que sí se guardó algo
        public bool productoGuardado = false;

        public int idProductoSeleccionado = 0;

        public FormAñadirProducto()
        {
            InitializeComponent();
        }

        public FormAñadirProducto (int id, string nombreActual, int stockActual)
        {
            InitializeComponent();

            idProductoSeleccionado = id;
            txtNombre.Text = nombreActual;
            txtStock.Text = stockActual.ToString();

            // Le cambiamos el texto al botón para que se vea genial
            btnGuardar.Text = "Actualizar";
            this.Text = "Editar Producto";
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
                // --- NUEVO: El botón decide qué hacer basado en el ID ---
                if (idProductoSeleccionado == 0)
                {
                    // MODO AÑADIR (Tu código original)
                    string sql = "INSERT INTO inventario (nombre, existencia) VALUES (@nom, @cant)";
                    MySqlCommand comando = new MySqlCommand(sql, bd.conectar);
                    comando.Parameters.AddWithValue("@nom", nombre);
                    comando.Parameters.AddWithValue("@cant", stock);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("¡Producto agregado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // MODO EDITAR (El nuevo código UPDATE)
                    string sql = "UPDATE inventario SET nombre = @nom, existencia = @cant WHERE id_inventario = @id";
                    MySqlCommand comando = new MySqlCommand(sql, bd.conectar);
                    comando.Parameters.AddWithValue("@nom", nombre);
                    comando.Parameters.AddWithValue("@cant", stock);
                    comando.Parameters.AddWithValue("@id", idProductoSeleccionado);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("¡Producto actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
