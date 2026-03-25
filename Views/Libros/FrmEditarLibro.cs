using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views
{
    public partial class FrmEditarLibro : Form
    {
        // Controladores
        private LibroController _libroCtrl;
        private CategoriaController _catCtrl;
        private AutorController _autorCtrl;
        private EditorialController _editorialCtrl;

        // Variables para guardar datos seleccionados
        private Libro _libroSeleccionado;
        private Autor autor;
        private Categoria categoria;
        private Editorial editorial;

        // Constructor
        public FrmEditarLibro(SistemaLibreria sistema)
        {
            InitializeComponent();
            _libroCtrl = new LibroController(sistema);
            _catCtrl = new CategoriaController(sistema);
            _autorCtrl = new AutorController(sistema);
            _editorialCtrl = new EditorialController(sistema);

            // Configurar rango de fechas permitidas para el DateTimePicker
            dtpFechaPublicacion.MinDate = new DateTime(1753, 1, 1);
            dtpFechaPublicacion.MaxDate = DateTime.Today;

            // Conectar eventos del DataGridView
            dgvLibros.CellDoubleClick += dgvLibros_CellDoubleClick;
            dgvLibros.SelectionChanged += dgvLibros_SelectionChanged;

            _libroSeleccionado = null;
            CargarTabla();
            HabilitarEdicion(false);
        }

        // Carga la tabla con el contenido
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            foreach (Libro lib in _libroCtrl.Inventario())
            {
                dgvLibros.Rows.Add(
                    lib.ISBN,
                    lib.Titulo,
                    lib.Autor.NombreCompleto(),
                    lib.Categoria.NombreCategoria,
                    lib.Editorial.Nombre,
                    lib.FechaPublicacion.ToString("dd/MM/yy"),
                    lib.NumeroPaginas.ToString(),
                    lib.Precio
                );
            }
        }

        // Habilitar o deshabilitar edición
        private void HabilitarEdicion(bool activo)
        {
            txtISBN.Enabled = activo;
            txtNombreLibro.Enabled = activo;
            txtAutor.Enabled = activo;
            txtCategoria.Enabled = activo;
            txtNumeroPaginas.Enabled = activo;
            txtEditorial.Enabled = activo;
            dtpFechaPublicacion.Enabled = activo;
            txtPrecio.Enabled = activo;
            btnGuardarCambios.Enabled = activo;
        }

        // Limpiar campos
        private void LimpiarCampos()
        {
            txtISBN.Clear();
            txtNombreLibro.Clear();
            txtAutor.Clear();
            txtCategoria.Clear();
            txtNumeroPaginas.Clear();
            txtEditorial.Clear();
            txtPrecio.Clear();
            dtpFechaPublicacion.Value = DateTime.Today;
            _libroSeleccionado = null;
            HabilitarEdicion(false);
        }

        // Valida si todos los campos están completos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtNombreLibro.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroPaginas.Text) ||
                string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtNumeroPaginas.Text, out int paginas) || paginas <= 0)
            {
                MessageBox.Show("Número de páginas debe ser un entero positivo.", "Campo Inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Precio debe ser un número decimal no negativo.", "Campo Inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Selección de libro en la tabla
        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                CargarLibroSeleccionado();
            }
        }

        // Doble clic en la tabla
        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CargarLibroSeleccionado();
            }
        }

        // Cargar datos del libro seleccionado
        private void CargarLibroSeleccionado()
        {
            if (dgvLibros.CurrentRow == null)
                return;

            string isbn = dgvLibros.CurrentRow.Cells[0].Value?.ToString();
            _libroSeleccionado = _libroCtrl.Inventario().FirstOrDefault(l => l.ISBN == isbn);

            if (_libroSeleccionado != null)
            {
                txtISBN.Text = _libroSeleccionado.ISBN;
                txtNombreLibro.Text = _libroSeleccionado.Titulo;
                txtAutor.Text = _libroSeleccionado.Autor.NombreCompleto();
                txtCategoria.Text = _libroSeleccionado.Categoria.NombreCategoria;
                txtEditorial.Text = _libroSeleccionado.Editorial.Nombre;
                txtNumeroPaginas.Text = _libroSeleccionado.NumeroPaginas.ToString();
                txtPrecio.Text = _libroSeleccionado.Precio.ToString();
                dtpFechaPublicacion.Value = _libroSeleccionado.FechaPublicacion;

                autor = _libroSeleccionado.Autor;
                categoria = _libroSeleccionado.Categoria;
                editorial = _libroSeleccionado.Editorial;

                HabilitarEdicion(true);
            }
        }

        // Guardar cambios
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (_libroSeleccionado == null)
            {
                MessageBox.Show("Seleccione un libro de la tabla para editar.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
                return;

            try
            {
                string titulo = txtNombreLibro.Text.Trim();
                decimal precio = decimal.Parse(txtPrecio.Text.Trim());
                int numPaginas = int.Parse(txtNumeroPaginas.Text.Trim());
                DateTime fecha = dtpFechaPublicacion.Value;

                // Actualizar el libro
                _libroSeleccionado.Titulo = titulo;
                _libroSeleccionado.Autor = autor;
                _libroSeleccionado.Categoria = categoria;
                _libroSeleccionado.Editorial = editorial;
                _libroSeleccionado.Precio = precio;
                _libroSeleccionado.NumeroPaginas = numPaginas;
                _libroSeleccionado.FechaPublicacion = fecha;

                MessageBox.Show("Libro actualizado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarTabla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Búsqueda de autores
        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtAutor.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                lstAutores.Visible = false;
                return;
            }

            var autoresEncontrados = _autorCtrl.ObtenerTodos()
                .Where(a => a.Nombres.Contains(busqueda) || a.Apellidos.Contains(busqueda))
                .ToList();

            if (autoresEncontrados.Any())
            {
                lstAutores.DataSource = autoresEncontrados;
                lstAutores.DisplayMember = "Nombres";
                lstAutores.Visible = true;
                lstAutores.BringToFront();
            }
            else
            {
                lstAutores.Visible = false;
            }
        }

        // Selección de autor
        private void lstAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAutores.SelectedItem is Autor autorSeleccionado)
            {
                txtAutor.Text = autorSeleccionado.NombreCompleto();
                lstAutores.Visible = false;
                autor = autorSeleccionado;
            }
        }

        // Búsqueda de categorías
        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtCategoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                lstCategorias.Visible = false;
                return;
            }

            var categoriasEncontradas = _catCtrl.ObtenerTodas()
                .Where(c => c.NombreCategoria.Contains(busqueda))
                .ToList();

            if (categoriasEncontradas.Any())
            {
                lstCategorias.DataSource = categoriasEncontradas;
                lstCategorias.DisplayMember = "NombreCategoria";
                lstCategorias.Visible = true;
                lstCategorias.BringToFront();
            }
            else
            {
                lstCategorias.Visible = false;
            }
        }

        // Selección de categoría
        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedItem is Categoria categoriaSeleccionada)
            {
                txtCategoria.Text = categoriaSeleccionada.NombreCategoria;
                lstCategorias.Visible = false;
                categoria = categoriaSeleccionada;
            }
        }

        // Búsqueda de editoriales
        private void txtEditorial_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtEditorial.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                lstEditoriales.Visible = false;
                return;
            }

            var editorialesEncontradas = _editorialCtrl.ObtenerTodas()
                .Where(ed => ed.Nombre.Contains(busqueda))
                .ToList();

            if (editorialesEncontradas.Any())
            {
                lstEditoriales.DataSource = editorialesEncontradas;
                lstEditoriales.DisplayMember = "Nombre";
                lstEditoriales.Visible = true;
                lstEditoriales.BringToFront();
            }
            else
            {
                lstEditoriales.Visible = false;
            }
        }

        // Selección de editorial
        private void lstEditoriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEditoriales.SelectedItem is Editorial editorialSeleccionada)
            {
                txtEditorial.Text = editorialSeleccionada.Nombre;
                lstEditoriales.Visible = false;
                editorial = editorialSeleccionada;
            }
        }

        // Botón cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
