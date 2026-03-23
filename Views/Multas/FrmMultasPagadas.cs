using BiblioTech.Controllers;
using BiblioTech.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech.Views.Multas
{ 
    public partial class FrmMultasPagadas : Form//7
    {
        private MultaController multaCtrl;

        public FrmMultasPagadas(MultaController multa)
        {
            InitializeComponent();
            multaCtrl = multa;
        }

        private void FrmMultasPagadas_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvMultasPagadas.Rows.Clear();

            string filtro = txtBuscar.Text.Trim().ToLower();
            decimal totalRecaudado = 0;

            foreach (Multa m in multaCtrl.ObtenerMultasPagadas())
            {
                dgvMultasPagadas.Rows.Add(
                    m.CodigoMulta,
                    m.FechaGeneracion.ToString("dd/MM/yy"),
                    m.FechaPago.ToString("dd/MM/yy"),
                    multaCtrl.CalcularDiasMora(m.FechaGeneracion),
                    m.Lector.Nombre,
                    m.Monto.ToString("F2") + " Lps"
                );

                totalRecaudado += m.Monto;
            }

            txtTotalRecaudado.Text = totalRecaudado.ToString("F2");
            txtCantidad.Text = dgvMultasPagadas.Rows.Count.ToString();
            lblContador.Text = "Total: " + dgvMultasPagadas.Rows.Count + " multa(s) pagada(s)";
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
