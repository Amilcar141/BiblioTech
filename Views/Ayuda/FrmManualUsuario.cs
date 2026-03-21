using System;
using System.Windows.Forms;

namespace BiblioTech.Views.Ayuda
{
    public partial class FrmManualUsuario : Form
    { 
        public FrmManualUsuario() { InitializeComponent(); }

        private void FrmManualUsuario_Load(object sender, EventArgs e)
        {
            rtbManual.Text =
                "MANUAL DE USUARIO - BiblioTech v1.0\r\n" +
                "=========================================\r\n\r\n" +
                "1. CATALOGO DE LIBROS\r\n" +
                "   - Agregar Libro: complete ISBN, titulo, autor, categoria,\r\n" +
                "     fecha, paginas, editorial y alias de quien registra.\r\n" +
                "   - Buscar Libro: use el campo de busqueda y filtro de disponibilidad.\r\n" +
                "   - Editar Libro: haga doble clic en la tabla para cargar el libro.\r\n" +
                "   - Eliminar Libro: seleccione y confirme.\r\n" +
                "   - Ver Disponibilidad: estado actual de todos los libros.\r\n" +
                "   - Gestionar Categorias: agregar, editar o eliminar categorias.\r\n\r\n" +
                "2. PRESTAMOS\r\n" +
                "   - Registrar Prestamo: seleccione libro disponible, ingrese nombre\r\n" +
                "     del usuario y fecha limite de devolucion.\r\n" +
                "   - Devolver Libro: seleccione el prestamo activo y confirme.\r\n" +
                "   - Historial: todos los prestamos con filtro por estado.\r\n" +
                "   - Prestamos Vencidos: lista con dias de retraso y multa estimada.\r\n\r\n" +
                "3. MULTAS\r\n" +
                "   - Multas Pendientes: multas sin pagar con total a cobrar.\r\n" +
                "   - Multas Pagadas: historial de multas cobradas.\r\n\r\n" +
                "4. USUARIOS\r\n" +
                "   - Registrar Usuario: nombre, correo, contrasena y rol.\r\n" +
                "   - Buscar Usuario: por nombre o correo.\r\n\r\n" +
                "5. REPORTES\r\n" +
                "   - Inventario: catalogo completo con estado de disponibilidad.\r\n\r\n" +
                "6. FAVORITOS\r\n" +
                "   - Agregar libros favoritos con ISBN, titulo, autor, genero.\r\n\r\n" +
                "Para soporte use menu Ayuda > Soporte.";
        }

        private void btnCerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
