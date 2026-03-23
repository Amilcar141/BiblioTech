using BiblioTech.Controllers;
using BiblioTech.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech.Views.Multas
{
    public partial class frmMultasPendientes : Form
    {
        private MultaController multaCtrl;

        public frmMultasPendientes(MultaController multa)
        {
            InitializeComponent();
            multaCtrl = multa;
        }

        private void frmMultasPendientes_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvMultasPendientes.Rows.Clear();

            string filtro = txtBuscar.Text.Trim().ToLower();

            foreach (Multa m in multaCtrl.ObtenerMultasPendientes())
            {
                int dias = multaCtrl.CalcularDiasMora(m.FechaGeneracion);
                
                int fila = dgvMultasPendientes.Rows.Add(
                    m.CodigoMulta,
                    m.FechaGeneracion.ToString("dd/MM/yy"),
                    dias,
                    m.Monto.ToString("F2") + " Lps",
                    m.Estado.ToString()
                );

                // Colorear fila: más de 30 días en rojo intenso
                if (dias > 30)
                    dgvMultasPendientes.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                else if (dias > 10)
                    dgvMultasPendientes.Rows[fila].DefaultCellStyle.ForeColor = Color.OrangeRed;
            }

            // Actualizar totales
            decimal total = multaCtrl.ObtenerTotalMultasPendientes();
            txtTotal.Text    = total.ToString("F2");
            lblContador.Text = "Total: " + dgvMultasPendientes.Rows.Count + " multa(s) pendiente(s)";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvMultasPendientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una multa de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //int id = Convert.ToInt32(dgvMultasPendientes.CurrentRow.Cells["colMPId"].Value);
            string codigo = dgvMultasPendientes.CurrentRow.Cells["colMPCodigo"].Value.ToString();

            if (MessageBox.Show("¿Registrar el pago de la multa #" + codigo + "?",
                "Confirmar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (multaCtrl.PagarMulta(codigo))
            {
                MessageBox.Show("Pago registrado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
            }
            else
            {
                MessageBox.Show("No se pudo procesar el pago.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
