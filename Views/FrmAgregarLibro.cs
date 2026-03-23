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
        
        private LibroController     _libroCtrl;
        private CategoriaController _catCtrl;

        // Constructor
        public FrmAgregarLibro()
        {
            InitializeComponent();
            _libroCtrl = new LibroController();
            _catCtrl   = new CategoriaController();

            ConfigurarTabla();
            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            CargarTabla();
        }

        // Configurar columnas de la tabla
        private void ConfigurarTabla()
        {
            dgvLibros.Columns.Clear();

            DataGridViewTextBoxColumn colISBN = new DataGridViewTextBoxColumn();
            colISBN.Name       = "ISBN";
            colISBN.HeaderText = "ISBN";
            colISBN.Width      = 120;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name       = "Nombre";
            colNombre.HeaderText = "Nombre Libro";
            colNombre.Width      = 200;

            DataGridViewTextBoxColumn colAutor = new DataGridViewTextBoxColumn();
            colAutor.Name       = "Autor";
            colAutor.HeaderText = "Autor";
            colAutor.Width      = 150;

            DataGridViewTextBoxColumn colCategoria = new DataGridViewTextBoxColumn();
            colCategoria.Name       = "Categoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.Width      = 130;

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name       = "FechaPub";
            colFecha.HeaderText = "Fecha Pub.";
            colFecha.Width      = 100;

            DataGridViewTextBoxColumn colPaginas = new DataGridViewTextBoxColumn();
            colPaginas.Name       = "Paginas";
            colPaginas.HeaderText = "Páginas";
            colPaginas.Width      = 70;

            DataGridViewTextBoxColumn colEditorial = new DataGridViewTextBoxColumn();
            colEditorial.Name       = "Editorial";
            colEditorial.HeaderText = "Editorial";
            colEditorial.Width      = 130;

            DataGridViewTextBoxColumn colAlias = new DataGridViewTextBoxColumn();
            colAlias.Name       = "Alias";
            colAlias.HeaderText = "Registrado por";
            colAlias.Width      = 120;

            DataGridViewTextBoxColumn colIdOculto = new DataGridViewTextBoxColumn();
            colIdOculto.Name    = "ID";
            colIdOculto.Visible = false;

            dgvLibros.Columns.Add(colIdOculto);
            dgvLibros.Columns.Add(colISBN);
            dgvLibros.Columns.Add(colNombre);
            dgvLibros.Columns.Add(colAutor);
            dgvLibros.Columns.Add(colCategoria);
            dgvLibros.Columns.Add(colFecha);
            dgvLibros.Columns.Add(colPaginas);
            dgvLibros.Columns.Add(colEditorial);
            dgvLibros.Columns.Add(colAlias);
        }

        
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            List<Libro> libros = _libroCtrl.Buscar("", "Todos");

            foreach (Libro lib in libros)
            {
                dgvLibros.Rows.Add(
                    lib.GetIdLibro(),
                    lib.GetISBN(),
                    lib.GetNombreLibro(),
                    lib.GetAutor(),
                    lib.GetNombreCategoria(),
                    lib.GetFechaPublicacion(),
                    lib.GetNumeroPaginas(),
                    lib.GetEditorial(),
                    lib.GetAliasUsuario()
                );
            }
        }

        // busca existente, si no la crea
        private Categoria ResolverCategoria(string nombreCat)
        {
            Categoria existente = _catCtrl.ObtenerPorNombre(nombreCat);

            if (existente != null)
                return existente;

            string mensajeCategoria = "";
            bool creada = _catCtrl.Guardar(nombreCat, out mensajeCategoria);

            if (!creada)
            {
                MessageBox.Show(mensajeCategoria, "Error en categoría",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return _catCtrl.ObtenerPorNombre(nombreCat);
        }

        
        private void LimpiarCampos()
        {
            txtISBN.Clear();
            txtNombreLibro.Clear();
            txtAutor.Clear();
            txtCategoria.Clear();
            txtNumeroPaginas.Clear();
            txtEditorial.Clear();
            txtAliasUsuario.Clear();
            dtpFechaPublicacion.Value  = DateTime.Today;
            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCat = txtCategoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreCat))
            {
                MessageBox.Show("La categoría no puede estar vacía.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria categoria = ResolverCategoria(nombreCat);
            if (categoria == null)
                return;

            string mensaje = "";
            bool resultado = _libroCtrl.Guardar(
                txtISBN.Text,
                txtNombreLibro.Text,
                txtAutor.Text,
                categoria.GetIdCategoria(),
                categoria.GetNombreCategoria(),
                dtpFechaPublicacion.Value.ToString("dd/MM/yyyy"),
                txtNumeroPaginas.Text,
                txtEditorial.Text,
                txtAliasUsuario.Text,
                out mensaje);

            if (resultado)
            {
                MessageBox.Show(mensaje, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarTabla();
            }
            else
            {
                MessageBox.Show(mensaje, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
