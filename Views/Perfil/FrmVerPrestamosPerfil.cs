using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Perfil
{
    public partial class FrmVerPrestamosPerfil : Form
    {
        private readonly PerfilController _ctrl;
        private readonly string _cuenta;

        public FrmVerPrestamosPerfil(SistemaLibreria sistema, string cuenta)
        {
            InitializeComponent();
            _ctrl = new PerfilController(sistema);
            _cuenta = cuenta;
        }

        // Carga inicial de datos 

        private void FrmVerPrestamosPerfil_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Carga los préstamos del lector — solo lectura
        private void CargarTabla()
        {
            dgvPrestamos.Rows.Clear();

            List<Prestamo> prestamos = _ctrl.ObtenerPrestamosDelLector(_cuenta);

            foreach (Prestamo p in prestamos)
            {

                string titulo = "Sin libro";
                if (p.Libros != null && p.Libros.Count > 0 && p.Libros[0].Libro != null)
                    titulo = p.Libros[0].Libro.Titulo;

                // Usa Prestamo.Codigo (string) porque IdPrestamo es privado
                dgvPrestamos.Rows.Add(
                    p.Codigo,
                    titulo,
                    p.FechaInicio.ToShortDateString(),
                    p.FechaLimite.ToShortDateString(),
                    p.Estado.ToString()
                );
            }

            lblContador.Text = "Total: " + prestamos.Count + " préstamo(s)";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
