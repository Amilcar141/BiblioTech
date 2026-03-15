using BiblioTech.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTech.Models;

namespace BiblioTech.Views.Multas
{
    public partial class frmMultasPendientes : Form
    {
        MultaController multaController;

        public frmMultasPendientes(MultaController multa)
        {
            InitializeComponent();
            multaController = multa;
        }

        // Cargar tabla
        private void CargarMultasPendientes()
        {
            dgvMultasPendientes.Rows.Clear();

            foreach (Multa m in multaController.ObtenerMultasPendientes())
            {
                dgvMultasPendientes.Rows.Add(
                    m.CodigoMulta,
                    "", // Usuario
                    m.FechaPago.ToString(),
                    multaController.CalcularDiasMora(m.FechaGeneracion),
                    m.Monto.ToString()
                );
            }
        }

        // Obtener el total a cobrar
        private decimal TotalCobrar()
        {
            decimal total = multaController.ObtenerTotalMultasPendientes();
            txtTotal.Text = total.ToString();
            return total;
        }

        private void frmMultasPendientes_Load(object sender, EventArgs e)
        {
            CargarMultasPendientes();
            TotalCobrar();
        }

        /*private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBusqueda.Text.Trim();
            dgvMultasPendientes.Rows.Clear();

            foreach (Multa m in multaController.ObtenerMultasPendientes())
            {
                if (m.Id.ToString().Contains(criterio) || m.Lector.Nombre.Contains(criterio))
                {
                    dgvMultasPendientes.Rows.Add(
                        m.Id,
                        "",
                        m.FechaPago.ToString(),
                        multaController.CalcularDiasMora(m.FechaGeneracion),
                        m.Monto.ToString()
                    );
                }
            }
        }
        */
    }
}
