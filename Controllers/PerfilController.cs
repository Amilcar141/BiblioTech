using System.Collections.Generic;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
    public class PerfilController
    {
        private readonly SistemaLibreria    _sistema;
        private readonly LectorController  _lectorCtrl;
        private readonly PrestamoController _prestamoCtrl;
        private readonly MultaController    _multaCtrl;
        private readonly LibroController    _libroCtrl;

        public PerfilController(SistemaLibreria sistema)
        {
            _sistema      = sistema;
            _lectorCtrl   = new LectorController(sistema);
            _prestamoCtrl = new PrestamoController(sistema);
            _multaCtrl    = new MultaController(sistema);
            _libroCtrl    = new LibroController(sistema);
        }

        // Obtener el lector logueado por su cuenta
        public Lector ObtenerLector(string cuenta)
        {
            return _lectorCtrl.ObtenerPorCuenta(cuenta);
        }

        // Validar y actualizar datos — devuelve "" si ok, o mensaje de error
        public string ActualizarDatos(string cuenta, string nombre, string correo, string password)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre no puede estar vacío.";

            if (nombre.Trim().Length < 3)
                return "El nombre debe tener al menos 3 caracteres.";

            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@"))
                return "Ingrese un correo válido (debe contener @).";

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                return "La contraseña debe tener al menos 6 caracteres.";

            Lector lector = _lectorCtrl.ObtenerPorCuenta(cuenta);
            if (lector == null)
                return "No se encontró el usuario.";

            // Verificar correo duplicado en otro lector
            Lector otro = _lectorCtrl.ObtenerPorCorreo(correo);
            if (otro != null && otro.Cuenta != cuenta)
                return "Ya existe otro usuario con ese correo.";

            lector.Nombre   = nombre.Trim();
            lector.Correo   = correo.Trim();
            lector.Password = password;

            return "";
        }

        // Préstamos del lector logueado
        public List<Prestamo> ObtenerPrestamosDelLector(string cuenta)
        {
            Lector lector = _lectorCtrl.ObtenerPorCuenta(cuenta);
            return _prestamoCtrl.ObtenerPorLector(lector);
        }

        // Multas del lector logueado
        public List<Multa> ObtenerMultasDelLector(string cuenta)
        {
            Lector lector = _lectorCtrl.ObtenerPorCuenta(cuenta);
            return _multaCtrl.ObtenerPorLector(lector);
        }

        // Catálogo completo de libros
        public List<Libro> ObtenerTodosLosLibros()
        {
            return _libroCtrl.Inventario();
        }
    }
}  