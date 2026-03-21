using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Multas
{
    public partial class FrmMultasPagadas : Form
    {
        private MultaController _multaCtrl;

        public FrmMultasPagadas()
        {
            InitializeComponent();
            _multaCtrl = new MultaController();
            ConfigurarTabla();
            lblFechaRegistroValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            CargarTabla();
        }

        private void ConfigurarTabla()
        {
            dgvMultasPagadas.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "ID"; colId.Visible = false;

            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.Name = "Monto"; colMonto.HeaderText = "Monto ($)"; colMonto.Width = 130;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado"; colEstado.HeaderText = "Estado"; colEstado.Width = 110;

            DataGridViewTextBoxColumn colFechaGen = new DataGridViewTextBoxColumn();
            colFechaGen.Name = "FechaGen"; colFechaGen.HeaderText = "Fecha Generacion"; colFechaGen.Width = 150;

            DataGridViewTextBoxColumn colFechaPago = new DataGridViewTextBoxColumn();
            colFechaPago.Name = "FechaPago"; colFechaPago.HeaderText = "Fecha Pago"; colFechaPago.Width = 130;

            dgvMultasPagadas.Columns.Add(colId);
            dgvMultasPagadas.Columns.Add(colMonto);
            dgvMultasPagadas.Columns.Add(colEstado);
            dgvMultasPagadas.Columns.Add(colFechaGen);
            dgvMultasPagadas.Columns.Add(colFechaPago);
        }

        private void CargarTabla()
        {
            dgvMultasPagadas.Rows.Clear();

            foreach (Multa m in _multaCtrl.ObtenerMultasPagadas())
            {
                dgvMultasPagadas.Rows.Add(
                    m.Id,
                    m.Monto.ToString("F2"),
                    m.Estado.ToString(),
                    m.FechaGeneracion.ToString("dd/MM/yyyy"),
                    m.FechaPago.ToString("dd/MM/yyyy")
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
