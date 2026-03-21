using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Archivo
{ 
    public partial class FrmRenovarPrestamo : Form
    {
        private PrestamoController _ctrl = new PrestamoController();

        public FrmRenovarPrestamo() { InitializeComponent(); }

        private void FrmRenovarPrestamo_Load(object sender, EventArgs e)
        {
            dtpNuevaFecha.MinDate = DateTime.Today.AddDays(1);
            dtpNuevaFecha.Value   = DateTime.Today.AddDays(14);
            CargarPrestamos();
        }

        private void CargarPrestamos()
        {
            dgvPrestamos.Rows.Clear();
            string filtro = txtBuscar.Text.Trim().ToLower();
            foreach (Prestamo p in _ctrl.Historial)
            {
                if (p.Estado != EstadoPrestamo.Activo) continue;
                string libro  = p.Libro  != null ? p.Libro.GetNombreLibro() : "";
                string lector = p.Lector != null ? p.Lector.Nombre          : "";
                if (!string.IsNullOrEmpty(filtro) &&
                    !libro.ToLower().Contains(filtro) &&
                    !lector.ToLower().Contains(filtro)) continue;

                bool vencido = p.EstaVencido();
                int fila = dgvPrestamos.Rows.Add(
                    p.IdPrestamo, lector, libro,
                    p.FechaLimite.ToString("dd/MM/yyyy"),
                    vencido ? "VENCIDO" : "Activo");
                if (vencido)
                    dgvPrestamos.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
            }
            lblContador.Text = "Activos: " + dgvPrestamos.Rows.Count;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { CargarPrestamos(); }

        private void dgvPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells["colRId"].Value);
            Prestamo p = _ctrl.Historial.Find(x => x.IdPrestamo == id);
            if (p != null)
                dtpNuevaFecha.MinDate = p.FechaLimite > DateTime.Today
                    ? p.FechaLimite.AddDays(1) : DateTime.Today.AddDays(1);
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
            { MessageBox.Show("Seleccione un préstamo de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int id = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells["colRId"].Value);
            Prestamo p = _ctrl.Historial.Find(x => x.IdPrestamo == id);
            if (p == null) return;

            string libro = p.Libro?.GetNombreLibro() ?? "";
            if (MessageBox.Show("¿Renovar préstamo de \"" + libro + "\"?\nNueva fecha límite: " +
                dtpNuevaFecha.Value.ToString("dd/MM/yyyy"),
                "Confirmar Renovación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            p.FechaLimite = dtpNuevaFecha.Value;
            p.Estado      = EstadoPrestamo.Activo;

            MessageBox.Show("Préstamo renovado correctamente.\nNueva fecha límite: " +
                dtpNuevaFecha.Value.ToString("dd/MM/yyyy"),
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarPrestamos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) { txtBuscar.Clear(); }
        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
