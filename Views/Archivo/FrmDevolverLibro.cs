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
    public partial class FrmDevolverLibro : Form
    {
        // Controlador
        private PrestamoController _prestamoCtrl;

        // Constructor
        public FrmDevolverLibro(SistemaLibreria sistema)
        {
            InitializeComponent();
            _prestamoCtrl = new PrestamoController(sistema);
        }

        // Evento de carga del formulario
        private void FrmDevolverLibro_Load(object sender, EventArgs e)
        {
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
                    string nombreLibro = prestamo.Libros != null && prestamo.Libros.Count > 0
                        ? prestamo.Libros[0].Libro.Titulo
                        : "";
                    string nombreLector = prestamo.Lector != null ? prestamo.Lector.Nombre : "";

                    // Aplicar filtro de búsqueda
                    if (!string.IsNullOrEmpty(filtro) &&
                        !nombreLibro.ToLower().Contains(filtro) &&
                        !nombreLector.ToLower().Contains(filtro))
                        continue;

                    bool vencido = prestamo.EstaVencido();
                    int fila = dgvPrestamos.Rows.Add(
                        prestamo.Codigo,
                        nombreLector,
                        nombreLibro,
                        prestamo.FechaInicio.ToString("dd/MM/yyyy"),
                        prestamo.FechaLimite.ToString("dd/MM/yyyy"),
                        vencido ? "VENCIDO" : "Activo");

                    if (vencido)
                        dgvPrestamos.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                }

                lblContador.Text = "Total activos: " + dgvPrestamos.Rows.Count;
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

        // Botón devolver
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un préstamo.", "Aviso",
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

            string nombreLibro = prestamo.Libros != null && prestamo.Libros.Count > 0
                ? prestamo.Libros[0].Libro.Titulo
                : "Desconocido";

            string msg = "¿Confirmar devolución del libro \"" + nombreLibro + "\"?";
            
            if (prestamo.EstaVencido())
                msg += "\n\n⚠ Este préstamo está VENCIDO. Se generará una multa.";

            DialogResult respuesta = MessageBox.Show(msg, "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                // Registrar devolución
                Administrador admin = new Administrador("Sistema", "sistema@bibliotech.com", "1234", true, 1, "");
                prestamo.RegistrarDevolucion(DateTime.Now, admin);

                // Cambiar estado a devuelto
                prestamo.Estado = EstadoPrestamo.Devuelto;

                MessageBox.Show("Devolución registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar devolución: " + ex.Message, "Error",
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
