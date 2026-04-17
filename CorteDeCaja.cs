using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz_de_caja_registradora
{
    public partial class CorteDeCaja : Form
    {
        public CorteDeCaja()
        {
            InitializeComponent();
        }
        // 1. Creamos variables a nivel de clase para usarlas en todo el formulario
        decimal fondoInicial = 0m;
        decimal ventasDelDia = 0m;
        decimal totalEsperado = 0m;

        private void CorteDeCaja_Load(object sender, EventArgs e)
        {

            ObtenerVentasReales();
        }

        private void ObtenerVentasReales()
        {
            ConexionBD bd = new ConexionBD();
            bd.abrir();

            try
            {
                // 1. Obtenemos el fondo inicial (puedes traerlo de una tabla de configuracion o dejarlo fijo por ahora)
                string sqlFondo = "SELECT monto_inicial FROM Apertura_caja WHERE DATE(fecha) = CURDATE() ORDER BY id_apertura DESC LIMIT 1";
                MySqlCommand cmdFondo = new MySqlCommand(sqlFondo, bd.conectar);
                object resFondo = cmdFondo.ExecuteScalar();

                // Si existe una apertura hoy, la usamos; si no, le ponemos 0 o un valor por defecto
                fondoInicial = (resFondo != DBNull.Value && resFondo != null) ? Convert.ToDecimal(resFondo) : 0m;

                // 2. Sumamos todas las ventas registradas hoy en la base de datos
                // Nota: Asegúrate que tu tabla de ventas tenga una columna 'total'
                string sql = "SELECT SUM(total) FROM ventas WHERE DATE(fecha) = CURDATE()";
                MySqlCommand comando = new MySqlCommand(sql, bd.conectar);

                object resultado = comando.ExecuteScalar();

                // Si hay ventas hoy, las guardamos; si no, se queda en 0
                ventasDelDia = (resultado != DBNull.Value) ? Convert.ToDecimal(resultado) : 0m;

                // 3. Llenamos los textos de la interfaz
                lblCajero.Text = "Cajero: admin"; // Aquí podrías poner el nombre del que hizo login
                txtFondoinicial.Text = fondoInicial.ToString("C");
                txtVentastotales.Text = ventasDelDia.ToString("C");

                // 4. Calculamos el total esperado
                totalEsperado = fondoInicial + ventasDelDia;
                txtTotalesperado.Text = totalEsperado.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el corte: " + ex.Message);
            }
            finally
            {
                bd.cerrar();
            }
        }

        private void txtEfectivoContado_TextChanged(object sender, EventArgs e)
        {
            // El resto de tu lógica de diferencia se mantiene igual...
            if (decimal.TryParse(txtEfectivoContado.Text, out decimal efectivoReal))
            {
                decimal diferencia = efectivoReal - totalEsperado;
                lblDiferencia.Text = "Diferencia: " + diferencia.ToString("C");

                if (diferencia == 0) lblDiferencia.ForeColor = Color.Green;
                else if (diferencia < 0) lblDiferencia.ForeColor = Color.Red;
                else lblDiferencia.ForeColor = Color.Blue;
            }
        }

        private void btnFinalizarCorte_Click(object sender, EventArgs e)
        {
            // 1. VALIDACIÓN: Verificamos que haya un número en el efectivo contado
            if (!decimal.TryParse(txtEfectivoContado.Text, out decimal efectivoReal))
            {
                MessageBox.Show("Por favor, ingrese el total de dinero contado en caja.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEfectivoContado.Focus();
                return;
            }

            // 2. CONFIRMACIÓN: ¿Seguro que quiere cerrar?
            DialogResult respuesta = MessageBox.Show("¿Deseas finalizar el turno y guardar el corte de caja?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // 3. CÁLCULO DE DIFERENCIA (lo hacemos aquí antes de guardar)
                decimal diferencia = efectivoReal - totalEsperado;

                // 4. GUARDAR EN LA BASE DE DATOS
                ConexionBD bd = new ConexionBD();
                bd.abrir();

                try
                {
                    // Insertamos en la tabla cierre_caja usando los nombres de columnas de tu imagen
                    string sql = @"INSERT INTO cierre_caja (fecha, total, monto_inicial, monto_real, diferencia) 
                           VALUES (NOW(), @ventas, @inicial, @real, @dif)";

                    MySqlCommand comando = new MySqlCommand(sql, bd.conectar);

                    // Pasamos los valores de las variables que ya calculamos en el Load y el TextChanged
                    comando.Parameters.AddWithValue("@ventas", ventasDelDia);
                    comando.Parameters.AddWithValue("@inicial", fondoInicial);
                    comando.Parameters.AddWithValue("@real", efectivoReal);
                    comando.Parameters.AddWithValue("@dif", diferencia);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    if (filasInsertadas > 0)
                    {
                        MessageBox.Show("¡Corte guardado exitosamente en la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // --- 5. REGRESAR AL LOGIN Y CERRAR LA CAJA ---

                        // Abrimos el login (ajusta el nombre si tu form se llama diferente, ej: LoginUsuario)
                        login ventanaLogin = new login();
                        ventanaLogin.Show();

                        // Cerramos esta ventana de Corte
                        this.Close();

                        // Cerramos el Form1 (la caja registradora) para que nadie más la use
                        Form formularioCaja = Application.OpenForms["Form1"];
                        if (formularioCaja != null) formularioCaja.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el corte: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bd.cerrar();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}