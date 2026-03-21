using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models; 

namespace BiblioTech.Views.Multas
{
    public partial class FrmCrearMulta : Form
    {
        private MultaController _ctrl = new MultaController();

        public FrmCrearMulta() { InitializeComponent(); }

        private void FrmCrearMulta_Load(object sender, EventArgs e)
        {
            ActualizarContador();
        }

        private void ActualizarContador()
        {
            int total = _ctrl.ObtenerMultas().Count;
            lblProximoId.Text = "ID de la nueva multa: " + (total + 1);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números, punto decimal y backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)8)
                e.Handled = true;

            // Solo un punto decimal
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
                e.Handled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar monto
            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                Marcar(txtMonto, "El monto no puede estar vacío.");
                return;
            }

            double monto;
            if (!double.TryParse(txtMonto.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out monto) || monto <= 0)
            {
                Marcar(txtMonto, "Ingrese un monto válido mayor que cero.");
                return;
            }
            txtMonto.BackColor = SystemColors.Window;

            // Validar descripción
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                Marcar(txtDescripcion, "Ingrese una descripción o motivo de la multa.");
                return;
            }
            txtDescripcion.BackColor = SystemColors.Window;

            // Generar ID único
            int nuevoId = _ctrl.ObtenerMultas().Count + 1;

            bool ok = _ctrl.RegistrarMulta(nuevoId, monto);

            if (ok)
            {
                MessageBox.Show(
                    "Multa #" + nuevoId + " creada correctamente.\n" +
                    "Monto: " + monto.ToString("F2") + " Lps\n" +
                    "Motivo: " + txtDescripcion.Text.Trim(),
                    "Multa Creada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
                ActualizarContador();
            }
            else
            {
                MessageBox.Show("No se pudo crear la multa. Verifique los datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) { LimpiarFormulario(); }
        private void btnCerrar_Click(object sender, EventArgs e)  { this.Close(); }

        private void LimpiarFormulario()
        {
            txtMonto.Clear();
            txtDescripcion.Clear();
            txtMonto.BackColor       = SystemColors.Window;
            txtDescripcion.BackColor = SystemColors.Window;
            txtMonto.Focus();
        }

        private void Marcar(Control ctrl, string mensaje)
        {
            ctrl.BackColor = Color.LightPink;
            ctrl.Focus();
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
