using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Prestamos
{
    public partial class FrmRegistrarPrestamo : Form
    {
        // Controladores
        private LibroController _libroCtrl;
        private EjemplarController _ejemplarCtrl;
        private PrestamoController _prestamoCtrl;

        // Variables para guardar datos seleccionados
        private Libro _libroSeleccionado;
        private Lector _lectorSeleccionado;

        // Constructor
        public FrmRegistrarPrestamo(SistemaLibreria sistema)
        {
            InitializeComponent();
            _libroCtrl = new LibroController(sistema);
            _ejemplarCtrl = new EjemplarController(sistema);
            _prestamoCtrl = new PrestamoController(sistema);

            _libroSeleccionado = null;
            _lectorSeleccionado = null;
        }

        // Evento de carga del formulario
        private void FrmRegistrarPrestamo_Load(object sender, EventArgs e)
        {
            dtpFechaLimite.MinDate = DateTime.Today.AddDays(1);
            dtpFechaLimite.Value = DateTime.Today.AddDays(14);
            CargarLibros();
        }

        // Cargar libros disponibles
        private void CargarLibros()
        {
            cmbLibro.Items.Clear();
            cmbLibro.Items.Add("-- Seleccione un libro --");

            try
            {
                foreach (Libro lib in _libroCtrl.Inventario())
                {
                    cmbLibro.Items.Add(
                        new ComboBoxItem(
                            lib.Titulo + "  [ISBN: " + lib.ISBN + "]",
                            lib));
                }

                cmbLibro.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los libros: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento cambio de libro seleccionado
        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedItem is ComboBoxItem item)
            {
                _libroSeleccionado = item.Libro;
                txtISBN.Text = _libroSeleccionado.ISBN;
                txtAutor.Text = _libroSeleccionado.Autor.NombreCompleto();
                txtCategoria.Text = _libroSeleccionado.Categoria.NombreCategoria;
                txtEditorial.Text = _libroSeleccionado.Editorial.Nombre;
            }
            else
            {
                _libroSeleccionado = null;
                LimpiarCamposLibro();
            }
        }

        // Limpiar campos de libro
        private void LimpiarCamposLibro()
        {
            txtISBN.Clear();
            txtAutor.Clear();
            txtCategoria.Clear();
            txtEditorial.Clear();
        }

        // Botón guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_libroSeleccionado == null)
            {
                MessageBox.Show("Seleccione un libro.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre del usuario.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFechaLimite.Value <= DateTime.Today)
            {
                MessageBox.Show("La fecha límite debe ser posterior a hoy.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear lector
                Lector lector = new Lector(
                    txtNombreUsuario.Text.Trim(),
                    "usuario@bibliotech.com",
                    "1234",
                    true);

                // Crear lista de ejemplares (para este ejemplo, un solo ejemplar)
                List<Ejemplar> ejemplares = new List<Ejemplar>();
                Ejemplar ejemplar = new Ejemplar(_libroSeleccionado);
                ejemplares.Add(ejemplar);

                // Crear prestamo
                Administrador admin = new Administrador("Sistema", "sistema@bibliotech.com", "1234", true, 1, "");
                Prestamo nuevoPrestamo = new Prestamo(
                    lector,
                    ejemplares,
                    DateTime.Now,
                    dtpFechaLimite.Value,
                    admin);

                // Registrar préstamo
                if (_prestamoCtrl.RegistrarPrestamo(nuevoPrestamo))
                {
                    MessageBox.Show(
                        "Préstamo registrado correctamente.\n" +
                        "Código: " + nuevoPrestamo.Codigo + "\n" +
                        "Fecha límite: " + dtpFechaLimite.Value.ToString("dd/MM/yyyy"),
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();
                    CargarLibros();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el préstamo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // Botón cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Limpiar formulario completo
        private void LimpiarFormulario()
        {
            cmbLibro.SelectedIndex = 0;
            txtNombreUsuario.Clear();
            LimpiarCamposLibro();
            dtpFechaLimite.Value = DateTime.Today.AddDays(14);
            _libroSeleccionado = null;
            _lectorSeleccionado = null;
            txtNombreUsuario.Focus();
        }

        // Clase auxiliar para ComboBox
        private class ComboBoxItem
        {
            public string Text { get; }
            public Libro Libro { get; }

            public ComboBoxItem(string text, Libro libro)
            {
                Text = text;
                Libro = libro;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
