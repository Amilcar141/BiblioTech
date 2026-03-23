using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Multas//7
{
    public partial class FrmCrearMulta : Form
    {
        private MultaController multaCtrl = new MultaController();

        public FrmCrearMulta() 
        { 
            InitializeComponent(); 
        }

        private void FrmCrearMulta_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            ActualizarCodigo();
        }

        private void ActualizarCodigo()
        {
            Multa m = new Multa();

            // Muestra el codigo de la posible nueva multa
            string prefijo = "MLT-";
            string tipo = "";
            string id = m.ID.ToString("D4");

            // Obtener el tipo de multa del combo
            TipoMulta tipoMulta = (TipoMulta)cmbMotivo.SelectedItem;

            switch (tipoMulta)
            {
                case TipoMulta.Retraso:
                    tipo = "R";
                    break;
                case TipoMulta.Deterioro:
                    tipo = "D";
                    break;
                case TipoMulta.Perdida:
                    tipo = "P";
                    break;
                default:
                    break;
            }


            lblProximoId.Text = "ID de la nueva multa: " + $"{prefijo}{tipo}-{id}";
        }

        // Cargar el comboBox
        private void CargarComboBox()
        {
            cmbMotivo.Items.Clear();

            cmbMotivo.Items.Add("-- Seleccione --");

            // Añade al combobox los objetos del enum
            cmbMotivo.DataSource = Enum.GetValues(typeof(TipoMulta));
        }

        // Validaciones
        private bool ValidarFormulario()
        {
            // Validar tipo de multa
            if (cmbMotivo.SelectedItem == null || cmbMotivo.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un tipo de multa.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMotivo.BackColor = Color.LightPink;
                cmbMotivo.Focus();
                return false;
            }

            // Validar monto
            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("El monto no puede estar vacio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.BackColor = Color.LightPink;
                txtMonto.Focus();
                return false;
            }

            if (Double.Parse(txtMonto.Text) <= 0)
            {
                MessageBox.Show("Ingrese un número mayor a 0.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.BackColor = Color.LightPink;
                txtMonto.Focus();
                return false;
            }
            txtMonto.BackColor = SystemColors.Window;

            // Validar descripción
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripcion a la multa.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.BackColor = Color.LightPink;
                txtDescripcion.Focus();
                return false;
            }
            txtDescripcion.BackColor = SystemColors.Window;

            return true;
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
            string desc;
            decimal monto;
            TipoMulta tipoMulta;
            
            if (ValidarFormulario())
            {
                desc = txtDescripcion.Text.Trim();
                monto = decimal.Parse(txtMonto.Text);
                tipoMulta = (TipoMulta)cmbMotivo.SelectedItem;

                bool exito = multaCtrl.RegistrarMulta(desc, monto, tipoMulta);

                if (exito)
                {
                    MessageBox.Show(
                        "Multa creada correctamente.\n" +
                        "Monto: " + monto.ToString("F2") + " Lps\n" +
                        "Motivo: " + txtDescripcion.Text.Trim(),
                        "Multa Creada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ActualizarCodigo();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la multa. Verifique los datos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e) 
        { 
            LimpiarFormulario(); 
        }
        private void btnCerrar_Click(object sender, EventArgs e)  
        { 
            this.Close(); 
        }

        private void LimpiarFormulario()
        {
            txtMonto.Clear();
            txtDescripcion.Clear();
            cmbMotivo.SelectedIndex = 0;
            txtMonto.BackColor = SystemColors.Window;
            txtDescripcion.BackColor = SystemColors.Window;
            txtMonto.Focus();
        }
    }
}
