using BiblioTech.Controllers;
using BiblioTech.Models;
using BiblioTech.Views.Archivo;
using BiblioTech.Views.Ayuda;
using BiblioTech.Views.Multas;
using BiblioTech.Views.Perfil;
using BiblioTech.Views.Prestamos;
using BiblioTech.Views.Reportes;
using BiblioTech.Views.Usuarios;
using System; 
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech.Views
{
    public partial class frmMenu : Form
    {
        private SistemaLibreria _sistema;

        public frmMenu(SistemaLibreria sistema)
        {
            InitializeComponent();
            _sistema = sistema;
        }

        private void AbrirFormulario(Form formulario)
        {
            // Elimina el formulario actual del panel
            if (pnlMenu.Controls.Count > 0)
            {
                for (int i = pnlMenu.Controls.Count - 1; i >= 0; i--)
                {
                    if (pnlMenu.Controls[i] is Form)
                        pnlMenu.Controls.RemoveAt(i);
                }
            }

            // Configura el nuevo formulario para que se integre al panel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y muéstralo
            pnlMenu.Controls.Add(formulario);
            formulario.BringToFront();
            pnlMenu.Tag = formulario;
            formulario.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e) {
            AmpliarVentana();
        }

        private void AmpliarVentana()
        {
            // Configurar texto para que crezca con el panel
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // Configurar imagen para que crezca con el panel
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(3, label1.Bottom + 10);
            pictureBox1.Width = pnlMenu.Width - 6;
            pictureBox1.Height = pnlMenu.Height - pictureBox1.Location.Y - 3;

            // Configurar el panel para que sea completamente responsivo
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        // ARCHIVO 
        private void nuevoPréstamoToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmRegistrarPrestamo(_sistema));
        }

        private void devolverLibroToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmDevolverLibro(_sistema));
        }

        private void renovarPréstamoToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmRenovarPrestamo(_sistema));
        }

        private void historialDePréstamosToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmHistorialPrestamos(_sistema));
        }

        // CATÁLOGO
        private void buscarLibroToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmBuscarLibro(_sistema));
        }

        private void agregarLibroToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmAgregarLibro(_sistema));
        }
            

        private void editarLibroToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmEditarLibro(_sistema));
        }

        private void eliminarLibroToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmEliminarLibro(_sistema));
        }

        private void verDisponibilidadToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmVerDisponibilidad(_sistema));
        }

        private void gestiónCategoríaToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmGestionarCategorias(_sistema));
        }

        private void tsmiFavoritos_Click(object s, EventArgs e)
        {
            AbrirFormulario(new frmFavoritos());
        }

        // USUARIOS 
        private void tsmiRegistrarUsuario_Click(object s, EventArgs e)
        {
            AbrirFormulario(new frmRegistrarUsuario(_sistema));
        }


        private void tsmiBuscarUsuario_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmBuscarUsuario(_sistema));
        }

        private void tsmiEditarDatos_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmEditarUsuario(_sistema));
        }

        //  PRÉSTAMOS 
        private void tsmiRegistrarPrestamo_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmRegistrarPrestamo(_sistema));
        }

        private void registrarDevoluciónToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmDevolverLibro(_sistema));
        }

        private void renovarPréstamoToolStripMenuItem1_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmRenovarPrestamo(_sistema));
        }

        private void préstamosVencidosToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamosVencidos(_sistema));
        }

        // MULTAS 
        private void tsmiMultasPendientes_Click(object s, EventArgs e)
        {
            AbrirFormulario(new frmMultasPendientes(_sistema));
        }

        private void multasPagadasToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmMultasPagadas(_sistema));
        }

        private void registrarPagoToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmRegistrarPago(_sistema));
        }

        //  REPORTES
        private void librosToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmLibrosMasPrestados(_sistema));
        }

        private void inventarioToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmInventario(_sistema));
        }

        //  CONFIGURACIÓN 
        private void usuarioDelSistemaToolStripMenuItem_Click(object s, EventArgs e)
        {
            AbrirFormulario(new FrmBuscarUsuario(_sistema));
        }

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
            FrmCrearMulta multa = new FrmCrearMulta(_sistema);
            AbrirFormulario(multa);
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte reporte = new FrmReporte();
            AbrirFormulario(reporte);
        }

        private void tsmiRegistrarPrestamo_Click_1(object sender, EventArgs e)
        {
            FrmRegistrarPrestamo frm = new FrmRegistrarPrestamo(_sistema);

            AbrirFormulario(frm);
        }

        private void mnuMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = new FrmPerfil(_sistema);
            AbrirFormulario(perfil);

        }
    }
}
