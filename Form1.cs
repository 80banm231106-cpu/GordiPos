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

        private void AgregarProducto(string nombre, double precio)
        {
            ListaVenta.Items.Add(nombre + " - $" + precio);

            total += precio;

            lblTotal.Text = "Total: $" + total;
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

            double cambio = pago - total;
            lblCambio.Text = "Cambio: $" + cambio;

            MessageBox.Show("Pago realizado con éxito");

            ListaVenta.Items.Clear();
            total = 0;
            lblTotal.Text = "Total: $0";
            txtPago.Clear();
            lblCambio.Text = "Cambio: $0";
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
    }
    
}






