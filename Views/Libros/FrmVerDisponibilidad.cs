using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
 //7
namespace BiblioTech.Views
{
    public partial class FrmVerDisponibilidad : Form
    {
        
        private LibroController _ctrl;

        // Constructor
        public FrmVerDisponibilidad()
        {
            InitializeComponent();
            _ctrl = new LibroController();

            ConfigurarTabla();
            CargarTabla();
        }

        // Configurar columnas de la tabla manualmente
        private void ConfigurarTabla()
        {
            dgvDisponibilidad.Columns.Clear();

            DataGridViewTextBoxColumn colISBN = new DataGridViewTextBoxColumn();
            colISBN.Name = "ISBN"; colISBN.HeaderText = "ISBN"; colISBN.Width = 120;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre"; colNombre.HeaderText = "Nombre Libro"; colNombre.Width = 200;

            DataGridViewTextBoxColumn colAutor = new DataGridViewTextBoxColumn();
            colAutor.Name = "Autor"; colAutor.HeaderText = "Autor"; colAutor.Width = 150;

            DataGridViewTextBoxColumn colCategoria = new DataGridViewTextBoxColumn();
            colCategoria.Name = "Categoria"; colCategoria.HeaderText = "Categoría"; colCategoria.Width = 130;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado"; colEstado.HeaderText = "Estado"; colEstado.Width = 130;

            dgvDisponibilidad.Columns.Add(colISBN);
            dgvDisponibilidad.Columns.Add(colNombre);
            dgvDisponibilidad.Columns.Add(colAutor);
            dgvDisponibilidad.Columns.Add(colCategoria);
            dgvDisponibilidad.Columns.Add(colEstado);
        }

        
        private void CargarTabla()
        {
            dgvDisponibilidad.Rows.Clear();

            List<Libro> libros = _ctrl.Buscar(txtBuscar.Text, "Todos");

            foreach (Libro lib in libros)
            {
                string estado = lib.GetDisponible() ? "✔ Disponible" : "✘ Prestado";
                int fila = dgvDisponibilidad.Rows.Add(
                    lib.GetISBN(),
                    lib.GetNombreLibro(),
                    lib.GetAutor(),
                    lib.GetNombreCategoria(),
                    estado
                );

                // Colorear fila segun disponibilidad
                if (lib.GetDisponible())
                {
                    dgvDisponibilidad.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else
                {
                    dgvDisponibilidad.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }

            lblContador.Text = "Total: " + dgvDisponibilidad.Rows.Count + " libro(s)";
        }

        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
