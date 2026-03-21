using BiblioTech.Controllers;
using BiblioTech.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech.Views.Multas
{ 
    public partial class FrmMultasPagadas : Form//7
    {
        private MultaController multaController;

        public FrmMultasPagadas(MultaController multa)
        {
            InitializeComponent();
            multaController = multa;
        }

        private void FrmMultasPagadas_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvMultasPagadas.Rows.Clear();

            string filtro = txtBuscar.Text.Trim().ToLower();
            double totalRecaudado = 0;

            foreach (Multa m in multaController.ObtenerMultasPagadas())
            {
                if (!string.IsNullOrEmpty(filtro) &&
                    !m.Id.ToString().Contains(filtro))
                    continue;

                dgvMultasPagadas.Rows.Add(
                    m.Id,
                    m.FechaGeneracion.ToString("dd/MM/yyyy"),
                    m.FechaPago.ToString("dd/MM/yyyy"),
                    multaController.CalcularDiasMora(m.FechaGeneracion),
                    m.Monto.ToString("F2") + " Lps",
                    "Pagada"
                );
                totalRecaudado += m.Monto;
            }

            txtTotalRecaudado.Text = totalRecaudado.ToString("F2");
            txtCantidad.Text       = dgvMultasPagadas.Rows.Count.ToString();
            lblContador.Text       = "Total: " + dgvMultasPagadas.Rows.Count + " multa(s) pagada(s)";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
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
