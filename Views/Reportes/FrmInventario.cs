using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models; 

namespace BiblioTech.Views.Reportes
{//7
    public partial class FrmInventario : Form
    {
        private LibroController _ctrl = new LibroController();

        public FrmInventario() { InitializeComponent(); }

        private void FrmInventario_Load(object sender, EventArgs e) { CargarTabla(); }

        private void CargarTabla()
        {
            dgvInventario.Rows.Clear();
            string filtro = txtBuscar.Text.Trim().ToLower();
            int disp = 0, pres = 0;

            foreach (Libro lib in _ctrl.ObtenerTodos())
            {
                if (!string.IsNullOrEmpty(filtro) &&
                    !lib.GetNombreLibro().ToLower().Contains(filtro) &&
                    !lib.GetAutor().ToLower().Contains(filtro) &&
                    !lib.GetISBN().ToLower().Contains(filtro)) continue;

                string estado = lib.GetDisponible() ? "Disponible" : "Prestado";
                int fila = dgvInventario.Rows.Add(
                    lib.GetISBN(), lib.GetNombreLibro(), lib.GetAutor(),
                    lib.GetNombreCategoria(), lib.GetEditorial(),
                    lib.GetFechaPublicacion(), lib.GetNumeroPaginas(), estado);

                if (!lib.GetDisponible())
                {
                    dgvInventario.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                    pres++;
                }
                else disp++;
            }
            lblContador.Text = string.Format("Total: {0}  |  Disponibles: {1}  |  Prestados: {2}",
                dgvInventario.Rows.Count, disp, pres);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { CargarTabla(); }
        private void btnLimpiar_Click(object sender, EventArgs e) { txtBuscar.Clear(); }
        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
