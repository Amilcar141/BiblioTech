using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Usuarios
{ //7
    public partial class frmRegistrarUsuario : Form
    {
        private UsuarioController _ctrl = new UsuarioController();

        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        // Mostrar/ocultar contraseña
        private void btnVerPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnVerPassword.Text = "●";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnVerPassword.Text = "○";
            }
        }

        // Limpiar color al entrar en un campo
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null) txt.BackColor = SystemColors.Window;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Rol rol = rbtnLector.Checked ? Rol.Lector : Rol.Administrador;

            string nombreCompleto = txtNombre.Text.Trim() + " " + txtApellidos.Text.Trim();

            // el controller asigna el ID con _nextId
            bool ok = _ctrl.RegistrarUsuario(
                0,                          
                nombreCompleto,
                txtCorreo.Text.Trim(),
                txtPassword.Text,
                rol);

            if (ok)
            {
                MessageBox.Show("Usuario registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Ya existe un usuario con ese correo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)   { 
           
            LimpiarFormulario(); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            
            LimpiarFormulario(); 
        }
        private void btnCancelar_Click(object sender, EventArgs e){
            
            this.Close(); 
        }

        private bool ValidarCampos()
        {
            // Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                Marcar(txtNombre, "El nombre es requerido."); return false;
            }
            txtNombre.BackColor = SystemColors.Window;

            // Apellidos
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                Marcar(txtApellidos, "Los apellidos son requeridos."); return false;
            }
            txtApellidos.BackColor = SystemColors.Window;

            // Correo
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                Marcar(txtCorreo, "Ingrese un correo válido (debe contener @)."); return false;
            }
            txtCorreo.BackColor = SystemColors.Window;

            // Contraseña
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                Marcar(txtPassword, "La contraseña debe tener al menos 6 caracteres."); return false;
            }
            txtPassword.BackColor = SystemColors.Window;

            // Rol
            if (!rbtnLector.Checked && !rbtnAdministrador.Checked)
            {
                MessageBox.Show("Seleccione un rol.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Marcar(TextBox txt, string mensaje)
        {
            txt.BackColor = Color.LightPink;
            txt.Focus();
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
            btnVerPassword.Text = "○";
            txtNombre.BackColor    = SystemColors.Window;
            txtApellidos.BackColor = SystemColors.Window;
            txtCorreo.BackColor    = SystemColors.Window;
            txtPassword.BackColor  = SystemColors.Window;
            rbtnLector.Checked = true;
            rbtnActivo.Checked = true;
            txtNombre.Focus();
        }
    }
}
