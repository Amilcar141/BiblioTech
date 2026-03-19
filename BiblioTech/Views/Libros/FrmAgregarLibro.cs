using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views
{
    public partial class FrmAgregarLibro : Form
    {
        
        private LibroController _libroCtrl;
        private CategoriaController _catCtrl;

        // Constructor
        public FrmAgregarLibro()
        {
            InitializeComponent();
            _libroCtrl = new LibroController();
            _catCtrl   = new CategoriaController();
            
            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            CargarTabla();
            CargarCategorias();
        }

        
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            foreach (Libro lib in _libroCtrl.ObtenerTodos())
            {
                dgvLibros.Rows.Add(
                    lib.ISBN,
                    lib.Titulo,
                    lib.Autor,
                    lib.Categoria.NombreCategoria,
                    lib.FechaPublicacion.ToString("dd/MM/yyyy"),
                    lib.NumeroPaginas,
                    lib.Editorial
                    // Posibles columnas para la dgv
                    //lib.ObtenerEjemplaresDisponibles(),
                    //lib.Precio.ToString("C")
                );
            }
        }

        // Cargar COmboBox de Categorias
        private void CargarCategorias()
        {
            cbxCategoria.Items.Clear();

            cbxCategoria.Items.Add("Seleccione una categoría");

            List<Categoria> categorias = _catCtrl.ObtenerTodas();

            // Muestra solo el nombre pero obtiene el codigo
            cbxCategoria.DataSource = categorias;
            cbxCategoria.DisplayMember = "NombreCategoria";
            cbxCategoria.ValueMember = "CodigoCategoria";
        }

        // Valida los campos del formulario
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("El ISBN no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreLibro.Text))
            {
                MessageBox.Show("El nombre del libro no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreLibro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El autor no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                return false;
            }

            if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("La categoría no puede estar vacía.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxCategoria.Focus();
                return false;
            }

            if (!int.TryParse(txtNumeroPaginas.Text, out int numeroPaginas) || numeroPaginas <= 0)
            {
                MessageBox.Show("El número de páginas debe ser un número válido mayor a 0.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroPaginas.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEditorial.Text))
            {
                MessageBox.Show("La editorial no puede estar vacía.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditorial.Focus();
                return false;
            }

            return true;
        }

        
        private void LimpiarCampos()
        {
            txtISBN.Clear();
            txtNombreLibro.Clear();
            txtAutor.Clear();
            cbxCategoria.SelectedIndex = 0;
            txtNumeroPaginas.Clear();
            txtEditorial.Clear();
            dtpFechaPublicacion.Value  = DateTime.Today;
            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string isbn = txtISBN.Text.Trim();
            string titulo = txtNombreLibro.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string editorial = txtEditorial.Text.Trim();
            decimal precio = Decimal.Parse(txtPrecio.Text.Trim());
            int numeroPaginas = int.Parse(txtNumeroPaginas.Text);
            DateTime fechaPublicacion = dtpFechaPublicacion.Value;

            // Manejp de la categoria seleccionada
            Categoria categoria = cbxCategoria.SelectedItem as Categoria;

            try
            {
                Libro nuevoLibro = new Libro(
                    isbn,
                    titulo,
                    autor,
                    editorial,
                    precio,
                    numeroPaginas,
                    fechaPublicacion,
                    categoria
                );

                bool resultado = _libroCtrl.AgregarLibro(nuevoLibro);

                if (resultado)
                {
                    MessageBox.Show("Libro guardado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show("El ISBN ingresado ya existe en el sistema.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el libro: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
