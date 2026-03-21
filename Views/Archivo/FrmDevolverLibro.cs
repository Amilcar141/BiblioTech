using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models; 
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Archivo//7
{
    public partial class FrmDevolverLibro : Form
    {
        private PrestamoController _ctrl = new PrestamoController();

        public FrmDevolverLibro() { InitializeComponent(); }

        private void FrmDevolverLibro_Load(object sender, EventArgs e) { CargarPrestamos(); }

        private void CargarPrestamos()
        {
            dgvPrestamos.Rows.Clear();
            string filtro = txtBuscar.Text.Trim().ToLower();
            foreach (Prestamo p in _ctrl.Historial)
            {
                if (p.Estado != EstadoPrestamo.Activo) continue;
                string nombreLibro    = p.Libro  != null ? p.Libro.GetNombreLibro() : "";
                string nombreLector   = p.Lector != null ? p.Lector.Nombre          : "";
                if (!string.IsNullOrEmpty(filtro) &&
                    !nombreLibro.ToLower().Contains(filtro) &&
                    !nombreLector.ToLower().Contains(filtro)) continue;

                bool vencido = p.EstaVencido();
                int fila = dgvPrestamos.Rows.Add(
                    p.IdPrestamo,
                    nombreLector,
                    nombreLibro,
                    p.FechaInicio.ToString("dd/MM/yyyy"),
                    p.FechaLimite.ToString("dd/MM/yyyy"),
                    vencido ? "VENCIDO" : "Activo"
                );
                if (vencido) dgvPrestamos.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
            }
            lblContador.Text = "Total activos: " + dgvPrestamos.Rows.Count;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { CargarPrestamos(); }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null) { MessageBox.Show("Seleccione un préstamo.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning); return; }
            int id = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells["colId"].Value);
            Prestamo p = _ctrl.Historial.Find(x => x.IdPrestamo == id);
            if (p == null) return;

            string msg = "¿Confirmar devolución del libro \"" + (p.Libro?.GetNombreLibro() ?? "") + "\"?";
            if (p.EstaVencido())
                msg += "\n\n⚠ Este préstamo está VENCIDO. Se generará una multa.";

            if (MessageBox.Show(msg,"Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes) return;

            p.RegistrarDevolucion(DateTime.Now, new Models.Administrador("Admin"));
            if (p.Libro != null) p.Libro.SetDisponible(true);

            MessageBox.Show("Devolución registrada correctamente.","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            CargarPrestamos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) { txtBuscar.Clear(); CargarPrestamos(); }
        private void btnCerrar_Click(object sender, EventArgs e)  { this.Close(); }
    }
}
