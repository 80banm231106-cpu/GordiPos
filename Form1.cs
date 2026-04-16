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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace interfaz_de_caja_registradora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contadorHamburguesa = 0;
        int contadorBebidas = 0;
        int contadorPapas = 0;
        bool SugerenciaMostrada = false;

        // Variables para recordar los datos y mandarlos al ticket
        int ticketId = 0;
        double ticketPago = 0;
        double ticketCambio = 0;

        private void AgregarProducto(string nombre, double precio)
        {
            ListaVenta.Items.Add(nombre + " - $" + precio);

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void FormatoTicket(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 1. Configuramos las fuentes (Tipografías)
            Font fuenteTitulo = new Font("Courier New", 14, FontStyle.Bold);
            Font fuenteNormal = new Font("Courier New", 10, FontStyle.Regular);
            Font fuentePequeña = new Font("Courier New", 8, FontStyle.Regular);

            // Margen izquierdo y posición inicial desde arriba (Eje Y)
            int margenIzq = 10;
            int y = 20;

            // --- ENCABEZADO ---
            e.Graphics.DrawString("🍔 GORDIFELIZ 🍔", fuenteTitulo, Brushes.Black, margenIzq + 30, y);
            y += 25;
            e.Graphics.DrawString("Ticket Folio: #" + ticketId, fuenteNormal, Brushes.Black, margenIzq, y);
            y += 20;
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuentePequeña, Brushes.Black, margenIzq, y);
            y += 25;
            e.Graphics.DrawString("--------------------------------", fuenteNormal, Brushes.Black, margenIzq, y);
            y += 20;

            // --- DETALLE DE PRODUCTOS ---
            e.Graphics.DrawString("CANT  DESCRIPCIÓN       PRECIO", fuenteNormal, Brushes.Black, margenIzq, y);
            y += 20;
            e.Graphics.DrawString("--------------------------------", fuenteNormal, Brushes.Black, margenIzq, y);
            y += 20;

            foreach (var item in ListaVenta.Items)
            {
                // Separamos el nombre del precio (Ej: "Hamburguesa - $80")
                string[] partes = item.ToString().Split('-');
                string nombre = partes[0].Trim();
                string precio = partes[1].Trim();

                // Si el nombre es muy largo, lo cortamos para que no desacomode el ticket
                if (nombre.Length > 15) nombre = nombre.Substring(0, 15);

                // Acomodamos en columnas: 1 | Producto | Precio
                string lineaProducto = $"1    {nombre,-15} {precio}";
                e.Graphics.DrawString(lineaProducto, fuenteNormal, Brushes.Black, margenIzq, y);
                y += 20; // Bajamos 20 pixeles para el siguiente producto
            }

            // --- TOTALES ---
            y += 10;
            e.Graphics.DrawString("--------------------------------", fuenteNormal, Brushes.Black, margenIzq, y);
            y += 20;
            e.Graphics.DrawString("TOTAL:          $" + total.ToString("0.00"), fuenteTitulo, Brushes.Black, margenIzq, y);
            y += 25;
            e.Graphics.DrawString("PAGÓ CON:       $" + ticketPago.ToString("0.00"), fuenteNormal, Brushes.Black, margenIzq, y);
            y += 20;
            e.Graphics.DrawString("SU CAMBIO:      $" + ticketCambio.ToString("0.00"), fuenteNormal, Brushes.Black, margenIzq, y);

            // --- PIE DE PÁGINA ---
            y += 40;
            e.Graphics.DrawString("¡Gracias por su preferencia!", fuenteNormal, Brushes.Black, margenIzq + 10, y);
        }
        private void VerificarSugerencias()
        {
            if (!SugerenciaMostrada &&
                    contadorHamburguesa > 0 &&
                    contadorBebidas > 0 &&
                    contadorPapas == 0)
            {
                SugerenciaMostrada = true;

                DialogResult resultado = MessageBox.Show(
                    "¿Desea agregar papas por $20 adicionales?",
                    "Sugerencia",
                    MessageBoxButtons.YesNo
                );

                if (resultado == DialogResult.Yes)
                {
                    AgregarProducto("Papas (Promoción)", 20);
                    contadorPapas++;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            double precio = 35;

            ListaVenta.Items.Add("Banderilla - $35");

            total += precio;

            lblTotal.Text = "total: $" + total;
        }
        double total = 0;
        private void btnNuggets_Click(object sender, EventArgs e)
        {
            double precio = 40;

            ListaVenta.Items.Add("Nuggets - $40");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            double precio = 30;

            ListaVenta.Items.Add("Coca Cola - $30");

            total += precio;

            lblTotal.Text = "total: $" + total;
        }

        private void btnDori_Click(object sender, EventArgs e)
        {
            double precio = 75;

            ListaVenta.Items.Add("Dorinachos - $75");

            total += precio;

            lblTotal.Text = "total: $" + total;
        }

        private void btnPapas_Click(object sender, EventArgs e)
        {
            double precio = 40;

            ListaVenta.Items.Add("Papas - $40");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void btnHamb_Click(object sender, EventArgs e)
        {
            double precio = 80;

            ListaVenta.Items.Add("Hamburguesa - $80");

            total += precio;

            lblTotal.Text = "total: $" + total;
        }

        private void btnAros_Click(object sender, EventArgs e)
        {
            double precio = 45;

            ListaVenta.Items.Add("Aros de Cebolla - $45");

            total += precio;

            lblTotal.Text = "total: $" + total;
        }

        private void ListaVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pago;
            if (!double.TryParse(txtPago.Text.Trim(), out pago) || pago < total)
            {
                MessageBox.Show("Pago insuficiente o inválido.");
                return;
            }

            // 1. Calculamos el cambio ANTES de guardar en la base de datos
            double cambio = pago - total;
            lblCambio.Text = "Cambio: $" + cambio.ToString("0.00");
            lblCambio.Refresh(); // Forzamos a que se muestre en pantalla rápido

            ConexionBD bd = new ConexionBD();
            bd.abrir();

            MySqlTransaction transaccion = bd.conectar.BeginTransaction();

            try
            {
                // 2. REGISTRAR LA VENTA GENERAL
                string sqlVenta = "INSERT INTO ventas (total) VALUES (@total); SELECT LAST_INSERT_ID();";
                MySqlCommand cmdVenta = new MySqlCommand(sqlVenta, bd.conectar, transaccion);
                cmdVenta.Parameters.AddWithValue("@total", total);
                int idVentaGenerada = Convert.ToInt32(cmdVenta.ExecuteScalar());

                // 3. REGISTRAR CADA PRODUCTO
                foreach (var item in ListaVenta.Items)
                {
                    string nombreProducto = item.ToString().Split('-')[0].Trim();

                    string sqlBuscaId = "SELECT id_producto FROM producto WHERE nombre = @nom LIMIT 1";
                    MySqlCommand cmdBusca = new MySqlCommand(sqlBuscaId, bd.conectar, transaccion);
                    cmdBusca.Parameters.AddWithValue("@nom", nombreProducto);
                    int idProducto = Convert.ToInt32(cmdBusca.ExecuteScalar());

                    string sqlDetalle = "INSERT INTO detalle_venta (id_venta, id_producto, cantidad) VALUES (@idV, @idP, 1)";
                    MySqlCommand cmdDetalle = new MySqlCommand(sqlDetalle, bd.conectar, transaccion);
                    cmdDetalle.Parameters.AddWithValue("@idV", idVentaGenerada);
                    cmdDetalle.Parameters.AddWithValue("@idP", idProducto);

                    cmdDetalle.ExecuteNonQuery();
                }

                // 4. MANDAR A COCINA
                if (ListaVenta.Items.Count > 0)
                {
                    string textoPedido = "Pedido #" + DatosCocina.NumeroPedidoActual + ": ";
                    foreach (var item in ListaVenta.Items)
                    {
                        string soloComida = item.ToString().Split('-')[0].Trim();
                        textoPedido += soloComida + " | ";
                    }
                    DatosCocina.PedidosEnEspera.Add(textoPedido);
                    DatosCocina.NumeroPedidoActual++;
                }

                // 5. CONFIRMAR TRANSACCIÓN
                transaccion.Commit();

                // 6. Mostrar éxito con el cambio incluido
                MessageBox.Show($"Venta realizada con éxito.\n\nCambio a devolver: ${cambio.ToString("0.00")}", "Venta Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ---> NUEVO: GENERAR EL TICKET <---
                // Guardamos los datos temporalmente
                ticketId = idVentaGenerada;
                ticketPago = pago;
                ticketCambio = cambio;

                // Preparamos el documento
                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(FormatoTicket);

                // Mostramos la vista previa en pantalla
                PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
                vistaPrevia.Document = doc;
                vistaPrevia.ShowDialog();
                // ----------------------------------

                // 7. Limpiar pantalla directamente (sin métodos extra)
                ListaVenta.Items.Clear();
                // ... (resto de tu código de limpieza)

                // 7. Limpiar pantalla directamente (sin métodos extra)
                ListaVenta.Items.Clear();
                total = 0;
                lblTotal.Text = "Total: $0";
                txtPago.Clear();
                lblCambio.Text = "Cambio: $0";
            }
            catch (MySqlException ex)
            {
                transaccion.Rollback();
                MessageBox.Show("Error al cobrar: " + ex.Message, "Falta Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bd.cerrar();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaVenta.SelectedIndex != -1)
            {
                string itemSeleccionado = ListaVenta.SelectedItem.ToString();

                // Extraer el precio del texto
                int posicion = itemSeleccionado.LastIndexOf("$");
                string precioTexto = itemSeleccionado.Substring(posicion + 1);

                double precio = Convert.ToDouble(precioTexto);

                // Restar del total
                total -= precio;

                // Actualizar label
                lblTotal.Text = "Total: $" + total;

                // Eliminar del ListBox
                ListaVenta.Items.RemoveAt(ListaVenta.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }

        private void IstVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostrar solo el menú principal al inicio
            panelComida.Visible = true;
            panelBebidas.Visible = false;
            panelPostres.Visible = false;
            panelPromociones.Visible = false;

            panelComida.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            panelComida.Visible = true;
            panelBebidas.Visible = false;
            panelPostres.Visible = false;
            panelPromociones.Visible = false;

            panelComida.BringToFront();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            panelComida.Visible = false;
            panelBebidas.Visible = false;
            panelPostres.Visible = true;
            panelPromociones.Visible = false;

            panelPostres.BringToFront();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            panelComida.Visible = false;
            panelBebidas.Visible = false;
            panelPostres.Visible = false;
            panelPromociones.Visible = true;

            panelPromociones.BringToFront();
        }

        private void btnBenidas_Click(object sender, EventArgs e)
        {
            panelComida.Visible = false;
            panelBebidas.Visible = true;
            panelPostres.Visible = false;
            panelPromociones.Visible = false;

            panelBebidas.BringToFront();
        }

        private void btnRegreso_Click(object sender, EventArgs e)
       
        {
            
            // Esto hace que el menú aparezca justo debajo de tu botón
            // Cambia "menuOpciones" por el nombre que le hayas puesto a tu ContextMenuStrip
            menuOpciones.Show(btnRegreso, new Point(0, btnRegreso.Height));
        }

        private void panelBebidas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double precio = 119;

            ListaVenta.Items.Add("Combo pa compartir - $119");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double precio = 25;

            ListaVenta.Items.Add("Sprite - $25");

            total += precio;

            lblTotal.Text = "Total: $" + total; 
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            double precio = 20;

            ListaVenta.Items.Add("Jumex - $20");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double precio = 15;

            ListaVenta.Items.Add("Agua - $15");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double precio = 45;

            ListaVenta.Items.Add("Brownie - $45");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double precio = 55;

            ListaVenta.Items.Add("Flan - $55");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double precio = 70;

            ListaVenta.Items.Add("Fresas con crema - $70");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void lblTotal_Click_1(object sender, EventArgs e)
        {
           
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void irAInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Creamos una instancia de tu nuevo formulario
            Inventario pantallaInventario = new Inventario();

            // 2u. Lo mostramos usando ShowDialog()
            pantallaInventario.ShowDialog();
        }

        private void corteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Creamos una instancia de tu nuevo formulario
            CorteDeCaja pantallaCorte = new CorteDeCaja();

            // 2u. Lo mostramos usando ShowDialog()
            pantallaCorte.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
        }

        private void lblCambio_Click(object sender, EventArgs e)
        {
            double pago;

            if (!double.TryParse(txtPago.Text.Trim(), out pago))
            {
                MessageBox.Show("Ingresa una cantidad");
                return;
            }

            if (pago < total)
            {
                MessageBox.Show("El pago es insuficiente");
                return;
            }

            // 1. Calculas el cambio
            double cambio = pago - total;

            // 2. Actualizas el texto de la etiqueta (formateado a 2 decimales para dinero)
            lblCambio.Text = "Cambio: $" + cambio.ToString("0.00");

            // 3. ¡LA CLAVE!: Fuerzas a la interfaz a dibujarlo antes de que se pause
            lblCambio.Refresh();

            // 4. (Opcional pero recomendado) Muestras el cambio también en el mensaje
            MessageBox.Show($"Pago realizado con éxito.\n\nCambio a devolver: ${cambio.ToString("0.00")}", "Venta Completada");

            // --- Limpieza del formulario ---
            ListaVenta.Items.Clear();
            total = 0;
            lblTotal.Text = "Total: $0";
            txtPago.Clear();
            lblCambio.Text = "Cambio: $0";
        }

        private void lblCambio_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double precio = 120;

            ListaVenta.Items.Add("Combo Feliz - $120");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double precio = 109;

            ListaVenta.Items.Add("Combo Antojo - $109");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double precio = 90;

            ListaVenta.Items.Add("Combo Dulce 2x - $90");

            total += precio;

            lblTotal.Text = "Total: $" + total;
        }
    }

}






