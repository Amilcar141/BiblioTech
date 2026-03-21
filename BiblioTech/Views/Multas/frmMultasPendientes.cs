using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Multas
{
    public partial class frmMultasPendientes : Form
    {
        private MultaController _multaCtrl;

        public frmMultasPendientes()
        {
            InitializeComponent();
            _multaCtrl = new MultaController();
            ConfigurarTabla();
            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            CargarTabla();
        }

        private void ConfigurarTabla()
        {
            dgvMultasPendientes.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "ID"; colId.Visible = false;

            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.Name = "Monto"; colMonto.HeaderText = "Monto ($)"; colMonto.Width = 120;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado"; colEstado.HeaderText = "Estado"; colEstado.Width = 110;

            DataGridViewTextBoxColumn colFechaGen = new DataGridViewTextBoxColumn();
            colFechaGen.Name = "FechaGen"; colFechaGen.HeaderText = "Fecha Generacion"; colFechaGen.Width = 140;

            DataGridViewTextBoxColumn colDias = new DataGridViewTextBoxColumn();
            colDias.Name = "Dias"; colDias.HeaderText = "Dias Mora"; colDias.Width = 100;

            dgvMultasPendientes.Columns.Add(colId);
            dgvMultasPendientes.Columns.Add(colMonto);
            dgvMultasPendientes.Columns.Add(colEstado);
            dgvMultasPendientes.Columns.Add(colFechaGen);
            dgvMultasPendientes.Columns.Add(colDias);
        }

        private void CargarTabla()
        {
            dgvMultasPendientes.Rows.Clear();
            double total = 0;

            foreach (Multa m in _multaCtrl.ObtenerMultasPendientes())
            {
                dgvMultasPendientes.Rows.Add(
                    m.Id,
                    m.Monto.ToString("F2"),
                    m.Estado.ToString(),
                    m.FechaGeneracion.ToString("dd/MM/yyyy"),
                    _multaCtrl.CalcularDiasMora(m.FechaGeneracion)
                );
                total += m.Monto;
            }

            lblTotalValor.Text = "$ " + total.ToString("F2");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvMultasPendientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una multa de la tabla.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(dgvMultasPendientes.SelectedRows[0].Cells["ID"].Value.ToString());

            bool resultado = _multaCtrl.PagarMulta(id);

            if (resultado)
            {
                MessageBox.Show("Multa pagada correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
            }
            else
                MessageBox.Show("No se pudo procesar el pago.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int idMulta;
            if (!int.TryParse(txtIdMulta.Text, out idMulta) || idMulta <= 0)
            {
                MessageBox.Show("El ID debe ser un entero positivo.", "Validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double monto;
            if (!double.TryParse(txtMonto.Text, out monto) || monto <= 0)
            {
                MessageBox.Show("El monto debe ser un valor positivo.", "Validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool resultado = _multaCtrl.RegistrarMulta(idMulta, monto);

            if (resultado)
            {
                MessageBox.Show("Multa registrada correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdMulta.Clear();
                txtMonto.Clear();
                CargarTabla();
            }
            else
                MessageBox.Show("ID duplicado o datos invalidos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdMulta.Clear();
            txtMonto.Clear();
            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
