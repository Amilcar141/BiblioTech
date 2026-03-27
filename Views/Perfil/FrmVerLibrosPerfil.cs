using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Perfil
{
    public partial class FrmVerLibrosPerfil : Form
    {
        private readonly PerfilController _ctrl;

        public FrmVerLibrosPerfil(SistemaLibreria sistema, string cuenta)
        {
            InitializeComponent();
            _ctrl = new PerfilController(sistema);
        }

        // Carga inicial 

        private void FrmVerLibrosPerfil_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Carga catálogo completo — solo lectura, sin posibilidad de editar
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            List<Libro> libros = _ctrl.ObtenerTodosLosLibros();

            foreach (Libro lib in libros)
            {
               
                string autor     = lib.Autor     != null ? lib.Autor.NombreCompleto()       : "—";
                string categoria = lib.Categoria != null ? lib.Categoria.NombreCategoria    : "—";
                string editorial = lib.Editorial != null ? lib.Editorial.Nombre             : "—";

                dgvLibros.Rows.Add(lib.Titulo, autor, categoria, editorial, "Disponible");
            }

            lblContador.Text = "Total: " + libros.Count + " libro(s)";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
