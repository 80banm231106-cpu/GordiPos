using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz_de_caja_registradora
{
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Comparamos si hay pedidos nuevos en el pizarrón global que aún no tengamos en la pantalla
            if (listBoxEnEspera.Items.Count != DatosCocina.PedidosEnEspera.Count)
            {
                // Limpiamos la lista visual
                listBoxEnEspera.Items.Clear();

                // Agregamos todos los pedidos actualizados
                foreach (string pedido in DatosCocina.PedidosEnEspera)
                {
                    listBoxEnEspera.Items.Add(pedido);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que el chef realmente haya seleccionado algo (si no, el programa explota)
            // -1 significa que no hay nada seleccionado
            if (listBoxEnEspera.SelectedIndex != -1)
            {
                // 2. Guardamos el texto del pedido seleccionado en una variable
                string pedidoSeleccionado = listBoxEnEspera.SelectedItem.ToString();

                // 3. Lo pegamos en la nueva columna de "En preparación"
                listBoxEnPreparacion.Items.Add(pedidoSeleccionado);

                // 4. ¡Súper importante! Lo borramos del Pizarrón Global para que el Timer no lo regrese
                DatosCocina.PedidosEnEspera.Remove(pedidoSeleccionado);

                // 5. Lo borramos visualmente de la lista de "En espera"
                listBoxEnEspera.Items.Remove(pedidoSeleccionado);
            }
            else
            {
                // Le avisamos amablemente al chef si olvidó seleccionar el pedido
                MessageBox.Show("Por favor, selecciona un pedido de la columna 'En Espera'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            // Verificamos que haya seleccionado algo de la segunda columna
            if (listBoxEnPreparacion.SelectedIndex != -1)
            {
                string pedidoSeleccionado = listBoxEnPreparacion.SelectedItem.ToString();

                // 1. Lo pasamos a la última columna
                listBoxListo.Items.Add(pedidoSeleccionado);

                // 2. Lo borramos de la columna del medio
                listBoxEnPreparacion.Items.Remove(pedidoSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pedido de la columna 'En Preparación'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. Verificamos que el chef haya seleccionado un pedido de la última columna
            if (listBoxListo.SelectedIndex != -1)
            {
                string pedidoTerminado = listBoxListo.SelectedItem.ToString();

                // 2. ¡Lo borramos por completo de la lista visual!
                listBoxListo.Items.Remove(pedidoTerminado);

                // --- NOTA PARA EL FUTURO (BASE DE DATOS) ---
                // Aquí es donde más adelante pondrás un código que diga:
                // UPDATE Pedidos SET Estado = 'Entregado' WHERE Texto = pedidoTerminado;
            }
            else
            {
                // Si le pica por accidente sin seleccionar nada, le avisamos
                MessageBox.Show("Por favor, selecciona un pedido de la columna 'Listo' para entregarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
