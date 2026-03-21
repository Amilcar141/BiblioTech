using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;//7
 
namespace BiblioTech.Views
{
    public partial class FrmBuscarLibro : Form
    {
        // Controlador
        private LibroController _ctrl;

        // Constructor
        public FrmBuscarLibro()
        {
            InitializeComponent();
            _ctrl = new LibroController();

            ConfigurarTabla();
            cmbFiltro.SelectedIndex = 0;
            CargarTabla();
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

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name = "FechaPub"; colFecha.HeaderText = "Fecha Pub."; colFecha.Width = 100;

            DataGridViewTextBoxColumn colPaginas = new DataGridViewTextBoxColumn();
            colPaginas.Name = "Paginas"; colPaginas.HeaderText = "Páginas"; colPaginas.Width = 70;

            DataGridViewTextBoxColumn colEditorial = new DataGridViewTextBoxColumn();
            colEditorial.Name = "Editorial"; colEditorial.HeaderText = "Editorial"; colEditorial.Width = 130;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado"; colEstado.HeaderText = "Estado"; colEstado.Width = 100;

            DataGridViewTextBoxColumn colIdOculto = new DataGridViewTextBoxColumn();
            colIdOculto.Name = "ID"; colIdOculto.Visible = false;

            dgvLibros.Columns.Add(colIdOculto);
            dgvLibros.Columns.Add(colISBN);
            dgvLibros.Columns.Add(colNombre);
            dgvLibros.Columns.Add(colAutor);
            dgvLibros.Columns.Add(colCategoria);
            dgvLibros.Columns.Add(colFecha);
            dgvLibros.Columns.Add(colPaginas);
            dgvLibros.Columns.Add(colEditorial);
            dgvLibros.Columns.Add(colEstado);
        }

        // Cargar datos en la tabla
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            string filtro  = cmbFiltro.SelectedItem != null ? cmbFiltro.SelectedItem.ToString() : "Todos";
            List<Libro> libros = _ctrl.Buscar(txtBuscar.Text, filtro);

            foreach (Libro lib in libros)
            {
                string estado = lib.GetDisponible() ? "Disponible" : "Prestado";
                dgvLibros.Rows.Add(
                    lib.GetIdLibro(),
                    lib.GetISBN(),
                    lib.GetNombreLibro(),
                    lib.GetAutor(),
                    lib.GetNombreCategoria(),
                    lib.GetFechaPublicacion(),
                    lib.GetNumeroPaginas(),
                    lib.GetEditorial(),
                    estado
                );
            }

            lblContador.Text = "Total: " + dgvLibros.Rows.Count + " libro(s)";
        }

        // Eventos
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
