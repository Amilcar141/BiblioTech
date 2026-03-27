using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Usuarios
{
    public partial class frmRegistrarUsuario : Form
    {
        // Controladores
        private LectorController _lectorCtrl;

        // Constructor
        public frmRegistrarUsuario(SistemaLibreria sistema)
        {
            InitializeComponent();
            _lectorCtrl = new LectorController(sistema);
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

        // Botón guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombreCompleto = txtNombre.Text.Trim() + " " + txtApellidos.Text.Trim();

            try
            {
                // Crear nuevo lector
                Lector nuevoLector = new Lector(
                    nombreCompleto,
                    txtCorreo.Text.Trim(),
                    txtPassword.Text.Trim(),
                    true);

                // Registrar lector
                bool ok = _lectorCtrl.AgregarLector(nuevoLector);

                if (ok)
                {
                    MessageBox.Show("Lector registrado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con ese correo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombre.Focus();
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

        // Validar campos del formulario
        private bool ValidarCampos()
        {
            // Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                Marcar(txtNombre, "El nombre es requerido.");
                return false;
            }
            txtNombre.BackColor = SystemColors.Window;

            // Apellidos
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                Marcar(txtApellidos, "Los apellidos son requeridos.");
                return false;
            }
            txtApellidos.BackColor = SystemColors.Window;

            // Correo
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                Marcar(txtCorreo, "Ingrese un correo válido (debe contener @).");
                return false;
            }
            txtCorreo.BackColor = SystemColors.Window;

            // Contraseña
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                Marcar(txtPassword, "La contraseña debe tener al menos 6 caracteres.");
                return false;
            }
            txtPassword.BackColor = SystemColors.Window;

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
