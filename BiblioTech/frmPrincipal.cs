using BiblioTech.Views;
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

namespace BiblioTech
{
    public partial class frmPrincipal : Form
    {
        private readonly LoginController controller = new LoginController();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string Cuenta = txtCuenta.Text.Trim();
            string Contrasenia = txtContrasenia.Text.Trim();

            if (string.IsNullOrEmpty(Cuenta) || string.IsNullOrEmpty(Contrasenia))
            {
                MessageBox.Show(
                    "Ingrese sus datos para acceder",   // mensaje
                    "Bibliotech",                        // título de la ventanita
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if ( controller.ValidarCredenciales(Cuenta, Contrasenia))
            {

                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Cuenta o contraseña incorrectos.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistros registro = new frmRegistros(controller.usuarios);
            registro.ShowDialog();
        }
    }
}
