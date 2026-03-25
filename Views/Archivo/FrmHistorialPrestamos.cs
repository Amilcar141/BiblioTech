using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Archivo
{
    public partial class FrmHistorialPrestamos : Form
    {
        // Controlador
        private PrestamoController _prestamoCtrl;

        // Constructor
        public FrmHistorialPrestamos(SistemaLibreria sistema)
        {
            InitializeComponent();
            _prestamoCtrl = new PrestamoController(sistema);
        }

        // Evento de carga del formulario
        private void FrmHistorialPrestamos_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.AddRange(new object[] { "Todos", "Activo", "Devuelto", "Vencido" });
            cmbEstado.SelectedIndex = 0;
            CargarTabla();
        }

        // Cargar tabla de historial de préstamos
        private void CargarTabla()
        {
            dgvHistorial.Rows.Clear();

            try
            {
                List<Prestamo> prestamos = ObtenerPrestamosFiltrados();

                foreach (Prestamo prestamo in prestamos)
                {
                    string lector = prestamo.Lector != null ? prestamo.Lector.Nombre : "-";
                    string libro = prestamo.Libros != null && prestamo.Libros.Count > 0 
                        ? prestamo.Libros[0].Libro.Titulo 
                        : "-";

                    string devolucion = prestamo.Estado == EstadoPrestamo.Devuelto
                        ? prestamo.FechaDevolucion.ToString("dd/MM/yyyy")
                        : "-";

                    int fila = dgvHistorial.Rows.Add(
                        prestamo.Codigo,
                        lector,
                        libro,
                        prestamo.FechaInicio.ToString("dd/MM/yyyy"),
                        prestamo.FechaLimite.ToString("dd/MM/yyyy"),
                        devolucion,
                        prestamo.Estado.ToString()
                    );

                    // Aplicar colores según estado
                    if (prestamo.EstaVencido() && prestamo.Estado != EstadoPrestamo.Devuelto)
                        dgvHistorial.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                    else if (prestamo.Estado == EstadoPrestamo.Devuelto)
                        dgvHistorial.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }

                lblContador.Text = "Total: " + dgvHistorial.Rows.Count + " préstamo(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obtener préstamos filtrados según criterios
        private List<Prestamo> ObtenerPrestamosFiltrados()
        {
            string filtro = txtBuscar.Text.Trim().ToLower();
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";
            List<Prestamo> todosPrestamos = _prestamoCtrl.ObtenerTodos();

            // Filtrar por estado
            if (estado != "Todos")
            {
                if (estado == "Vencido")
                {
                    todosPrestamos = todosPrestamos
                        .Where(p => p.EstaVencido() && p.Estado != EstadoPrestamo.Devuelto)
                        .ToList();
                }
                else if (Enum.TryParse(estado, out EstadoPrestamo estadoEnum))
                {
                    todosPrestamos = todosPrestamos
                        .Where(p => p.Estado == estadoEnum)
                        .ToList();
                }
            }

            // Filtrar por búsqueda de texto
            if (string.IsNullOrWhiteSpace(filtro))
                return todosPrestamos;

            return todosPrestamos.Where(p =>
            {
                string lector = p.Lector?.Nombre ?? "";
                string libro = p.Libros != null && p.Libros.Count > 0
                    ? p.Libros[0].Libro.Titulo
                    : "";

                return lector.ToLower().Contains(filtro) ||
                       libro.ToLower().Contains(filtro) ||
                       p.Codigo.ToLower().Contains(filtro);
            }).ToList();
        }

        // Evento cambio en campo de búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Evento cambio en filtro de estado
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Botón limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbEstado.SelectedIndex = 0;
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
