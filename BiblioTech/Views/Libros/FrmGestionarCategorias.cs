using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views
{
    public partial class FrmGestionarCategorias : Form
    {
        // Controlador
        private CategoriaController categoriaController;

        // Constructor
        public FrmGestionarCategorias(CategoriaController controller)
        {
            InitializeComponent();
            categoriaController =  controller;

            CargarTabla();
            HabilitarEdicion(false);
        }

        
        private void CargarTabla()
        {
            dgvCategorias.Rows.Clear();

            List<Categoria> categorias = categoriaController.ObtenerTodas();

            foreach (Categoria cat in categorias)
            {
                dgvCategorias.Rows.Add(
                    cat.CodigoCategoria,
                    cat.NombreCategoria
                );
            }
            
            lblContador.Text = "Total: " + dgvCategorias.Rows.Count + " categoría(s)";
        }

        // Habilitar o deshabilitar botones de edicion
        private void HabilitarEdicion(bool activo)
        {
            btnEditar.Enabled   = activo;
            btnEliminar.Enabled = activo;
        }

        
        private void Limpiar()
        {
            txtNombreCategoria.Clear();
            txtDescripcion.Clear();
            HabilitarEdicion(false);
        }

        // Seleccion de la categoria en la tabla
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
                return;

            txtIdCategoria.Text     = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            txtNombreCategoria.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();

            HabilitarEdicion(true);
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string nombreCategoria = txtNombreCategoria.Text;
            string descripcion = txtDescripcion.Text;

            bool resultado = categoriaController.Guardar(nombreCategoria, descripcion);

            if (resultado)
            {
                MessageBox.Show("Se registro lacategoria", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarTabla();
            }
            else
            {
                MessageBox.Show("Error", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoría para editar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoCategoria = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            string nombreCategoria = txtNombreCategoria.Text;
            string descripcion = txtDescripcion.Text;

            bool resultado = categoriaController.Actualizar(codigoCategoria, nombreCategoria, descripcion);

            if (resultado)
            {
                MessageBox.Show("Se actualizó la categoría", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarTabla();
            }
            else
            {
                MessageBox.Show("Error al actualizar la categoría", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
    
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoría para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string codigoCategoria = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                bool resultadoEliminar = categoriaController.Eliminar(codigoCategoria);

                if (resultadoEliminar)
                {
                    MessageBox.Show("Se eliminó la categoría", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la categoría", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
