using System;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Perfil
{
    public partial class FrmEditarPerfil : Form
    {
        private readonly PerfilController _ctrl;
        private readonly string           _cuenta;

        public FrmEditarPerfil(SistemaLibreria sistema, string cuenta)
        {
            InitializeComponent();
            _ctrl   = new PerfilController(sistema);
            _cuenta = cuenta;
        }

        //  Carga datos 

        private void FrmEditarPerfil_Load(object sender, EventArgs e)
        {
            Lector lector = _ctrl.ObtenerLector(_cuenta);
            if (lector == null) return;

            txtNombre.Text   = lector.Nombre;
            txtCorreo.Text   = lector.Correo;
            txtPassword.Text = lector.Password;
        }

        // Guardar cambios

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string error = _ctrl.ActualizarDatos(
                _cuenta,
                txtNombre.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtPassword.Text);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Datos actualizados correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
