using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech.Views
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        // Metodo para abrir formularios
        private void AbrirFormulario(Form formulario)
        {
            // Si ya hay un formulario abierto, lo cerramos
            if (pnlMenu.Controls.Count > 0)
                pnlMenu.Controls.RemoveAt(0);

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlMenu.Controls.Add(formulario);
            pnlMenu.Tag = formulario;

            // Abre el formulario frente a la imagen de fondo
            formulario.BringToFront();
            formulario.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        // Antes de añadir un nuevo formulario renombre el método para que sea más descriptivo
        private void tsmiRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            frmPrestamo prestamo = new frmPrestamo();

            AbrirFormulario(prestamo);
        }

        
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal login = new frmPrincipal();
            login.Show();
            this.Close();
        }
    }
}
