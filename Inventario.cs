using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace interfaz_de_caja_registradora
{
    public partial class Inventario : Form
    {

        public Inventario()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarPantalla(string busqueda = "")
        {
            ConexionBD bd = new ConexionBD();
            bd.abrir();

            try
            {
                // 1. CARGAR LA TABLA Y EL BUSCADOR
                // Usamos LIKE para que busque coincidencias (ej. si escribes "hamb" traerá "hamburguesa")
                string sql = "SELECT id_inventario AS 'ID', nombre AS 'Nombre', existencia AS 'Stock' FROM inventario WHERE nombre LIKE @busqueda";
                MySqlCommand comando = new MySqlCommand(sql, bd.conectar);
                comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

                // El DataAdapter toma los datos y los mete en un DataTable (una tabla de memoria)
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tablaVirtual = new DataTable();
                adaptador.Fill(tablaVirtual);

                // Le pegamos la tabla de memoria a tu diseño visual
                dataGridView1.DataSource = tablaVirtual;

                // 2. CALCULAR ESTADÍSTICAS (Los cuadritos de abajo)
                // 2. CALCULAR ESTADÍSTICAS (Los cuadritos de abajo)
                int sumaTotalPiezas = 0;
                int productosBajos = 0;

                foreach (DataRow fila in tablaVirtual.Rows)
                {
                    // En lugar de contar filas, sumamos la cantidad física de piezas
                    sumaTotalPiezas += Convert.ToInt32(fila["Stock"]);

                    // Nota: Si quieres que la alerta de Bajo Stock avise cuando queden 
                    // menos de 5 piezas en lugar de 10, solo cambia el número 10 de aquí abajo
                    if (Convert.ToInt32(fila["Stock"]) < 10)
                    {
                        productosBajos++;
                    }
                }

                txtTotal.Text = sumaTotalPiezas.ToString();
                txtBajoStock.Text = productosBajos.ToString();

                // Categorías se queda en 0 por ahora porque no tenemos esa columna en la BD
                txtCategorias.Text = "0";

                // (Opcional) Si en tu base de datos tienes una columna 'categoria', podrías contarla aquí.
                // Si no la tienes aún, lo dejamos en 0.
                txtCategorias.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message);
            }
            finally
            {
                bd.cerrar();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Cada vez que escribas una letra, mandará a llamar al motor que hicimos arriba
            ActualizarPantalla(txtBuscar.Text.Trim());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Revisamos que sí hayan seleccionado un renglón en la tabla
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult pregunta = MessageBox.Show("¿Seguro que deseas eliminar este producto del inventario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (pregunta == DialogResult.Yes)
                {
                    // Extraemos el ID oculto de la fila que seleccionaron
                    int idSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                    ConexionBD bd = new ConexionBD();
                    bd.abrir();

                    string sql = "DELETE FROM inventario WHERE id_inventario = @id";
                    MySqlCommand comando = new MySqlCommand(sql, bd.conectar);
                    comando.Parameters.AddWithValue("@id", idSeleccionado);

                    comando.ExecuteNonQuery();
                    bd.cerrar();

                    // Refrescamos la pantalla para que desaparezca
                    ActualizarPantalla();
                    MessageBox.Show("Producto eliminado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona toda la fila del producto que deseas eliminar (da clic en la flechita de la izquierda de la tabla).");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Creamos la ventanita
            FormAñadirProducto ventanaAgregar = new FormAñadirProducto();

            // 2. La abrimos en modo pausa (el usuario no puede tocar lo de atrás)
            ventanaAgregar.ShowDialog();

            // 3. Revisamos si el usuario le dio a "Guardar" y todo salió bien
            if (ventanaAgregar.productoGuardado == true)
            {
                // Llamamos al motor que creamos en el paso anterior para refrescar la tabla gris
                ActualizarPantalla();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Revisamos que el usuario sí haya seleccionado un renglón
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 2. Extraemos los datos del renglón que seleccionó
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                string nombreActual = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                int stockActual = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Stock"].Value);

                // 3. Abrimos la ventanita, pero usando el NUEVO constructor que le pasa los datos
                FormAñadirProducto ventanaEditar = new FormAñadirProducto(id, nombreActual, stockActual);
                ventanaEditar.ShowDialog();

                // 4. Si el usuario le dio a "Actualizar" y todo salió bien, refrescamos la tabla
                if (ventanaEditar.productoGuardado == true)
                {
                    ActualizarPantalla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona toda la fila del producto que deseas editar (dando clic en la flechita de la izquierda de la tabla).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
