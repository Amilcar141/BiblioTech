using System;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views
{
    public partial class frmPrestamo : Form 
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }
        //7
        private void txtIdLibro_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdLibro.Text, out int idBuscado))
                return;

            Libro libroEncontrado = LibroController.Inventario.Find(l => l.GetIdLibro() == idBuscado);

            if (libroEncontrado != null)
            {
                txtTitulo.Text = libroEncontrado.GetNombreLibro();
                txtAutor.Text  = libroEncontrado.GetAutor();
            }
            else
            {
                MessageBox.Show("El ID del libro no existe en el catálogo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Clear();
                txtAutor.Clear();
                txtIdLibro.Focus();
            }
        }

        private void frmPrestamo_Load(object sender, EventArgs e) { }
    }
}
