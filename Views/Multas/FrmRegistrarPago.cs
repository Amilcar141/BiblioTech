using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Multas
{ //7
    public partial class FrmRegistrarPago : Form
    {
        private MultaController _ctrl = new MultaController();

        public FrmRegistrarPago() { InitializeComponent(); }

        private void FrmRegistrarPago_Load(object sender, EventArgs e) { CargarPendientes(); }

        private void CargarPendientes()
        {
            dgvMultas.Rows.Clear();
            foreach (Multa m in _ctrl.ObtenerMultasPendientes())
            {
                dgvMultas.Rows.Add(m.Id, m.FechaGeneracion.ToString("dd/MM/yyyy"),
                    _ctrl.CalcularDiasMora(m.FechaGeneracion), m.Monto.ToString("F2") + " Lps");
            }
            double total = _ctrl.ObtenerTotalMultasPendientes();
            lblTotal.Text  = "Total pendiente: " + total.ToString("F2") + " Lps";
            lblContador.Text = "Multas pendientes: " + dgvMultas.Rows.Count;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvMultas.CurrentRow == null)
            { MessageBox.Show("Seleccione una multa de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int id = Convert.ToInt32(dgvMultas.CurrentRow.Cells["colPMId"].Value);
            if (MessageBox.Show("¿Registrar el pago de la multa #" + id + "?",
                "Confirmar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            if (_ctrl.PagarMulta(id))
            {
                MessageBox.Show("Pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPendientes();
            }
            else
                MessageBox.Show("No se pudo procesar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRefrescar_Click(object sender, EventArgs e) { CargarPendientes(); }
        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
