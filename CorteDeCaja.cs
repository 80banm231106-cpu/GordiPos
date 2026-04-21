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
    public partial class CorteDeCaja : Form
    {
        // 1. Variables a nivel de clase
        decimal fondoInicial = 0m;
        decimal ventasDelDia = 0m;
        decimal totalEsperado = 0m;

        public CorteDeCaja()
        {
            InitializeComponent();
        }

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
                string sqlFondo = "SELECT monto_inicial FROM Apertura_caja WHERE DATE(fecha) = CURDATE() ORDER BY id_apertura DESC LIMIT 1";
                MySqlCommand cmdFondo = new MySqlCommand(sqlFondo, bd.conectar);
                object resFondo = cmdFondo.ExecuteScalar();

                fondoInicial = (resFondo != DBNull.Value && resFondo != null) ? Convert.ToDecimal(resFondo) : 0m;

                string sql = "SELECT SUM(total) FROM ventas WHERE DATE(fecha) = CURDATE()";
                MySqlCommand comando = new MySqlCommand(sql, bd.conectar);
                object resultado = comando.ExecuteScalar();

                ventasDelDia = (resultado != DBNull.Value) ? Convert.ToDecimal(resultado) : 0m;

                lblCajero.Text = "Cajero: admin";
                txtFondoinicial.Text = fondoInicial.ToString("C");
                txtVentastotales.Text = ventasDelDia.ToString("C");

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
            // 1. Validamos
            if (!decimal.TryParse(txtEfectivoContado.Text, out decimal efectivoReal))
            {
                MessageBox.Show("Por favor, ingrese el total de dinero contado en caja.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEfectivoContado.Focus();
                return;
            }

            // 2. Calculamos diferencia
            decimal diferencia = efectivoReal - totalEsperado;

            // 3. Guardar PDF
            SaveFileDialog dialogoGuardar = new SaveFileDialog();
            dialogoGuardar.Filter = "Archivo PDF|*.pdf";
            dialogoGuardar.Title = "Guardar Reporte de Corte de Caja";
            dialogoGuardar.FileName = "Corte_Caja_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf";

            if (dialogoGuardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GenerarPDFCorte(dialogoGuardar.FileName, fondoInicial, ventasDelDia, totalEsperado, efectivoReal, diferencia);

                    MessageBox.Show("¡Corte de caja finalizado y guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al crear el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerarPDFCorte(string rutaArchivo, decimal pFondo, decimal pVentas, decimal pEsperado, decimal pReal, decimal pDiferencia)
        {
            // 1. Creamos el documento tamaño Carta
            iTextSharp.text.Document documento = new iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER);

            // 2. Lo conectamos al archivo físico que elegiste
            iTextSharp.text.pdf.PdfWriter.GetInstance(documento, new System.IO.FileStream(rutaArchivo, System.IO.FileMode.Create));

            // 3. Abrimos el PDF para empezar a escribir
            documento.Open();

            // 4. Creamos fuentes tipográficas clásicas que NUNCA fallan
            iTextSharp.text.Font fontTitulo = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18);
            iTextSharp.text.Font fontNormal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 12);

            // 5. Título centrado
            iTextSharp.text.Paragraph titulo = new iTextSharp.text.Paragraph("GORDI FELIZ - CORTE DE CAJA\n", fontTitulo);
            titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            documento.Add(titulo);

            iTextSharp.text.Paragraph fecha = new iTextSharp.text.Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n", fontNormal);
            fecha.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            documento.Add(fecha);

            documento.Add(new iTextSharp.text.Paragraph("------------------------------------------------------------------\n", fontNormal));

            // 6. Cantidades
            documento.Add(new iTextSharp.text.Paragraph("Fondo Inicial:        " + pFondo.ToString("C2"), fontNormal));
            documento.Add(new iTextSharp.text.Paragraph("Ventas del Día:       " + pVentas.ToString("C2"), fontNormal));
            documento.Add(new iTextSharp.text.Paragraph("Total Esperado:       " + pEsperado.ToString("C2"), fontNormal));
            documento.Add(new iTextSharp.text.Paragraph("Efectivo Contado:     " + pReal.ToString("C2"), fontNormal));

            documento.Add(new iTextSharp.text.Paragraph("------------------------------------------------------------------\n", fontNormal));

            // 7. Resultado Final centrado y en negritas
            string textoDiferencia = pDiferencia == 0 ? "CAJA CUADRADA EXACTAMENTE ($0.00)" :
                                     pDiferencia > 0 ? "SOBRANTE EN CAJA: " + Math.Abs(pDiferencia).ToString("C2") :
                                     "FALTANTE EN CAJA: -" + Math.Abs(pDiferencia).ToString("C2");

            iTextSharp.text.Paragraph resultado = new iTextSharp.text.Paragraph("RESULTADO FINAL:\n" + textoDiferencia, fontTitulo);
            resultado.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            documento.Add(resultado);

            // 8. ¡La línea mágica que asegura que el archivo se guarde sano y salvo!
            documento.Close();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void btnRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}