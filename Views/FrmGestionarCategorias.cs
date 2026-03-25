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
        // Controladore
        private CategoriaController _categoriaCtrl;

        // Constructor
        public FrmGestionarCategorias(SistemaLibreria sistema)
        {
            InitializeComponent();
            _categoriaCtrl = new CategoriaController(sistema);

            CargarTabla();
            HabilitarEdicion(false);
        }

        // Carga la tabla con el contenido
        private void CargarTabla()
        {
            dgvCategorias.Rows.Clear();

            foreach (Categoria cat in _categoriaCtrl.ObtenerTodas())
            {
                int rowIndex = dgvCategorias.Rows.Add(
                    cat.Codigo,
                    cat.NombreCategoria
                );
                // Almacenar el objeto Categoria en el Tag de la fila
                dgvCategorias.Rows[rowIndex].Tag = cat;
            }

            lblContador.Text = "Total: " + dgvCategorias.Rows.Count + " categoría(s)";
        }

        // Habilitar o deshabilitar botones de edicion
        private void HabilitarEdicion(bool activo)
        {
            btnEditar.Enabled = activo;
            btnEliminar.Enabled = activo;
        }

        
        private void Limpiar()
        {
            txtNombreCategoria.Clear();
            txtDescripcion.Clear();
            txtNombreCategoria.Focus();
            HabilitarEdicion(false);
        }

        // Seleccion de la categoria en la tabla
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                // Recuperar el objeto original del Tag de la fila
                Categoria catSeleccionada = (Categoria)dgvCategorias.CurrentRow.Tag;
                
                if (catSeleccionada != null)
                {
                    txtNombreCategoria.Text = catSeleccionada.NombreCategoria;
                    txtDescripcion.Text = catSeleccionada.Descripcion;
                    HabilitarEdicion(true);
                }
            }
        }

        // Guardar nueva categoria
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCategoria.Text;
            string descripcion = txtDescripcion.Text;

            try
            {
                bool exito = _categoriaCtrl.AgregarCategoria(nombre, descripcion);

                if (exito)
                {
                    MessageBox.Show("Categria Ingresada", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarTabla();
                }
            }
            catch
            {
                MessageBox.Show("Error al crear", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría para editar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria catSeleccionada = (Categoria)dgvCategorias.CurrentRow.Tag;
            string nombre = txtNombreCategoria.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool exito = _categoriaCtrl.EditarCategoria(catSeleccionada.Codigo, nombre, descripcion);

                if (exito)
                {
                    MessageBox.Show("Categoría actualizada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la categoría.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria catSeleccionada = (Categoria)dgvCategorias.CurrentRow.Tag;

            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro de que desea eliminar la categoría '{catSeleccionada.NombreCategoria}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    bool exito = _categoriaCtrl.EliminarCategoria(catSeleccionada.Codigo);

                    if (exito)
                    {
                        MessageBox.Show("Categoría eliminada exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la categoría.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
