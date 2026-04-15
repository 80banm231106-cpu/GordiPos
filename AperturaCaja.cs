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
    public partial class AperturaCaja : Form
    {
        public bool aperturaExitosa=false;  
        public AperturaCaja()
        {
            InitializeComponent();
        }

        private void AperturaCaja_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que el cajero sí escribió dinero válido
            double fondoInicial;
            if (!double.TryParse(txtFondo.Text.Trim(), out fondoInicial))
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida para el fondo de caja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Nos conectamos a MySQL
            ConexionBD bd = new ConexionBD();
            bd.abrir();

            try
            {
                // 3. Le decimos a la base de datos que acabamos de abrir turno
                // Como 'fecha' y 'estado' tienen DEFAULT en tu SQL, solo mandamos el monto
                string sql = "INSERT INTO apertura_caja (monto_inicial) VALUES (@monto)";

                MySqlCommand comando = new MySqlCommand(sql, bd.conectar);
                comando.Parameters.AddWithValue("@monto", fondoInicial);

                // Ejecutamos la orden de guardado
                comando.ExecuteNonQuery();

                MessageBox.Show($"Caja abierta exitosamente con un fondo de: ${fondoInicial.ToString("0.00")}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                aperturaExitosa = true;
                this.Close();

                // 4. Cuando cierren el menú (al acabar el día), cerramos todo
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar la apertura: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bd.cerrar();
            }
        }
    }
}
