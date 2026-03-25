using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Prestamos
{
    public partial class FrmPrestamosVencidos : Form
    {
        // Controlador
        private PrestamoController _prestamoCtrl;

        // Constructor
        public FrmPrestamosVencidos(SistemaLibreria sistema)
        {
            InitializeComponent();
            _prestamoCtrl = new PrestamoController(sistema);
        }

        // Evento de carga del formulario
        private void FrmPrestamosVencidos_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Cargar tabla de préstamos vencidos
        private void CargarTabla()
        {
            dgvVencidos.Rows.Clear();

            try
            {
                List<Prestamo> prestamosVencidos = _prestamoCtrl.ObtenerVencidos();

                foreach (Prestamo prestamo in prestamosVencidos)
                {
                    int diasDeRetraso = prestamo.ObtenerDiasDeRetraso();
                    decimal multa = prestamo.CalcularMulta();

                    int fila = dgvVencidos.Rows.Add(
                        prestamo.Codigo,
                        prestamo.Lector != null ? prestamo.Lector.Nombre : "-",
                        prestamo.Libros != null && prestamo.Libros.Count > 0 ? prestamo.Libros[0].Libro.Titulo : "-",
                        prestamo.FechaLimite.ToString("dd/MM/yyyy"),
                        diasDeRetraso,
                        multa.ToString("C")
                    );

                    // Resaltar fila en rojo
                    dgvVencidos.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                }

                lblContador.Text = "Total vencidos: " + dgvVencidos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
