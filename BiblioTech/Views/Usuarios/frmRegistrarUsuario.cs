using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Usuarios
{
    public partial class frmRegistrarUsuario : Form
    {
        private UsuarioController usuarioController;

        public frmRegistrarUsuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Limpiar color de fondo cuando se hace focus en los campos
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = SystemColors.Window;
            }
        }

        // Evento del botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarUsuario();
            }
        }

        // Evento del botón Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // Evento del botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // Evento del botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento para mostrar/ocultar contraseña
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

        // Validar que todos los campos requeridos estén completos
        private bool ValidarCampos()
        {
            bool esValido = true;

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.BackColor = Color.LightPink;
                txtNombre.Focus();
                esValido = false;
            }
            else
            {
                txtNombre.BackColor = SystemColors.Window;
            }

            // Validar Apellidos
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Los apellidos son requeridos", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.BackColor = Color.LightPink;
                if (esValido)
                {
                    txtApellidos.Focus();
                    esValido = false;
                }
            }
            else
            {
                txtApellidos.BackColor = SystemColors.Window;
            }

            // Validar Correo
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El correo es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.BackColor = Color.LightPink;
                if (esValido)
                {
                    txtCorreo.Focus();
                    esValido = false;
                }
            }
            // Validar formato de correo
            else if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe ser válido (contener @)", 
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.BackColor = Color.LightPink;
                if (esValido)
                {
                    txtCorreo.Focus();
                    esValido = false;
                }
            }
            else
            {
                txtCorreo.BackColor = SystemColors.Window;
            }

            // Validar Contraseña
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("La contraseña es requerida", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.BackColor = Color.LightPink;
                if (esValido)
                {
                    txtPassword.Focus();
                    esValido = false;
                }
            }
            // Validar que la contraseña tenga al menos 6 caracteres
            else if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.BackColor = Color.LightPink;
                if (esValido)
                {
                    txtPassword.Focus();
                    esValido = false;
                }
            }
            else
            {
                txtPassword.BackColor = SystemColors.Window;
            }

            // Validar que se seleccione un rol
            if (!rbtnLector.Checked && !rbtnAdministrador.Checked)
            {
                MessageBox.Show("Debe seleccionar un rol", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esValido = false;
            }

            return esValido;
        }

        // Guardar el usuario en el controlador
        private void GuardarUsuario()
        {
            try
            {
                // Generar ID único (número)
                int id = GenerarIdUsuario();

                // Obtener el rol seleccionado
                Rol rolSeleccionado = rbtnLector.Checked ? Rol.Lector : Rol.Administrador;

                // Llamar al controlador para registrar el usuario
                bool resultado = usuarioController.RegistrarUsuario(
                    id,
                    txtNombre.Text.Trim() + " " + txtApellidos.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtPassword.Text,
                    rolSeleccionado
                );

                if (resultado)
                {
                    MessageBox.Show("¡Usuario registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("El usuario o correo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Generar ID único para el usuario (tipo int)
        private int GenerarIdUsuario()
        {
            // Generar ID basado en timestamp
            int id = (int)(DateTime.Now.Ticks % int.MaxValue);
            return id;
        }

        // Limpiar todos los campos del formulario
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
            btnVerPassword.Text = "○";
            
            // Restablecer colores a normal
            txtNombre.BackColor = SystemColors.Window;
            txtApellidos.BackColor = SystemColors.Window;
            txtCorreo.BackColor = SystemColors.Window;
            txtPassword.BackColor = SystemColors.Window;
            
            // Restablecer valores por defecto
            rbtnLector.Checked = true;
            rbtnActivo.Checked = true;

            // Enfocar el primer campo
            txtNombre.Focus();
        }
    }
}
