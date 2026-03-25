using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Usuarios
{
    public partial class FrmBuscarUsuario : Form
    {
        // Controlador
        private LectorController _lectorCtrl;

        // Constructor
        public FrmBuscarUsuario(SistemaLibreria sistema)
        {
            InitializeComponent();
            _lectorCtrl = new LectorController(sistema);
        }

        // Evento de carga del formulario
        private void FrmBuscarUsuario_Load(object sender, EventArgs e)
        {
            CargarTabla();
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

        // Evento cambio en búsqueda
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
