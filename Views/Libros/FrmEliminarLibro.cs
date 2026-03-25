using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views
{
    public partial class FrmEliminarLibro : Form
    {
        // Controlador
        private LibroController _libroCtrl;

        // Constructor
        public FrmEliminarLibro(SistemaLibreria sistema)
        {
            InitializeComponent();
            _libroCtrl = new LibroController(sistema);

            // Conectar evento de doble clic
            dgvLibros.CellDoubleClick += dgvLibros_CellDoubleClick;

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

        // Obtener libros filtrados según búsqueda
        private List<Libro> ObtenerLibrosFiltrados()
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();
            List<Libro> todosLibros = _libroCtrl.Inventario();

            if (string.IsNullOrWhiteSpace(busqueda))
                return todosLibros;

            return todosLibros.Where(l =>
                l.ISBN.ToLower().Contains(busqueda) ||
                l.Titulo.ToLower().Contains(busqueda) ||
                l.Autor.NombreCompleto().ToLower().Contains(busqueda) ||
                l.Categoria.NombreCategoria.ToLower().Contains(busqueda)
            ).ToList();
        }

        // Evento cambio en campo de búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Evento selección en tabla
        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            // El libro seleccionado se obtiene del DataGridView cuando se necesite
        }

        // Doble clic en la tabla para eliminar
        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EliminarLibroSeleccionado();
            }
        }

        // Botón eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un libro de la tabla para eliminar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EliminarLibroSeleccionado();
        }

        // Método para eliminar el libro seleccionado
        private void EliminarLibroSeleccionado()
        {
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un libro de la tabla para eliminar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string isbn = dgvLibros.CurrentRow.Cells[0].Value?.ToString();
            Libro libroSeleccionado = _libroCtrl.Inventario().FirstOrDefault(l => l.ISBN == isbn);

            if (libroSeleccionado == null)
            {
                MessageBox.Show("No se pudo identificar el libro seleccionado.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de que desea eliminar '{libroSeleccionado.Titulo}'? Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                _libroCtrl.EliminarLibro(libroSeleccionado.ISBN);

                MessageBox.Show("Libro eliminado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el libro: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
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
