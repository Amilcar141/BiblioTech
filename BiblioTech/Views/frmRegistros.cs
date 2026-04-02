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
using BiblioTech.Models;

namespace BiblioTech.Views
{
    public partial class frmRegistros : Form
    {
        private readonly RegistroController controller;

        public frmRegistros(List<Usuario> usuarios)
        {
            InitializeComponent();
            controller = new RegistroController(usuarios);

            cmbRol.Text = "Selecciona un rol...";
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Bibliotecario");
            cmbRol.Items.Add("Lector");
            cmbRol.SelectedIndex = 0;
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                string Nombres = txtNombres.Text.Trim();
                string Apellidos = txtApellidos.Text.Trim();
                string Cuenta = txtCuenta.Text.Trim();
                string Correo = txtCorreo.Text.Trim();
                string Rol = cmbRol.SelectedItem.ToString();

                // Validar campos vacíos
                if (string.IsNullOrEmpty(Nombres) ||
                    string.IsNullOrEmpty(Apellidos) ||
                    string.IsNullOrEmpty(Cuenta) ||
                    string.IsNullOrEmpty(Correo))
                {
                    MessageBox.Show(
                        "Por favor complete todos los campos.",
                        "Bibliotech",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!Correo.Contains("@"))
                {
                    MessageBox.Show("El correo debe contener @.",
                                    "Bibliotech",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Registrar usuario (contraseña = número de cuenta por defecto)
                bool registrado = controller.Registrar(
                    Nombres, Apellidos, Cuenta,
                    Correo, Rol, Cuenta);

                if (registrado)
                {
                    MessageBox.Show(
                        $"¡Registro exitoso!\nSu contraseña inicial es su número de cuenta: {Cuenta}",
                        "Bibliotech",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close(); // regresa al login
                }
                else
                {
                    MessageBox.Show(
                        "Ese número de cuenta ya está registrado.",
                        "Cuenta duplicada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }





        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
