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
        private CategoriaController _ctrl;
        private int _idSeleccionado;

        // Constructor
        public FrmGestionarCategorias()
        {
            InitializeComponent();
            _ctrl           = new CategoriaController();
            _idSeleccionado = 0;

            ConfigurarTabla();
            CargarTabla();
            HabilitarEdicion(false);
        }

        // Configurar columnas de la tabla 
        private void ConfigurarTabla()
        {
            dgvCategorias.Columns.Clear();

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name       = "Categoria";
            colNombre.HeaderText = "Nombre Categoría";
            colNombre.Width      = 300;

            DataGridViewTextBoxColumn colIdOculto = new DataGridViewTextBoxColumn();
            colIdOculto.Name    = "ID";
            colIdOculto.Visible = false;

            dgvCategorias.Columns.Add(colIdOculto);
            dgvCategorias.Columns.Add(colNombre);
        }

        
        private void CargarTabla()
        {
            dgvCategorias.Rows.Clear();

            List<Categoria> categorias = _ctrl.ObtenerTodas();

            foreach (Categoria cat in categorias)
            {
                dgvCategorias.Rows.Add(
                    cat.GetIdCategoria(),
                    cat.GetNombreCategoria()
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
            _idSeleccionado = 0;
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();
            HabilitarEdicion(false);
        }

        // Seleccion de la categoria en la tabla
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
                return;

            _idSeleccionado         = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["ID"].Value);
            txtIdCategoria.Text     = _idSeleccionado.ToString();
            txtNombreCategoria.Text = dgvCategorias.CurrentRow.Cells["Categoria"].Value.ToString();

            HabilitarEdicion(true);
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje  = "";
            bool   resultado = _ctrl.Guardar(txtNombreCategoria.Text, out mensaje);

            if (resultado)
            {
                MessageBox.Show(mensaje, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarTabla();
            }
            else
            {
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría de la tabla.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje  = "";
            bool   resultado = _ctrl.Editar(_idSeleccionado, txtNombreCategoria.Text, out mensaje);

            if (resultado)
            {
                MessageBox.Show(mensaje, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarTabla();
            }
            else
            {
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría de la tabla.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Eliminar la categoría \"" + txtNombreCategoria.Text + "\"?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            string mensaje  = "";
            bool   resultado = _ctrl.Eliminar(_idSeleccionado, out mensaje);

            if (resultado)
            {
                MessageBox.Show(mensaje, "Eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarTabla();
            }
            else
            {
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
