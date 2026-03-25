using BiblioTech.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech
{//7
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            BiblioTech.Models.SistemaLibreria sistema = new BiblioTech.Models.SistemaLibreria();
            CargarDatos.CargarDatosIniciales(sistema);
            frmMenu menu = new frmMenu(sistema);
            menu.Show();
            this.Hide();
        }
    }
}
