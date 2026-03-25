using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Multas
{
    public partial class FrmRegistrarPago : Form
    {
        // Controlador
        private MultaController _multaCtrl;

        // Constructor
        public FrmRegistrarPago(SistemaLibreria sistema)
        {
            InitializeComponent();
            _multaCtrl = new MultaController(sistema);
        }

        // Evento de carga del formulario
        private void FrmRegistrarPago_Load(object sender, EventArgs e)
        {
            CargarPendientes();
        }

        // Cargar multas pendientes
        private void CargarPendientes()
        {
            dgvMultas.Rows.Clear();

            try
            {
                foreach (Multa multa in _multaCtrl.ObtenerMultasPendientes())
                {
                    int diasMora = _multaCtrl.CalcularDiasMora(multa.FechaGeneracion);

                    dgvMultas.Rows.Add(
                        multa.CodigoMulta,
                        multa.FechaGeneracion.ToString("dd/MM/yyyy"),
                        diasMora,
                        multa.Monto.ToString("C"),
                        multa.Descripcion
                    );
                }

                decimal totalPendiente = _multaCtrl.ObtenerTotalMultasPendientes();
                lblTotal.Text = "Total pendiente: " + totalPendiente.ToString("C");
                lblContador.Text = "Multas pendientes: " + dgvMultas.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las multas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón pagar
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvMultas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una multa de la tabla para pagar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoMulta = dgvMultas.CurrentRow.Cells["colCodigo"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(codigoMulta))
            {
                MessageBox.Show("No se pudo obtener el código de la multa.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de que desea registrar el pago de la multa '{codigoMulta}'?",
                "Confirmar pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                if (_multaCtrl.PagarMulta(codigoMulta))
                {
                    MessageBox.Show("Pago registrado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPendientes();
                }
                else
                {
                    MessageBox.Show("No se pudo procesar el pago. Verifique el código de la multa.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarPendientes();
        }

        // Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
