using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Archivo
{ 
    public partial class FrmHistorialPrestamos : Form
    {
        private PrestamoController _ctrl = new PrestamoController();

        public FrmHistorialPrestamos() { InitializeComponent(); }

        private void FrmHistorialPrestamos_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.AddRange(new object[] { "Todos", "Activo", "Devuelto", "Vencido" });
            cmbEstado.SelectedIndex = 0;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvHistorial.Rows.Clear();
            string filtro = txtBuscar.Text.Trim().ToLower();
            string estado = cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : "Todos";

            foreach (Prestamo p in _ctrl.Historial)
            {
                if (estado != "Todos" && p.Estado.ToString() != estado) continue;
                string lector = p.Lector != null ? p.Lector.Nombre : "";
                string libro  = p.Libro  != null ? p.Libro.GetNombreLibro() : "";
                if (!string.IsNullOrEmpty(filtro) &&
                    !lector.ToLower().Contains(filtro) &&
                    !libro.ToLower().Contains(filtro)) continue;

                string devolucion = p.Estado == EstadoPrestamo.Devuelto
                    ? p.FechaDevolucion.ToString("dd/MM/yyyy") : "-";

                int fila = dgvHistorial.Rows.Add(
                    p.IdPrestamo, lector, libro,
                    p.FechaInicio.ToString("dd/MM/yyyy"),
                    p.FechaLimite.ToString("dd/MM/yyyy"),
                    devolucion,
                    p.Estado.ToString());

                if (p.EstaVencido() && p.Estado != EstadoPrestamo.Devuelto)
                    dgvHistorial.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                else if (p.Estado == EstadoPrestamo.Devuelto)
                    dgvHistorial.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkGreen;
            }
            lblContador.Text = "Total: " + dgvHistorial.Rows.Count + " prestamo(s)";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { CargarTabla(); }
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e) { CargarTabla(); }
        private void btnLimpiar_Click(object sender, EventArgs e) { txtBuscar.Clear(); cmbEstado.SelectedIndex = 0; }
        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
