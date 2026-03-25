using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech.Views.Reportes
{
    public partial class FrmLibrosMasPrestados : Form
    {
        // Controlador
        private PrestamoController _prestamoCtrl;

        // Constructor
        public FrmLibrosMasPrestados(SistemaLibreria sistema)
        {
            InitializeComponent();
            _prestamoCtrl = new PrestamoController(sistema);
        }

        // Evento de carga del formulario
        private void FrmLibrosMasPrestados_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Cargar tabla de libros más prestados
        private void CargarTabla()
        {
            dgvLibros.Rows.Clear();

            try
            {
                // Contar préstamos por libro
                Dictionary<string, int> conteo = new Dictionary<string, int>();
                Dictionary<string, string> autores = new Dictionary<string, string>();

                foreach (Prestamo prestamo in _prestamoCtrl.ObtenerTodos())
                {
                    // Validar que tenga libros
                    if (prestamo.Libros == null || prestamo.Libros.Count == 0)
                        continue;

                    string titulo = prestamo.Libros[0].Libro.Titulo;
                    string autor = prestamo.Libros[0].Libro.Autor.NombreCompleto();

                    if (conteo.ContainsKey(titulo))
                        conteo[titulo]++;
                    else
                    {
                        conteo[titulo] = 1;
                        autores[titulo] = autor;
                    }
                }

                // Ordenar descendente
                List<KeyValuePair<string, int>> titulos = conteo
                    .OrderByDescending(x => x.Value)
                    .ToList();

                int pos = 1;
                foreach (var item in titulos)
                {
                    string titulo = item.Key;
                    int cantidad = item.Value;

                    int fila = dgvLibros.Rows.Add(
                        pos++,
                        titulo,
                        autores.ContainsKey(titulo) ? autores[titulo] : "",
                        cantidad);

                    // Aplicar colores para los primeros tres lugares
                    if (pos == 2)
                        dgvLibros.Rows[fila].DefaultCellStyle.BackColor = Color.Gold;
                    else if (pos == 3)
                        dgvLibros.Rows[fila].DefaultCellStyle.BackColor = Color.Silver;
                    else if (pos == 4)
                        dgvLibros.Rows[fila].DefaultCellStyle.BackColor = Color.FromArgb(205, 127, 50);
                }

                if (dgvLibros.Rows.Count == 0)
                    dgvLibros.Rows.Add("-", "No hay préstamos registrados", "", 0);

                lblContador.Text = "Libros distintos prestados: " + (titulos.Count > 0 ? titulos.Count : 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
