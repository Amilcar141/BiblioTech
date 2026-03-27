using System;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Perfil
{
    public partial class FrmPerfil : Form
    {
        private readonly PerfilController _ctrl;
        private readonly SistemaLibreria  _sistema;
        private readonly string           _cuenta;

        // Constructor 
        public FrmPerfil(SistemaLibreria sistema)
        {
            InitializeComponent();
            _sistema = sistema;
            _ctrl    = new PerfilController(sistema);
            //_cuenta  = SesionActual.UsuarioLogueado.Cuenta;
        }

        //  Carga inicial de datos  

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            Lector lector = _ctrl.ObtenerLector(_cuenta);
            if (lector == null) return;

            lblNombreVal.Text = lector.Nombre;
            lblCorreoVal.Text = lector.Correo;
            lblRolVal.Text    = lector.Rol.ToString();
            lblEstadoVal.Text = lector.Activo ? "Activo" : "Inactivo";
        }

        //  Botones del mini menú

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            FrmEditarPerfil editar = new FrmEditarPerfil(_sistema, _cuenta);
            editar.ShowDialog();
            CargarDatos(); // Refresca los datos al volver
        }

        private void btnVerLibros_Click(object sender, EventArgs e)
        {
            FrmVerLibrosPerfil frm = new FrmVerLibrosPerfil(_sistema, _cuenta);
            frm.ShowDialog();
        }

        private void btnVerPrestamos_Click(object sender, EventArgs e)
        {
            FrmVerPrestamosPerfil frm = new FrmVerPrestamosPerfil(_sistema, _cuenta);
            frm.ShowDialog();
        }

        private void btnVerMultas_Click(object sender, EventArgs e)
        {
            FrmVerMultasPerfil frm = new FrmVerMultasPerfil(_sistema, _cuenta);
            frm.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            frmFavoritos favoritos = new frmFavoritos();
            favoritos.ShowDialog();
        }
    }
}
