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

        /*
        // Metodo para abrir formularios
        private void AbrirFormulario(Form formulario)
        {
            // Si ya hay un formulario abierto, lo cerramos
            if (panel1.Controls.Count > 0)
                panel1.Controls[0].Dispose();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panel1.Controls.Add(formulario);
            panel1.Tag = formulario;
            formulario.Show();
        }
        */

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
