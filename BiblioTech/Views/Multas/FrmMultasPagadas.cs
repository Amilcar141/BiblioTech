using BiblioTech.Controllers;
using BiblioTech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech.Views.Multas
{
    public partial class FrmMultasPagadas : Form
    {
        MultaController multaController;

        public FrmMultasPagadas(MultaController multa)
        {
            InitializeComponent();
            multaController = multa;
        }

        // Cargar tabla
        private void CargarMultasPagadas()
        {
            dgvMultasPagadas.Rows.Clear();

            foreach (Multa m in multaController.ObtenerMultasPendientes())
            {
                dgvMultasPagadas.Rows.Add(
                    m.CodigoMulta,
                    "", // Usuario
                    "",
                    multaController.CalcularDiasMora(m.FechaGeneracion),
                    m.Monto.ToString()
                );
            }
        }

        // Obtener el total a cobrar
        private decimal TotalCobrar()
        {
            decimal total = multaController.ObtenerTotalMultasPendientes();
            txtTotalMultas.Text = total.ToString();
            return total;
        }

        private void FrmMultasPagadas_Load(object sender, EventArgs e)
        {

        }
    }
}
