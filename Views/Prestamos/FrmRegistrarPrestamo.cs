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
        private LibroController    _libroCtrl    = new LibroController();
        private PrestamoController _prestamoCtrl = new PrestamoController();
        private Libro _libroSeleccionado;

        public FrmRegistrarPrestamo() { InitializeComponent(); }

        private void FrmRegistrarPrestamo_Load(object sender, EventArgs e)
        {
            dtpFechaLimite.MinDate = DateTime.Today.AddDays(1);
            dtpFechaLimite.Value   = DateTime.Today.AddDays(14);
            CargarLibros();
        }

        private void CargarLibros()
        {
            cmbLibro.Items.Clear();
            cmbLibro.Items.Add("-- Seleccione un libro --");
            foreach (Libro lib in _libroCtrl.Buscar("", "Disponibles"))
            {
                cmbLibro.Items.Add(
                    new ComboBoxItem(lib.GetNombreLibro() + "  [ISBN: " + lib.GetISBN() + "]", lib));
            }
            cmbLibro.SelectedIndex = 0;
        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedItem is ComboBoxItem item)
            {
                _libroSeleccionado    = item.Libro;
                txtISBN.Text          = _libroSeleccionado.GetISBN();
                txtAutor.Text         = _libroSeleccionado.GetAutor();
                txtCategoria.Text     = _libroSeleccionado.GetNombreCategoria();
                txtEditorial.Text     = _libroSeleccionado.GetEditorial();
            }
            else
            {
                _libroSeleccionado = null;
                txtISBN.Clear(); txtAutor.Clear(); txtCategoria.Clear(); txtEditorial.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_libroSeleccionado == null)
            { MessageBox.Show("Seleccione un libro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            { MessageBox.Show("Ingrese el nombre del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (dtpFechaLimite.Value <= DateTime.Today)
            { MessageBox.Show("La fecha límite debe ser posterior a hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            Prestamo nuevo = new Prestamo();
            nuevo.IdPrestamo      = _prestamoCtrl.Historial.Count + 1;
            nuevo.Lector          = new Models.Lector(txtNombreUsuario.Text.Trim());
            nuevo.Libro           = _libroSeleccionado;
            nuevo.FechaInicio     = DateTime.Now;
            nuevo.FechaLimite     = dtpFechaLimite.Value;
            nuevo.Estado          = Models.Enums.EstadoPrestamo.Activo;
            nuevo.GestionadoPor   = new Models.Administrador("Administrador");

            _prestamoCtrl.Historial.Add(nuevo);
            _libroSeleccionado.SetDisponible(false);

            MessageBox.Show("Préstamo registrado correctamente.\nFecha límite: " +
                dtpFechaLimite.Value.ToString("dd/MM/yyyy"), "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
            CargarLibros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) { LimpiarFormulario(); }
        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }

        private void LimpiarFormulario()
        {
            cmbLibro.SelectedIndex = 0;
            txtNombreUsuario.Clear();
            txtISBN.Clear(); txtAutor.Clear(); txtCategoria.Clear(); txtEditorial.Clear();
            dtpFechaLimite.Value = DateTime.Today.AddDays(14);
            _libroSeleccionado = null;
        }

        private class ComboBoxItem
        {
            public string Text  { get; }
            public Libro  Libro { get; }
            public ComboBoxItem(string text, Libro libro) { Text = text; Libro = libro; }
            public override string ToString() { return Text; }
        }
    }
}
