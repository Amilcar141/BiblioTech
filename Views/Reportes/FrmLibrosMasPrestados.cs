using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Models.Enums;
 
namespace BiblioTech.Views.Reportes
{
    public partial class FrmLibrosMasPrestados : Form
    {
        private PrestamoController _pCtrl = new PrestamoController();

        public FrmLibrosMasPrestados() { InitializeComponent(); }

        private void FrmLibrosMasPrestados_Load(object sender, EventArgs e) { CargarTabla(); }

        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();
            // Contar préstamos por libro
            Dictionary<string, int>    conteo   = new Dictionary<string, int>();
            Dictionary<string, string> autores  = new Dictionary<string, string>();

            foreach (Prestamo p in _pCtrl.Historial)
            {
                if (p.Libro == null) continue;
                string titulo = p.Libro.GetNombreLibro();
                string autor  = p.Libro.GetAutor();
                if (conteo.ContainsKey(titulo)) conteo[titulo]++;
                else { conteo[titulo] = 1; autores[titulo] = autor; }
            }

            // Ordenar descendente
            List<string> titulos = new List<string>(conteo.Keys);
            titulos.Sort((a, b) => conteo[b].CompareTo(conteo[a]));

            int pos = 1;
            foreach (string titulo in titulos)
            {
                int fila = dgvLibros.Rows.Add(pos++, titulo,
                    autores.ContainsKey(titulo) ? autores[titulo] : "",
                    conteo[titulo]);
                if (pos == 2)
                    dgvLibros.Rows[fila].DefaultCellStyle.BackColor = Color.Gold;
                else if (pos == 3)
                    dgvLibros.Rows[fila].DefaultCellStyle.BackColor = Color.Silver;
                else if (pos == 4)
                    dgvLibros.Rows[fila].DefaultCellStyle.BackColor = Color.FromArgb(205, 127, 50);
            }

            if (dgvLibros.Rows.Count == 0)
                dgvLibros.Rows.Add("-", "No hay préstamos registrados", "", 0);

            lblContador.Text = "Libros distintos prestados: " + (titulos.Count > 0 ? titulos.Count : 0);
        }

        private void btnRefrescar_Click(object sender, EventArgs e) { CargarTabla(); }
        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
