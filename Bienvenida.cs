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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Escondemos la pantalla de bienvenida para que no estorbe
            this.Hide();

            // 2. Creamos y abrimos tu pantalla de Login
            // (Asegúrate de que 'Login' sea el nombre correcto de tu formulario de inicio de sesión)
            login ventanaLogin = new login();

            // Usamos ShowDialog para que el programa se "pause" aquí hasta que cierren el login/caja
            ventanaLogin.ShowDialog();

            // 3. Cuando el usuario cierre por completo el sistema, cerramos esta ventana oculta 
            // para que la aplicación se apague correctamente de la memoria.
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Ocultas los demás y muestras solo el de Funciones
            PanelInicio.Visible = false;
            PanelContacto.Visible = false;

            PanelFuncion.Visible = true;
            PanelFuncion.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Ocultas los demás y muestras solo el de Funciones
            PanelFuncion.Visible = false;
            PanelContacto.Visible = false;

            PanelInicio.Visible = true;
            PanelInicio.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Ocultas los demás y muestras solo el de Funciones
            PanelInicio.Visible = false;
            PanelFuncion.Visible = false;

            PanelContacto.Visible = true;
            PanelContacto.BringToFront();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validamos que no dejen campos vacíos (opcional pero pro)
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDuda.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de enviar.", "Clic&Go - Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Simulamos el envío
                MessageBox.Show("¡Mensaje enviado con éxito! Nuestro equipo técnico se pondrá en contacto con usted en breve.", "Clic&Go - Soporte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos los cuadros de texto
                txtNombre.Clear();
                txtCorreo.Clear();
                txtDuda.Clear();
            }
        }

        private void PanelContacto_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void PanelFuncion_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}