using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
//7
namespace BiblioTech.Views
{
    public partial class FrmEditarLibro : Form
    {
        // Controladores 
        private LibroController     _libroCtrl;
        private CategoriaController _catCtrl;
        private int _idSeleccionado;

        // Constructor
        public FrmEditarLibro()
        {
            InitializeComponent();
            _libroCtrl      = new LibroController();
            _catCtrl        = new CategoriaController();
            _idSeleccionado = 0;

            ConfigurarTabla();
            CargarTabla();
            HabilitarEdicion(false);
        }

        // Configurar columnas de la tabla 
        private void ConfigurarTabla()
        {
            dgvLibros.Columns.Clear();

            DataGridViewTextBoxColumn colISBN = new DataGridViewTextBoxColumn();
            colISBN.Name = "ISBN"; colISBN.HeaderText = "ISBN"; colISBN.Width = 110;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre"; colNombre.HeaderText = "Nombre Libro"; colNombre.Width = 200;

            DataGridViewTextBoxColumn colAutor = new DataGridViewTextBoxColumn();
            colAutor.Name = "Autor"; colAutor.HeaderText = "Autor"; colAutor.Width = 150;

            DataGridViewTextBoxColumn colCategoria = new DataGridViewTextBoxColumn();
            colCategoria.Name = "Categoria"; colCategoria.HeaderText = "Categoría"; colCategoria.Width = 120;

            DataGridViewTextBoxColumn colEditorial = new DataGridViewTextBoxColumn();
            colEditorial.Name = "Editorial"; colEditorial.HeaderText = "Editorial"; colEditorial.Width = 130;

            DataGridViewTextBoxColumn colIdOculto = new DataGridViewTextBoxColumn();
            colIdOculto.Name = "ID"; colIdOculto.Visible = false;

            dgvLibros.Columns.Add(colIdOculto);
            dgvLibros.Columns.Add(colISBN);
            dgvLibros.Columns.Add(colNombre);
            dgvLibros.Columns.Add(colAutor);
            dgvLibros.Columns.Add(colCategoria);
            dgvLibros.Columns.Add(colEditorial);
        }

        
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            List<Libro> libros = _libroCtrl.Buscar(txtBuscar.Text, "Todos");

            foreach (Libro lib in libros)
            {
                dgvLibros.Rows.Add(
                    lib.GetIdLibro(),
                    lib.GetISBN(),
                    lib.GetNombreLibro(),
                    lib.GetAutor(),
                    lib.GetNombreCategoria(),
                    lib.GetEditorial()
                );
            }
        }

        // Habilitar o deshabilitar botones y campos de edición
        private void HabilitarEdicion(bool activo)
        {
            txtISBN.Enabled             = activo;
            txtNombreLibro.Enabled      = activo;
            txtAutor.Enabled            = activo;
            txtCategoria.Enabled        = activo;
            dtpFechaPublicacion.Enabled = activo;
            txtNumeroPaginas.Enabled    = activo;
            txtEditorial.Enabled        = activo;
            btnGuardarCambios.Enabled   = activo;
        }

        
        private void LimpiarFormulario()
        {
            _idSeleccionado = 0;
            txtISBN.Clear();
            txtNombreLibro.Clear();
            txtAutor.Clear();
            txtCategoria.Clear();
            txtNumeroPaginas.Clear();
            txtEditorial.Clear();
            dtpFechaPublicacion.Value = DateTime.Today;
        }

        
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

        // Evento buscar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Doble clic en tabla carga el libro
        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id    = Convert.ToInt32(dgvLibros.Rows[e.RowIndex].Cells["ID"].Value);
            Libro lib = _libroCtrl.ObtenerPorId(id);
            if (lib == null)
                return;

            _idSeleccionado       = lib.GetIdLibro();
            txtISBN.Text          = lib.GetISBN();
            txtNombreLibro.Text   = lib.GetNombreLibro();
            txtAutor.Text         = lib.GetAutor();
            txtCategoria.Text     = lib.GetNombreCategoria();
            txtNumeroPaginas.Text = lib.GetNumeroPaginas().ToString();
            txtEditorial.Text     = lib.GetEditorial();

            DateTime fechaPub;
            if (DateTime.TryParse(lib.GetFechaPublicacion(), out fechaPub))
                dtpFechaPublicacion.Value = fechaPub;

            HabilitarEdicion(true);
        }

        
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Haga doble clic en un libro de la tabla para cargarlo.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreCat = txtCategoria.Text.Trim();
            Categoria categoria = ResolverCategoria(nombreCat);
            if (categoria == null)
                return;

            string mensaje  = "";
            bool   resultado = _libroCtrl.Editar(
                _idSeleccionado,
                txtISBN.Text,
                txtNombreLibro.Text,
                txtAutor.Text,
                categoria.GetIdCategoria(),
                categoria.GetNombreCategoria(),
                dtpFechaPublicacion.Value.ToString("dd/MM/yyyy"),
                txtNumeroPaginas.Text,
                txtEditorial.Text,
                "(editado)",
                out mensaje);

            if (resultado)
            {
                MessageBox.Show(mensaje, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                HabilitarEdicion(false);
                CargarTabla();
            }
            else
            {
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            HabilitarEdicion(false);
        }

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
