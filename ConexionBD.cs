using MySql.Data.MySqlClient; // Esta es la librería que instalaste
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace interfaz_de_caja_registradora
{
    public class ConexionBD
    {
        // Cambia los datos por los que configuraste en Workbench
        private string cadena = "Server=localhost; Database=AlmacenProductos; Uid=root; Pwd=Cisco123.;";
        public MySqlConnection conectar = new MySqlConnection();

        public void abrir()
        {
            try
            {
                conectar.ConnectionString = cadena;
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        public void cerrar()
        {
            conectar.Close();
        }
    }
}
