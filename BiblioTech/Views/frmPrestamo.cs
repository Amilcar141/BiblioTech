using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTech.Controllers;

namespace BiblioTech.Views
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void txtIdLibro_Leave(object sender, EventArgs e)
        {
            // Evento que se activa cuando el usuario sale del cuadro de texto del ID del Libro

            // 1. Validar que el campo no esté vacío y que sea un número
            if (int.TryParse(txtIdLibro.Text, out int idBuscado))
            {
                // 2. Buscar el libro en la lista del controlador
                // Usamos el inventario que definimos en LibroController
                var libroEncontrado = LibroController.Inventario.Find(l => l.idLibro == idBuscado);

                if (libroEncontrado != null)
                {
                    // 3. Si existe, llenar los campos de texto automáticamente
                    txtTitulo.Text = libroEncontrado.Titulo;
                    txtAutor.Text = libroEncontrado.Autor;

                   }
                else
                {
                    MessageBox.Show("El ID del libro no existe en el catálogo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCamposLibro();
                }
            }
        }

        // Método auxiliar para limpiar si el ID es incorrecto
        private void LimpiarCamposLibro()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtIdLibro.Focus();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
    }

