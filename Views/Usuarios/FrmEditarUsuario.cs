using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Usuarios
{
    public partial class FrmEditarUsuario : Form
    {
        // Controlador
        private LectorController _lectorCtrl;

        // Variables
        private Lector _lectorSeleccionado;

        // Constructor
        public FrmEditarUsuario(SistemaLibreria sistema)
        {
            InitializeComponent();
            _lectorCtrl = new LectorController(sistema);
            _lectorSeleccionado = null;
        }

        // Evento de carga del formulario
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            CargarTabla();
            HabilitarEdicion(false);
        }

        // Cargar tabla de lectores
        private void CargarTabla()
        {
            dgvUsuarios.Rows.Clear();
            string termino = txtBuscar.Text.Trim().ToLower();

            try
            {
                foreach (Lector lector in _lectorCtrl.ObtenerTodos())
                {
                    // Aplicar filtro de búsqueda
                    if (!string.IsNullOrEmpty(termino) &&
                        !lector.Nombre.ToLower().Contains(termino) &&
                        !lector.Correo.ToLower().Contains(termino) &&
                        !lector.Cuenta.ToLower().Contains(termino))
                        continue;

                    int fila = dgvUsuarios.Rows.Add(
                        lector.Cuenta,
                        lector.Nombre,
                        lector.Correo,
                        lector.Activo ? "Activo" : "Inactivo");

                    if (!lector.Activo)
                        dgvUsuarios.Rows[fila].DefaultCellStyle.ForeColor = Color.Gray;
                }

                lblContador.Text = "Total: " + dgvUsuarios.Rows.Count + " lector(es)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Habilitar o deshabilitar edición
        private void HabilitarEdicion(bool activo)
        {
            txtNombre.Enabled = activo;
            txtCorreo.Enabled = activo;
            txtPassword.Enabled = activo;
            btnGuardar.Enabled = activo;
        }

        // Evento cambio en búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Evento doble clic en tabla
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string cuenta = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value?.ToString();

            if (string.IsNullOrWhiteSpace(cuenta))
                return;

            _lectorSeleccionado = _lectorCtrl.ObtenerPorCuenta(cuenta);

            if (_lectorSeleccionado == null)
                return;

            txtNombre.Text = _lectorSeleccionado.Nombre;
            txtCorreo.Text = _lectorSeleccionado.Correo;
            txtPassword.Text = "";
            HabilitarEdicion(true);
        }

        // Botón guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_lectorSeleccionado == null)
            {
                MessageBox.Show("Haga doble clic en un lector de la tabla.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Actualizar datos del lector
                _lectorSeleccionado.Nombre = txtNombre.Text.Trim();
                _lectorSeleccionado.Correo = txtCorreo.Text.Trim();

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    if (txtPassword.Text.Length < 6)
                    {
                        MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    _lectorSeleccionado.Password = txtPassword.Text.Trim();
                }

                MessageBox.Show("Lector actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _lectorSeleccionado = null;
                txtNombre.Clear();
                txtCorreo.Clear();
                txtPassword.Clear();
                HabilitarEdicion(false);
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _lectorSeleccionado = null;
            txtNombre.Clear();
            txtCorreo.Clear();
            txtPassword.Clear();
            HabilitarEdicion(false);
        }

        // Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
