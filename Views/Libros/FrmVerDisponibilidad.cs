using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views
{
    public partial class FrmVerDisponibilidad : Form
    {
        // Controlador
        private EjemplarController _ejemplarCtrl;

        // Constructor
        public FrmVerDisponibilidad(SistemaLibreria sistema)
        {
            InitializeComponent();
            _ejemplarCtrl = new EjemplarController(sistema);

            CargarTabla();
        }

        // Cargar datos en la tabla
        private void CargarTabla()
        {
            dgvDisponibilidad.Rows.Clear();

            try
            {
                List<Ejemplar> ejemplares = ObtenerEjemplaresFiltrados();

                foreach (Ejemplar ejem in ejemplares)
                {
                    dgvDisponibilidad.Rows.Add(
                        ejem.CodigoEjemplar,
                        ejem.Libro.Titulo,
                        ejem.Libro.Categoria.NombreCategoria,
                        ejem.Estado.ToString()
                    );
                }

                lblContador.Text = "Total: " + dgvDisponibilidad.Rows.Count + " ejemplar(es)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obtener ejemplares filtrados según búsqueda
        private List<Ejemplar> ObtenerEjemplaresFiltrados()
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();
            List<Ejemplar> todosEjemplares = _ejemplarCtrl.ObtenerTodos();

            if (string.IsNullOrWhiteSpace(busqueda))
                return todosEjemplares;

            return todosEjemplares.Where(e =>
                e.CodigoEjemplar.ToLower().Contains(busqueda) ||
                e.Libro.Titulo.ToLower().Contains(busqueda) ||
                e.Libro.Autor.NombreCompleto().ToLower().Contains(busqueda) ||
                e.Estado.ToString().ToLower().Contains(busqueda)
            ).ToList();
        }

        // Evento cambio en campo de búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
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
