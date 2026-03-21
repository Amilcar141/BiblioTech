using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Usuarios
{ 
    public partial class FrmBuscarUsuario : Form
    {
        private UsuarioController _ctrl = new UsuarioController();

        public FrmBuscarUsuario() { InitializeComponent(); }

        private void FrmBuscarUsuario_Load(object sender, EventArgs e) { CargarTabla(); }

        private void CargarTabla()
        {
            dgvUsuarios.Rows.Clear();
            string t = txtBuscar.Text.Trim().ToLower();
            foreach (Usuario u in _ctrl.ObtenerTodosUsuarios())
            {
                if (!string.IsNullOrEmpty(t) &&
                    !u.Nombre.ToLower().Contains(t) &&
                    !u.Correo.ToLower().Contains(t)) continue;

                int fila = dgvUsuarios.Rows.Add(
                    u.Id, u.Nombre, u.Correo,
                    u.Rol.ToString(),
                    u.Activo ? "Activo" : "Inactivo");

                if (!u.Activo)
                    dgvUsuarios.Rows[fila].DefaultCellStyle.ForeColor = Color.Gray;
            }
            lblContador.Text = "Total: " + dgvUsuarios.Rows.Count + " usuario(s)";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { CargarTabla(); }
        private void btnLimpiar_Click(object sender, EventArgs e) { txtBuscar.Clear(); }
        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
