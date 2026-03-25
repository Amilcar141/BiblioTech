using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views
{
    public partial class FrmBuscarLibro : Form
    {
        // Controlador
        private LibroController _libroCtrl;

        // Constructor
        public FrmBuscarLibro(SistemaLibreria sistema)
        {
            InitializeComponent();
            _libroCtrl = new LibroController(sistema);

            CargarCombos();
            cmbFiltro.SelectedIndex = 0;
            CargarTabla();
        }

        // Cargar datos en la tabla
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            try
            {
                List<Libro> libros = ObtenerLibrosFiltrados();

                foreach (Libro lib in libros)
                {
                    dgvLibros.Rows.Add(
                        lib.ISBN,
                        lib.Titulo,
                        lib.Autor.NombreCompleto(),
                        lib.Categoria.NombreCategoria,
                        lib.Editorial.Nombre,
                        lib.FechaPublicacion.ToString("dd/MM/yy"),
                        lib.NumeroPaginas.ToString(),
                        lib.Precio.ToString("C")
                    );
                }

                lblContador.Text = "Total: " + dgvLibros.Rows.Count + " libro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obtener libros filtrados según criterio de búsqueda
        private List<Libro> ObtenerLibrosFiltrados()
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();
            string filtro = cmbFiltro.SelectedItem?.ToString() ?? "ISBN";
            List<Libro> todosLibros = _libroCtrl.Inventario();

            if (string.IsNullOrWhiteSpace(busqueda))
                return todosLibros;

            if (filtro == "ISBN")
                return todosLibros.Where(l => l.ISBN.ToLower().Contains(busqueda)).ToList();
            else if (filtro == "Título")
                return todosLibros.Where(l => l.Titulo.ToLower().Contains(busqueda)).ToList();
            else if (filtro == "Autor")
                return todosLibros.Where(l => l.Autor.NombreCompleto().ToLower().Contains(busqueda)).ToList();
            else if (filtro == "Categoría")
                return todosLibros.Where(l => l.Categoria.NombreCategoria.ToLower().Contains(busqueda)).ToList();
            else
                return todosLibros;
        }

        // Carga de los combobox
        private void CargarCombos()
        {
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("ISBN");
            cmbFiltro.Items.Add("Título");
            cmbFiltro.Items.Add("Autor");
            cmbFiltro.Items.Add("Categoría");
        }

        // Evento cambio en campo de búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Evento cambio en filtro
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Botón limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbFiltro.SelectedIndex = 0;
            CargarTabla();
            txtBuscar.Focus();
        }

        // Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
