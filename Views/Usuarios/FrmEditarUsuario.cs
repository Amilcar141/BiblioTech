using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Usuarios
{ //7
    public partial class FrmEditarUsuario : Form
    {
        private UsuarioController _ctrl = new UsuarioController();
        private int _idSeleccionado = 0;

        public FrmEditarUsuario() { InitializeComponent(); }

        private void FrmEditarUsuario_Load(object sender, EventArgs e) { CargarTabla(); HabilitarEdicion(false); }

        private void CargarTabla()
        {
            dgvUsuarios.Rows.Clear();
            string t = txtBuscar.Text.Trim().ToLower();
            foreach (Usuario u in _ctrl.ObtenerTodosUsuarios())
            {
                if (!string.IsNullOrEmpty(t) &&
                    !u.Nombre.ToLower().Contains(t) &&
                    !u.Correo.ToLower().Contains(t)) continue;
                int fila = dgvUsuarios.Rows.Add(u.Id, u.Nombre, u.Correo, u.Rol.ToString(),
                    u.Activo ? "Activo" : "Inactivo");
                if (!u.Activo) dgvUsuarios.Rows[fila].DefaultCellStyle.ForeColor = Color.Gray;
            }
            lblContador.Text = "Total: " + dgvUsuarios.Rows.Count + " usuario(s)";
        }

        private void HabilitarEdicion(bool activo)
        {
            txtNombre.Enabled    = activo;
            txtCorreo.Enabled    = activo;
            txtPassword.Enabled  = activo;
            btnGuardar.Enabled   = activo;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { CargarTabla(); }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _idSeleccionado  = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["colEUId"].Value);
            Usuario u        = _ctrl.ObtenerUsuario(_idSeleccionado);
            if (u == null) return;
            txtNombre.Text   = u.Nombre;
            txtCorreo.Text   = u.Correo;
            txtPassword.Text = "";
            HabilitarEdicion(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            { MessageBox.Show("Haga doble clic en un usuario de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            { MessageBox.Show("Ingrese un correo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string pass = string.IsNullOrWhiteSpace(txtPassword.Text)
                ? _ctrl.ObtenerUsuario(_idSeleccionado)?.Password ?? ""
                : txtPassword.Text;

            bool ok = _ctrl.ActualizarUsuario(_idSeleccionado, txtNombre.Text.Trim(), txtCorreo.Text.Trim(), pass);
            if (ok)
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _idSeleccionado = 0; txtNombre.Clear(); txtCorreo.Clear(); txtPassword.Clear();
                HabilitarEdicion(false); CargarTabla();
            }
            else
                MessageBox.Show("No se pudo actualizar. El correo puede estar en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        { _idSeleccionado = 0; txtNombre.Clear(); txtCorreo.Clear(); txtPassword.Clear(); HabilitarEdicion(false); }

        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
