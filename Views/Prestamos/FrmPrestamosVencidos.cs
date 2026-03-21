using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Models.Enums;
 
namespace BiblioTech.Views.Prestamos
{
    public partial class FrmPrestamosVencidos : Form
    {
        private PrestamoController _ctrl = new PrestamoController();

        public FrmPrestamosVencidos() { InitializeComponent(); }

        private void FrmPrestamosVencidos_Load(object sender, EventArgs e) { CargarTabla(); }

        private void CargarTabla()
        {
            dgvVencidos.Rows.Clear();
            foreach (Prestamo p in _ctrl.Historial)
            {
                if (!p.EstaVencido() || p.Estado == EstadoPrestamo.Devuelto) continue;
                int dias      = p.ObtenerDiasDeRetraso();
                decimal multa = p.CalcularMulta();
                int fila = dgvVencidos.Rows.Add(
                    p.IdPrestamo,
                    p.Lector != null ? p.Lector.Nombre : "",
                    p.Libro  != null ? p.Libro.GetNombreLibro() : "",
                    p.FechaLimite.ToString("dd/MM/yyyy"),
                    dias,
                    multa.ToString("F2") + " Lps");
                dgvVencidos.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
            }
            lblContador.Text = "Total vencidos: " + dgvVencidos.Rows.Count;
        }

        private void btnRefrescar_Click(object sender, EventArgs e) { CargarTabla(); }
        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
