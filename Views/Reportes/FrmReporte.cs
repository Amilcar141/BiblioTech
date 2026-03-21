using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Views.Reportes 
{
    public partial class FrmReporte : Form//7
    {
        private LibroController    _libCtrl = new LibroController();
        private PrestamoController _preCtrl = new PrestamoController();
        private MultaController    _mulCtrl = new MultaController();
        private UsuarioController  _usrCtrl = new UsuarioController();

        public FrmReporte() { InitializeComponent(); }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            // Calcular totales 
            var libros      = _libCtrl.ObtenerTodos();
            int totalLibros = libros.Count;
            int disponibles = 0;
            int prestados   = 0;
            foreach (Libro lib in libros)
            {
                if (lib.GetDisponible()) disponibles++; else prestados++;
            }

            var historial = _preCtrl.Historial;
            int totPres   = historial.Count;
            int activos   = 0;
            int devueltos = 0;
            int vencidos  = 0;

            foreach (Prestamo p in historial)
            {
                if (p.Estado == EstadoPrestamo.Devuelto)           devueltos++;
                else if (p.EstaVencido())                          vencidos++;
                else if (p.Estado == EstadoPrestamo.Activo)        activos++;
            }

            int    pendientes     = _mulCtrl.ObtenerMultasPendientes().Count;
            int    pagadas        = _mulCtrl.ObtenerMultasPagadas().Count;
            double totalPendiente = _mulCtrl.ObtenerTotalMultasPendientes();
            double totalRecaudado = 0;
            foreach (Multa m in _mulCtrl.ObtenerMultasPagadas()) totalRecaudado += m.Monto;

            int totalUsuarios = _usrCtrl.ObtenerTotalUsuarios();
            int usrActivos    = _usrCtrl.ObtenerUsuariosActivos().Count;

            //  Actualizar cards resumen 
            lblResLibros.Text   = totalLibros.ToString();
            lblResDisp.Text     = disponibles.ToString();
            lblResPrest.Text    = prestados.ToString();
            lblResPrestTot.Text = totPres.ToString();
            lblResVenc.Text     = vencidos.ToString();
            lblResMultas.Text   = pendientes.ToString();
            lblResTotalMul.Text = totalPendiente.ToString("F2") + " Lps";

            if (vencidos   > 0) lblResVenc.ForeColor    = Color.Yellow;
            if (pendientes > 0) lblResMultas.ForeColor  = Color.Yellow;

            //  Generar texto del reporte 
            StringBuilder sb = new StringBuilder();
            string sep  = new string('=', 62);
            string sep2 = new string('-', 62);

            sb.AppendLine(sep);
            sb.AppendLine("  REPORTE GENERAL - BiblioTech");
            sb.AppendLine("  Generado: " + DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss"));
            sb.AppendLine(sep);

            // Catálogo
            sb.AppendLine();
            sb.AppendLine("  CATALOGO DE LIBROS");
            sb.AppendLine(sep2);
            sb.AppendLine(string.Format("  Total registrados  : {0}", totalLibros));
            sb.AppendLine(string.Format("  Disponibles        : {0}", disponibles));
            sb.AppendLine(string.Format("  Prestados          : {0}", prestados));

            // Préstamos
            sb.AppendLine();
            sb.AppendLine("  PRESTAMOS");
            sb.AppendLine(sep2);
            sb.AppendLine(string.Format("  Total registrados  : {0}", totPres));
            sb.AppendLine(string.Format("  Activos (vigentes) : {0}", activos));
            sb.AppendLine(string.Format("  Devueltos          : {0}", devueltos));
            sb.AppendLine(string.Format("  Vencidos           : {0}", vencidos));

            if (activos > 0 || vencidos > 0)
            {
                sb.AppendLine();
                sb.AppendLine("  Pendientes de devolucion:");
                foreach (Prestamo p in historial)
                {
                    if (p.Estado == EstadoPrestamo.Devuelto) continue;
                    string estado  = p.EstaVencido() ? "VENCIDO" : "Activo";
                    string lector  = p.Lector != null ? p.Lector.Nombre          : "-";
                    string libro   = p.Libro  != null ? p.Libro.GetNombreLibro() : "-";
                    sb.AppendLine(string.Format("    #{0,-4} {1,-22} {2,-24} Lim: {3}  [{4}]",
                        p.IdPrestamo, lector, libro,
                        p.FechaLimite.ToString("dd/MM/yyyy"), estado));
                }
            }

            // Multas
            sb.AppendLine();
            sb.AppendLine("  MULTAS");
            sb.AppendLine(sep2);
            sb.AppendLine(string.Format("  Pendientes de pago : {0}", pendientes));
            sb.AppendLine(string.Format("  Total a cobrar     : {0:F2} Lps", totalPendiente));
            sb.AppendLine(string.Format("  Pagadas            : {0}", pagadas));
            sb.AppendLine(string.Format("  Total recaudado    : {0:F2} Lps", totalRecaudado));

            if (pendientes > 0)
            {
                sb.AppendLine();
                sb.AppendLine("  Multas pendientes:");
                foreach (Multa m in _mulCtrl.ObtenerMultasPendientes())
                {
                    sb.AppendLine(string.Format("    #{0,-4} {1,-22} {2,-24} {3:F2} Lps  [{4} dias]",
                        m.Id,
                        m.NombreUsuario,
                        m.TituloLibro,
                        m.Monto,
                        m.DiasMora > 0 ? m.DiasMora : _mulCtrl.CalcularDiasMora(m.FechaGeneracion)));
                }
            }

            // Usuarios
            sb.AppendLine();
            sb.AppendLine("  USUARIOS");
            sb.AppendLine(sep2);
            sb.AppendLine(string.Format("  Registrados        : {0}", totalUsuarios));
            sb.AppendLine(string.Format("  Activos            : {0}", usrActivos));
            sb.AppendLine(string.Format("  Inactivos          : {0}", totalUsuarios - usrActivos));

            sb.AppendLine();
            sb.AppendLine(sep);
            sb.AppendLine("  FIN DEL REPORTE");
            sb.AppendLine(sep);

            rtbReporte.Text = sb.ToString();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) { GenerarReporte(); }
        private void btnCerrar_Click(object sender, EventArgs e)    { this.Close(); }
    }
}
