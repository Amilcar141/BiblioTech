using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views
{ 
    public partial class FrmAgregarLibro : Form
    {
        
        private LibroController _libroCtrl;
        private CategoriaController _catCtrl;
        private AutorController _autorCtrl;
        private EditorialController _editorialCtrl;

        // Variables para guardar datos
        private Autor autor;
        private Categoria categoria;
        private Editorial editorial; 

        // Constructor
        public FrmAgregarLibro(SistemaLibreria _sistema)
        {
            InitializeComponent();
            _libroCtrl = new LibroController(_sistema);
            _catCtrl = new CategoriaController(_sistema);
            _autorCtrl = new AutorController(_sistema);
            _editorialCtrl = new EditorialController(_sistema);

            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            CargarTabla();
        }
        
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            foreach (Libro lib in _libroCtrl.Inventario())
            {
                dgvLibros.Rows.Add(
                    lib.ISBN,
                    lib.Titulo,
                    lib.Autor.NombreCompleto(),
                    lib.Categoria?.NombreCategoria ?? "Sin categoría",
                    lib.Editorial?.Nombre ?? "Sin editorial",
                    lib.FechaPublicacion.ToString("dd/MM/yy"),
                    lib.NumeroPaginas.ToString(),
                    lib.Precio
                );
            }
        }
        
        private void LimpiarCampos()
        {
            txtISBN.Clear();
            txtNombreLibro.Clear();
            txtAutor.Clear();
            txtCategoria.Clear();
            txtNumeroPaginas.Clear();
            txtEditorial.Clear();
            txtPrecio.Clear();
            dtpFechaPublicacion.Value  = DateTime.Today;
            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            
            // Limpiar selecciones
            autor = null;
            categoria = null;
            editorial = null;
            
            // Ocultar listas
            lstAutores.Visible = false;
            lstCategorias.Visible = false;
            lstEditoriales.Visible = false;
        }

        // Valida si todos los campos estan bien
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
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (autor == null)
            {
                MessageBox.Show("Por favor, seleccione un autor válido de la lista.", "Autor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (categoria == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría válida de la lista.", "Categoría Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (editorial == null)
            {
                MessageBox.Show("Por favor, seleccione una editorial válida de la lista.", "Editorial Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtNumeroPaginas.Text, out int paginas) || paginas <= 0)
            {
                MessageBox.Show("Número de páginas debe ser un entero positivo.", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Precio debe ser un número decimal no negativo.", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string isbn = txtISBN.Text.Trim();
            string titulo = txtNombreLibro.Text.Trim();
            decimal precio = decimal.Parse(txtPrecio.Text.Trim());
            int numPaginas = int.Parse(txtNumeroPaginas.Text.Trim());
            DateTime fecha = dtpFechaPublicacion.Value;

            if (ValidarCampos())
            {
                try
                {   // Crear el libro
                    Libro nuevoLibro = new Libro(isbn, titulo, autor, categoria, editorial, precio, numPaginas, fecha);

                    // Agregar el libro al sistema
                    if (_libroCtrl.AgregarLibro(nuevoLibro))
                    {
                        MessageBox.Show("Libro agregado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarTabla();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un libro con ese ISBN.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtISBN.Focus();
        }

        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Metodos que manejan la busqueda y seleccion de Autor, Categoria y Editorial
        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtAutor.Text.Trim();

            // Valida si el texto está vacío para ocultar la lista de inmediato
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                lstAutores.Visible = false;
                return;
            }

            // Filtrar por Nombre O Apellido
            var autoresEncontrados = _autorCtrl.ObtenerTodos()
                .Where(a => a.Nombres.Contains(busqueda) ||
                            a.Apellidos.Contains(busqueda))
                .ToList();

            // Mostrar u ocultar según resultados
            if (autoresEncontrados.Any())
            {
                lstAutores.DataSource = autoresEncontrados;
                // Importante: Indicar qué propiedad mostrar en el ListBox
                lstAutores.DisplayMember = "Nombres"; // Ver nota abajo
                lstAutores.Visible = true;
                lstAutores.BringToFront();
            }
            else
            {
                lstAutores.Visible = false;
            }
        }

        private void lstAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAutores.SelectedItem is Autor autorSeleccionado)
            {
                txtAutor.Text = autorSeleccionado.NombreCompleto();
                lstAutores.Visible = false;

                // Guardar el autor seleccionado para usarlo al crear el libro
                autor = autorSeleccionado; 
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtCategoria.Text.Trim();

            // Valida si el texto está vacío para ocultar la lista de inmediato
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                lstCategorias.Visible = false;
                return;
            }

            // Filtrar por Nombre O Apellido
            var categoriasEncontradas = _catCtrl.ObtenerTodas()
                .Where(a => a.NombreCategoria.Contains(busqueda))
                .ToList();

            // Mostrar u ocultar según resultados
            if (categoriasEncontradas.Any())
            {
                lstCategorias.DataSource = categoriasEncontradas;
                // Importante: Indicar qué propiedad mostrar en el ListBox
                lstCategorias.DisplayMember = "NombreCategoria"; // Ver nota abajo
                lstCategorias.Visible = true;
                lstCategorias.BringToFront();
            }
            else
            {
                lstCategorias.Visible = false;
            }
        }

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedItem is Categoria catSeleccionada)
            {
                txtCategoria.Text = catSeleccionada.NombreCategoria;
                lstCategorias.Visible = false;

                // Guardar la categoria seleccionado
                categoria = catSeleccionada;
            }
        }

        private void txtEditorial_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtEditorial.Text.Trim();

            // Valida si el texto está vacío para ocultar la lista de inmediato
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                lstEditoriales.Visible = false;
                return;
            }

            // Filtrar por Nombre O Apellido
            var editorialesEncontradas = _editorialCtrl.ObtenerTodas()
                .Where(a => a.Nombre.Contains(busqueda))
                .ToList();

            // Mostrar u ocultar según resultados
            if (editorialesEncontradas.Any())
            {
                lstEditoriales.DataSource = editorialesEncontradas;
                // Importante: Indicar qué propiedad mostrar en el ListBox
                lstEditoriales.DisplayMember = "Nombre"; // Ver nota abajo
                lstEditoriales.Visible = true;
                lstEditoriales.BringToFront();
            }
            else
            {
                lstEditoriales.Visible = false;
            }
        }

        private void lstEditoriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEditoriales.SelectedItem is Editorial editorialSelccionada)
            {
                txtEditorial.Text = editorialSelccionada.Nombre;
                lstEditoriales.Visible = false;

                // Guardar la categoria seleccionado
                editorial = editorialSelccionada;
            }
        }
    }
}
