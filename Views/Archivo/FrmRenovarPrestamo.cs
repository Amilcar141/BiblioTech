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
    public partial class FrmRenovarPrestamo : Form
    {
        // Controlador
        private PrestamoController _prestamoCtrl;

        // Constructor
        public FrmRenovarPrestamo(SistemaLibreria sistema)
        {
            InitializeComponent();
            _prestamoCtrl = new PrestamoController(sistema);
        }

        // Evento de carga del formulario
        private void FrmRenovarPrestamo_Load(object sender, EventArgs e)
        {
            dtpNuevaFecha.MinDate = DateTime.Today.AddDays(1);
            dtpNuevaFecha.Value = DateTime.Today.AddDays(14);
            CargarPrestamos();
        }

        // Cargar préstamos activos
        private void CargarPrestamos()
        {
            dgvPrestamos.Rows.Clear();
            string filtro = txtBuscar.Text.Trim().ToLower();

            try
            {
                List<Prestamo> prestamosActivos = _prestamoCtrl.ObtenerActivos();

                foreach (Prestamo prestamo in prestamosActivos)
                {
                    string libro = prestamo.Libros != null && prestamo.Libros.Count > 0
                        ? prestamo.Libros[0].Libro.Titulo
                        : "";
                    string lector = prestamo.Lector != null ? prestamo.Lector.Nombre : "";

                    // Aplicar filtro de búsqueda
                    if (!string.IsNullOrEmpty(filtro) &&
                        !libro.ToLower().Contains(filtro) &&
                        !lector.ToLower().Contains(filtro))
                        continue;

                    bool vencido = prestamo.EstaVencido();
                    int fila = dgvPrestamos.Rows.Add(
                        prestamo.Codigo,
                        lector,
                        libro,
                        prestamo.FechaLimite.ToString("dd/MM/yyyy"),
                        vencido ? "VENCIDO" : "Activo");

                    if (vencido)
                        dgvPrestamos.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                }

                lblContador.Text = "Activos: " + dgvPrestamos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar préstamos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento cambio en búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        // Evento cambio de selección en tabla
        private void dgvPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
                return;

            string codigo = dgvPrestamos.CurrentRow.Cells[0].Value?.ToString();

            if (string.IsNullOrWhiteSpace(codigo))
                return;

            Prestamo prestamo = _prestamoCtrl.ObtenerTodos()
                .FirstOrDefault(p => p.Codigo == codigo);

            if (prestamo != null)
            {
                dtpNuevaFecha.MinDate = prestamo.FechaLimite > DateTime.Today
                    ? prestamo.FechaLimite.AddDays(1)
                    : DateTime.Today.AddDays(1);
            }
        }

        // Botón renovar
        private void btnRenovar_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un préstamo de la tabla.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = dgvPrestamos.CurrentRow.Cells[0].Value?.ToString();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("No se pudo obtener el código del préstamo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Prestamo prestamo = _prestamoCtrl.ObtenerTodos()
                .FirstOrDefault(p => p.Codigo == codigo);

            if (prestamo == null)
            {
                MessageBox.Show("Préstamo no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string libro = prestamo.Libros != null && prestamo.Libros.Count > 0
                ? prestamo.Libros[0].Libro.Titulo
                : "Desconocido";

            DialogResult respuesta = MessageBox.Show(
                "¿Renovar préstamo de \"" + libro + "\"?\n" +
                "Nueva fecha límite: " + dtpNuevaFecha.Value.ToString("dd/MM/yyyy"),
                "Confirmar Renovación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                prestamo.FechaLimite = dtpNuevaFecha.Value;
                prestamo.Estado = EstadoPrestamo.Activo;

                MessageBox.Show(
                    "Préstamo renovado correctamente.\n" +
                    "Nueva fecha límite: " + dtpNuevaFecha.Value.ToString("dd/MM/yyyy"),
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al renovar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarPrestamos();
            txtBuscar.Focus();
        }

        // Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
