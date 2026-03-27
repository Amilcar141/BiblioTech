using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Perfil
{
    public partial class FrmVerMultasPerfil : Form
    {
        private readonly PerfilController _ctrl;
        private readonly string _cuenta;

        public FrmVerMultasPerfil(SistemaLibreria sistema, string cuenta)
        {
            InitializeComponent();
            _ctrl = new PerfilController(sistema);
            _cuenta = cuenta;
        }

        //  Carga inicial 

        private void FrmVerMultasPerfil_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Carga las multas del lector — solo lectura
        private void CargarTabla()
        {
            dgvMultas.Rows.Clear();

            List<Multa> multas = _ctrl.ObtenerMultasDelLector(_cuenta);
            decimal pendiente = 0;

            foreach (Multa m in multas)
            {
                if (m.EstaPendiente())
                    pendiente += m.Monto;

                // Días de mora calculados desde FechaGeneracion 
                int diasMora = (int)(DateTime.Now - m.FechaGeneracion).TotalDays;
                if (diasMora < 0) diasMora = 0;

                // Usa CodigoMulta y Descripcion 
                dgvMultas.Rows.Add(
                    m.CodigoMulta,
                    m.Descripcion,
                    m.Monto.ToString("F2"),
                    diasMora,
                    m.FechaGeneracion.ToShortDateString(),
                    m.EstaPendiente() ? "Pendiente" : "Pagada"
                );
            }

            lblContador.Text = "Total: " + multas.Count +
                               " multa(s)   |   Pendiente: $" + pendiente.ToString("F2");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
