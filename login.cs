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
            if (bloqueado)
                return;

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "1" && contraseña == "1")
            {
                intento = 0;

                Form1 caja = new Form1();
                this.Hide();
                caja.Enabled = true;
                caja.ShowDialog();
                txtUsuario.Clear();     // Opcional: Limpiamos la caja de usuario
                txtContraseña.Clear();  // Opcional: Limpiamos la caja de contraseña para que no se quede guardada
                this.Show();
            }
            else
            {
                intento++;
                MessageBox.Show("Usuario o contraseña incorrectos.");

                if (intento >= 3)
                {
                    IniciarBloqueo();
                }
            }
        }

        private void timerBloqueo_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            lblBloqueo.Text = "Sistema bloqueado: " + tiempoRestante + " segundos";

            if (tiempoRestante <= 0)
            {
                timerBloqueo.Stop();

                bloqueado = false;
                intento = 0;
                tiempoRestante = 10;

                btnLogin.Enabled = true;
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = true;

                lblBloqueo.Text = "Puedes intentar nuevamente.";
            }
        }

        private void lblBloqueo_Click(object sender, EventArgs e)
        {

        }

        private void IniciarBloqueo()
        {
            bloqueado = true;

            btnLogin.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;

            lblBloqueo.Text = "Sistema bloqueado: 10 segundos";

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
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, cabeza.Width - 3, cabeza.Height - 3);
            Region rg = new Region(gp);
            cabeza.Region = rg;

           

            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            gp2.AddEllipse(0, 0, cuerpo.Width - 3, cuerpo.Height - 3);
            Region rg2 = new Region(gp2);
            cuerpo.Region = rg2;
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
    }
}
