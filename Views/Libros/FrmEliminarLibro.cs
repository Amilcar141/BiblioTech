using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views 
{
    public partial class FrmEliminarLibro : Form
    {
        // Controlador
        private LibroController _ctrl;
        private int _idSeleccionado;

        // Constructor
        public FrmEliminarLibro()
        {
            InitializeComponent();
            _ctrl           = new LibroController();
            _idSeleccionado = 0;

            ConfigurarTabla();
            CargarTabla();
        }

        // Configurar columnas de la tabla 
        private void ConfigurarTabla()
        {
            dgvLibros.Columns.Clear();

            DataGridViewTextBoxColumn colISBN = new DataGridViewTextBoxColumn();
            colISBN.Name = "ISBN"; colISBN.HeaderText = "ISBN"; colISBN.Width = 120;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre"; colNombre.HeaderText = "Nombre Libro"; colNombre.Width = 200;

            DataGridViewTextBoxColumn colAutor = new DataGridViewTextBoxColumn();
            colAutor.Name = "Autor"; colAutor.HeaderText = "Autor"; colAutor.Width = 150;

            DataGridViewTextBoxColumn colCategoria = new DataGridViewTextBoxColumn();
            colCategoria.Name = "Categoria"; colCategoria.HeaderText = "Categoría"; colCategoria.Width = 130;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado"; colEstado.HeaderText = "Estado"; colEstado.Width = 100;

            DataGridViewTextBoxColumn colIdOculto = new DataGridViewTextBoxColumn();
            colIdOculto.Name = "ID"; colIdOculto.Visible = false;

            dgvLibros.Columns.Add(colIdOculto);
            dgvLibros.Columns.Add(colISBN);
            dgvLibros.Columns.Add(colNombre);
            dgvLibros.Columns.Add(colAutor);
            dgvLibros.Columns.Add(colCategoria);
            dgvLibros.Columns.Add(colEstado);
        }

        
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            List<Libro> libros = _ctrl.Buscar(txtBuscar.Text, "Todos");

            foreach (Libro lib in libros)
            {
                string estado = lib.GetDisponible() ? "Disponible" : "Prestado";
                dgvLibros.Rows.Add(
                    lib.GetIdLibro(),
                    lib.GetISBN(),
                    lib.GetNombreLibro(),
                    lib.GetAutor(),
                    lib.GetNombreCategoria(),
                    estado
                );
            }

            lblContador.Text = "Total: " + dgvLibros.Rows.Count + " libro(s)";
        }

        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null)
                return;

            _idSeleccionado = Convert.ToInt32(dgvLibros.CurrentRow.Cells["ID"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un libro de la tabla.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreLibro = "";
            if (dgvLibros.CurrentRow != null)
                nombreLibro = dgvLibros.CurrentRow.Cells["Nombre"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar ,Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            string mensaje  = "";
            bool   resultado = _ctrl.Eliminar(_idSeleccionado, out mensaje);

            if (resultado)
            {
                MessageBox.Show(mensaje, "Eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _idSeleccionado = 0;
                CargarTabla();
            }
            else
            {
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            _idSeleccionado = 0;
            CargarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
