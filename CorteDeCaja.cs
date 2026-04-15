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
        decimal fondoInicial = 500.00m; // Simulamos que abriste la caja con $500
        decimal ventasDelDia = 1250.50m; // Simulamos que vendiste $1250.50 en hamburguesas
        decimal totalEsperado = 0m;

        private void CorteDeCaja_Load(object sender, EventArgs e)
        {
            // 2. Llenamos los Labels con nuestros datos "fake"
            lblCajero.Text = "Cajero: admin"; // Tu usuario provisional

            // El ToString("C") formatea el número automáticamente con el signo de $ y decimales
            lblFondoInicial.Text = fondoInicial.ToString("C");
            lblVentasEfectivo.Text = ventasDelDia.ToString("C");

            // 3. Calculamos cuánto dinero DEBERÍA haber en la caja
            totalEsperado = fondoInicial + ventasDelDia;
            lblTotalEsperado.Text = totalEsperado.ToString("C");
        }

        private void txtEfectivoContado_TextChanged(object sender, EventArgs e)
        {
            // Verificamos que la caja no esté vacía y que el usuario haya escrito un número válido
            if (decimal.TryParse(txtEfectivoContado.Text, out decimal efectivoReal))
            {
                // Calculamos la diferencia
                decimal diferencia = efectivoReal - totalEsperado;

                // Mostramos el resultado
                lblDiferencia.Text = "Diferencia: " + diferencia.ToString("C");

                // Le damos color para que sea más visual
                if (diferencia == 0)
                {
                    lblDiferencia.ForeColor = Color.Green; // ¡Corte perfecto!
                }
                else if (diferencia < 0)
                {
                    lblDiferencia.ForeColor = Color.Red; // ¡Falta dinero!
                }
                else
                {
                    lblDiferencia.ForeColor = Color.Blue; // Sobra dinero
                }
            }
            else
            {
                // Si borran todo o escriben letras, limpiamos la diferencia
                lblDiferencia.Text = "Diferencia: $0.00";
                lblDiferencia.ForeColor = Color.Black;
            }
        }

        private void btnFinalizarCorte_Click(object sender, EventArgs e)
        {
            // --- 1. PRIMERO HACEMOS LA VALIDACIÓN ---
            // TryParse intenta convertir el texto a número. 
            // El símbolo "!" al principio significa "Si NO se pudo convertir..."
            if (!decimal.TryParse(txtEfectivoContado.Text, out decimal efectivoReal))
            {
                // Mostramos el mensaje de error
                MessageBox.Show("Por favor, ingrese una cantidad válida en el Efectivo Contado. No se permiten letras ni dejar el espacio vacío.",
                                "Dato Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                // Ponemos el cursor parpadeando de vuelta en la cajita para que lo corrija
                txtEfectivoContado.Focus();

                // ¡SUPER IMPORTANTE! El 'return' funciona como un freno. 
                // Detiene el código aquí mismo para que no avance a hacer el corte.
                return;
            }
            // ----------------------------------------


            // --- 2. SI PASÓ LA VALIDACIÓN, CONTINUAMOS NORMALMENTE ---
            // Le preguntamos al cajero si está completamente seguro
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de finalizar el corte de caja con estos datos?",
                                                     "Confirmar Corte",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Evaluamos su respuesta
            if (respuesta == DialogResult.Yes)
            {
                // --- AQUÍ EN EL FUTURO IRÁ EL CÓDIGO PARA GUARDAR EN LA BASE DE DATOS ---

                MessageBox.Show("¡Corte de caja guardado y finalizado exitosamente!",
                                "Corte Exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Cerramos la pantalla del corte para regresar al menú
                this.Close();
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
    }
}