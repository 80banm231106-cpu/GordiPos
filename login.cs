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

namespace interfaz_de_caja_registradora
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        int intento = 0;
        bool bloqueado = false;
        int tiempoRestante = 10;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // --- INICIA LA CONEXIÓN A LA BASE DE DATOS ---
            ConexionBD bd = new ConexionBD();
            bd.abrir();

            // 1. Le decimos a C# que llame a tu Procedimiento Almacenado por su nombre
            MySqlCommand comando = new MySqlCommand("login_usuario", bd.conectar);

            // 2. ¡Súper importante! Le avisamos que NO es un texto normal, sino un Procedure
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            // 3. Le pasamos los parámetros usando los nombres EXACTOS que pusiste en MySQL (p_usuario y p_contraseña)
            comando.Parameters.AddWithValue("p_usuario", txtUsuario.Text.Trim());
            comando.Parameters.AddWithValue("p_contraseña", txtContraseña.Text.Trim());

            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                intento = 0;
                this.Hide();

                // 1. Abrimos la ventanita de Apertura
                AperturaCaja apertura = new AperturaCaja();
                apertura.ShowDialog(); // El código se pausa aquí hasta que el cajero la cierre

                // 2. Revisamos si la bandera se encendió
                if (apertura.aperturaExitosa == true)
                {
                    // ¡Todo salió perfecto! Abrimos el punto de venta
                    Form1 menuPrincipal = new Form1();
                    menuPrincipal.ShowDialog();
                }

                // 3. Cuando terminen de usar el punto de venta, regresamos todo a la normalidad
                txtUsuario.Clear();
                txtContraseña.Clear();
                this.Show();
            }
            else
            {
                // ¡Fallo! El usuario no existe o la contraseña está mal
                intento++;
                MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intento + " de 3.");

                if (intento >= 3)
                {
                    IniciarBloqueo();
                }
            }

            // Siempre cerramos la conexión al terminar
            bd.cerrar();
            // --- TERMINA LA CONEXIÓN A LA BASE DE DATOS ---
        }

        private void timerBloqueo_Tick(object sender, EventArgs e)
        {
           
        }

        private void lblBloqueo_Click(object sender, EventArgs e)
        {

        }

        // 4. MÉTODO DE PERDÓN
        private void DesbloquearSistema(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            timer.Stop();

            bloqueado = false;
            intento = 0;

            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            btnLogin.Enabled = true;

            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();

            MessageBox.Show("Sistema desbloqueado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IniciarBloqueo()
        {
            bloqueado = true;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            // Asegúrate de que este sea el nombre real de tu botón de entrar:
            btnLogin.Enabled = false;

            MessageBox.Show("Sistema bloqueado por 30 segundos por seguridad.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Timer timerBloqueo = new Timer();
            timerBloqueo.Interval = 30000; // 30 segundos
            timerBloqueo.Tick += DesbloquearSistema;
            timerBloqueo.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblOlvidaste_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Para recuperar tu contraseña, contacta al administrador del sistema.",
        "Recuperación de contraseña",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuerpo_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            gp2.AddEllipse(0, 0, cuerpo.Width - 3, cuerpo.Height - 3);
            Region rg2 = new Region(gp2);
            cuerpo.Region = rg2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Armamos el texto combinando ambos. 
            // El símbolo \n\n sirve para dar un doble salto de línea (como presionar Enter dos veces).
            string textoCompleto = "NUESTRA MISIÓN:\n" +
                           "Crear un sistema de ventas intuitivo que automatice el registro de productos " +
                           "y el control de inventario, optimizando la organización del negocio a través " +
                           "de una aplicación tan fácil de usar que no requiera de capacitaciones extensas.\n\n" +
                           "NUESTRA VISIÓN:\n" +
                           "Ser el sistema de gestión de ventas e inventario más útil, confiable y " +
                           "accesible para los pequeños negocios de comida rápida.";

            // Mostramos la ventanita
            MessageBox.Show(textoCompleto, "Filosofía de Nuestro Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Mandamos llamar a la ventanita que acabas de crear con la foto
            Creadores ventanaFoto = new Creadores();

            // 2. La mostramos en la pantalla como un cuadro emergente
            ventanaFoto.ShowDialog();
        }
    }
}
