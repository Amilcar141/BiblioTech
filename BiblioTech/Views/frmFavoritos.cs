using BiblioTech.Models;
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
    public partial class frmFavoritos : Form
    {
        private FavoritoController controller = new FavoritoController();

        public frmFavoritos()
        {
            InitializeComponent();
        }

        private void frmFavoritos_Load(object sender, EventArgs e)
        {
            // Comentario
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtGenero.Clear();
            txtISBN.Clear();
            txtAliasUsuario.Clear();
            txtISBN.Clear();

            txtTitulo.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = dgvFavoritos.Rows.Count + 1;

            // Validar ISBN antes de crear el objeto
            if (!int.TryParse(txtISBN.Text, out int isbn))
            {
                MessageBox.Show("El ISBN debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Favorito f = new Favorito(
                id,
                isbn,
                txtAliasUsuario.Text.Trim(),
                txtTitulo.Text.Trim(),
                txtAutor.Text.Trim(),
                dtpFecha.Value.ToShortDateString(),
                txtGenero.Text.Trim()
            );

            string mensaje;
            if (!controller.Agregar(f, out mensaje))
            {
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ActualizarTabla();
            LimpiarCampos();
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarTabla()
        {

            dgvFavoritos.Rows.Clear();

            foreach (Favorito f in controller.ObtenerFavoritos())
            {

                dgvFavoritos.Rows.Add(

                    f.idFavorito,
                    f.ISBN,
                    f.AliasUsuario,
                    f.Titulo,
                    f.Autor,
                    f.Anio,
                    f.genero

                );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFavoritos.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgvFavoritos.SelectedRows[0].Cells["idFavorito"].Value);
                DialogResult r = MessageBox.Show("¿Seguro que quieres eliminar este favorito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                    controller.Eliminar(id);

                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Seleccione un favorito para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grpFavoritos_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}