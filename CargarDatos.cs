using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;

namespace BiblioTech
{
    internal class CargarDatos
    {
        public static void CargarDatosIniciales(SistemaLibreria sistema)
        {
            // Crear nacionalidades
            Nacionalidad nacional = new Nacionalidad("Española");
            Nacionalidad nacional2 = new Nacionalidad("Mexicana");
            Nacionalidad nacional3 = new Nacionalidad("Argentina");

            // Crear autores
            Autor autor1 = new Autor("Gabriel", "García Márquez", nacional2);
            Autor autor2 = new Autor("Jorge Luis", "Borges", nacional3);
            Autor autor3 = new Autor("Miguel de", "Cervantes", nacional);

            sistema.Autores.Add(autor1);
            sistema.Autores.Add(autor2);
            sistema.Autores.Add(autor3);

            // Crear categorías
            Categoria categoria1 = new Categoria("Novela", "Obras de ficción narrativa");
            Categoria categoria2 = new Categoria("Ensayo", "Textos de análisis y reflexión");
            Categoria categoria3 = new Categoria("Poesía", "Obras poéticas clásicas");

            sistema.Categorias.Add(categoria1);
            sistema.Categorias.Add(categoria2);
            sistema.Categorias.Add(categoria3);

            // Crear editoriales
            Editorial editorial1 = new Editorial("Editorial Planeta España", nacional);
            Editorial editorial2 = new Editorial("Grupo Editorial Planeta México", nacional2);
            Editorial editorial3 = new Editorial("Emecé Editores Argentina", nacional3);

            sistema.Editoriales.Add(editorial1);
            sistema.Editoriales.Add(editorial2);
            sistema.Editoriales.Add(editorial3);

            // Crear libros
            Libro libro1 = new Libro("9788408072980", "Cien años de soledad", autor1, categoria1, editorial2, 22.50m, 432, new DateTime(1967, 5, 30));
            Libro libro2 = new Libro("9788423512768", "Ficciones", autor2, categoria1, editorial3, 18.95m, 224, new DateTime(1944, 8, 14));
            Libro libro3 = new Libro("9788435046274", "Don Quijote de la Mancha", autor3, categoria1, editorial1, 25.99m, 1072, new DateTime(1605, 1, 16));

            sistema.Libros.Add(libro1);
            sistema.Libros.Add(libro2);
            sistema.Libros.Add(libro3);
        }
    }
}
