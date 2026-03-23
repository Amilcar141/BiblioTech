using BiblioTech.Controllers;
using BiblioTech.Views.Archivo;
using BiblioTech.Views.Ayuda;
using BiblioTech.Views.Multas;
using BiblioTech.Views.Prestamos;
using BiblioTech.Views.Reportes;
using BiblioTech.Views.Usuarios;
using System; 
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech.Views
{//7
    public partial class frmMenu : Form
    {
        private MultaController _multaCtrl = new MultaController();

        public frmMenu() { InitializeComponent(); }

        private void AbrirFormulario(Form formulario)
        {
            // Elimina el formulario actual del panel
            if (pnlMenu.Controls.Count > 0)
                pnlMenu.Controls.RemoveAt(0);

            // Configura el nuevo formulario para que se integre al panel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y muéstralo
            pnlMenu.Controls.Add(formulario);
            pnlMenu.Tag = formulario;
            formulario.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e) {
           
        }

        // ARCHIVO 
        private void nuevoPréstamoToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmRegistrarPrestamo());

        private void devolverLibroToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmDevolverLibro());

        private void renovarPréstamoToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmRenovarPrestamo());

        private void historialDePréstamosToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmHistorialPrestamos());

        // CATÁLOGO
        private void buscarLibroToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmBuscarLibro());

        private void agregarLibroToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmAgregarLibro());
        }
            

        private void editarLibroToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmEditarLibro());

        private void eliminarLibroToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmEliminarLibro());

        private void verDisponibilidadToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmVerDisponibilidad());

        private void gestiónCategoríaToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmGestionarCategorias());

        private void tsmiFavoritos_Click(object s, EventArgs e)
            => AbrirFormulario(new frmFavoritos());

        // USUARIOS 
        private void tsmiRegistrarUsuario_Click(object s, EventArgs e)
            => AbrirFormulario(new frmRegistrarUsuario());

        private void tsmiBuscarUsuario_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmBuscarUsuario());

        private void tsmiEditarDatos_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmEditarUsuario());

        //  PRÉSTAMOS 
        private void tsmiRegistrarPrestamo_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmRegistrarPrestamo());

        private void registrarDevoluciónToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmDevolverLibro());

        private void renovarPréstamoToolStripMenuItem1_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmRenovarPrestamo());

        private void préstamosVencidosToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmPrestamosVencidos());

        // MULTAS 
        private void tsmiMultasPendientes_Click(object s, EventArgs e)
            => AbrirFormulario(new frmMultasPendientes(_multaCtrl));

        private void multasPagadasToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmMultasPagadas(_multaCtrl));

        private void registrarPagoToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmRegistrarPago());

        //  REPORTES
        private void librosToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmLibrosMasPrestados());

        private void inventarioToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmInventario());

        //  CONFIGURACIÓN 
        private void usuarioDelSistemaToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmBuscarUsuario());

        private void permisosYRolesToolStripMenuItem_Click(object s, EventArgs e)
            => MessageBox.Show("Módulo de Permisos y Roles no disponible en esta versión.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void copiaDeSeguridadToolStripMenuItem_Click(object s, EventArgs e)
            => MessageBox.Show("Copia de seguridad no implementada en esta versión.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // AYUDA 
        private void manualDeUsuarioToolStripMenuItem_Click(object s, EventArgs e)
            => AbrirFormulario(new FrmManualUsuario());

        private void acercaDeToolStripMenuItem_Click(object s, EventArgs e)
        {
            using (FrmAcercaDe frm = new FrmAcercaDe())
                frm.ShowDialog();
        }

        private void soporteToolStripMenuItem_Click(object s, EventArgs e)
        {
            using (FrmSoporte frm = new FrmSoporte())
                frm.ShowDialog();
        }

        //  CERRAR SESIÓN
        private void cerrarSesiónToolStripMenuItem_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmPrincipal login = new frmPrincipal();
                login.Show();
                this.Close();
            }
        }

        private void crearMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearMulta multa = new FrmCrearMulta();
            AbrirFormulario(multa);
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte reporte = new FrmReporte();
            AbrirFormulario(reporte);
        }

        private void tsmiRegistrarPrestamo_Click_1(object sender, EventArgs e)
        {
            FrmRegistrarPrestamo frm = new FrmRegistrarPrestamo();

            AbrirFormulario(frm);
        }
    }
}
