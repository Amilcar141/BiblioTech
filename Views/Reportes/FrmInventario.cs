using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Reportes
{
    public partial class FrmInventario : Form
    {
        // Controlador
        private LibroController _libroCtrl;

        // Constructor
        public FrmInventario(SistemaLibreria sistema)
        {
            InitializeComponent();
            _libroCtrl = new LibroController(sistema);
        }

        // Evento de carga del formulario
        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Cargar tabla de inventario
        private void CargarTabla()
        {
            dgvInventario.Rows.Clear();

            try
            {
                List<Libro> libros = ObtenerLibrosFiltrados();
                int disponibles = 0, prestados = 0;

                foreach (Libro lib in libros)
                {
                    int fila = dgvInventario.Rows.Add(
                        lib.ISBN,
                        lib.Titulo,
                        lib.Autor.NombreCompleto(),
                        lib.Categoria.NombreCategoria,
                        lib.Editorial.Nombre,
                        lib.FechaPublicacion.ToString("dd/MM/yyyy"),
                        lib.NumeroPaginas.ToString(),
                        lib.Precio.ToString("C")
                    );

                    // Contar libros (podría representar disponibilidad según lógica del negocio)
                    disponibles++;
                }

                lblContador.Text = string.Format("Total: {0} libro(s)", dgvInventario.Rows.Count);
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
            string filtro = txtBuscar.Text.Trim().ToLower();
            List<Libro> todosLibros = _libroCtrl.Inventario();

            if (string.IsNullOrWhiteSpace(filtro))
                return todosLibros;

            return todosLibros.Where(lib =>
                lib.ISBN.ToLower().Contains(filtro) ||
                lib.Titulo.ToLower().Contains(filtro) ||
                lib.Autor.NombreCompleto().ToLower().Contains(filtro) ||
                lib.Categoria.NombreCategoria.ToLower().Contains(filtro) ||
                lib.Editorial.Nombre.ToLower().Contains(filtro)
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
