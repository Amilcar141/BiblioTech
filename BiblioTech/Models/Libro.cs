using BiblioTech.Models;
using System.Collections.Generic;
using System;

namespace BiblioTech.Models
{ 
    public class Libro
{
    // Atributos privados  
    private int _idLibro; 
    private string _isbn;
    private string _nombreLibro;
    private string _autor;
    private int _idCategoria;
    private string _nombreCategoria;
    private string _fechaPublicacion;
    private int _numeroPaginas;
    private string _editorial;
    private string _aliasUsuario;
    private string _fechaRegistro;
    private bool _disponible;

    // Constructor
    public Libro()
    {
        _isbn = "";
        _nombreLibro = "";
        _autor = "";
        _nombreCategoria = "";
        _fechaPublicacion = "";
        _editorial = "";
        _aliasUsuario = "";
        _fechaRegistro = "";
        _disponible = true;
    }

        // Getters y Setters
    public int idLibro { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public int GetIdLibro() { return _idLibro; }
    public void SetIdLibro(int id) { _idLibro = id; }

    public string GetISBN() { return _isbn; }
    public void SetISBN(string isbn) { _isbn = isbn; }

    public string GetNombreLibro() { return _nombreLibro; }
    public void SetNombreLibro(string nombreLibro) { _nombreLibro = nombreLibro; }

    public string GetAutor() { return _autor; }
    public void SetAutor(string autor) { _autor = autor; }

    public int GetIdCategoria() { return _idCategoria; }
    public void SetIdCategoria(int idCategoria) { _idCategoria = idCategoria; }

    public string GetNombreCategoria() { return _nombreCategoria; }
    public void SetNombreCategoria(string nombreCategoria) { _nombreCategoria = nombreCategoria; }

    public string GetFechaPublicacion() { return _fechaPublicacion; }
    public void SetFechaPublicacion(string fechaPublicacion) { _fechaPublicacion = fechaPublicacion; }

    public int GetNumeroPaginas() { return _numeroPaginas; }
    public void SetNumeroPaginas(int numeroPaginas) { _numeroPaginas = numeroPaginas; }

    public string GetEditorial() { return _editorial; }
    public void SetEditorial(string editorial) { _editorial = editorial; }

    public string GetAliasUsuario() { return _aliasUsuario; }
    public void SetAliasUsuario(string alias) { _aliasUsuario = alias; }

    public string GetFechaRegistro() { return _fechaRegistro; }
    public void SetFechaRegistro(string fechaRegistro) { _fechaRegistro = fechaRegistro; }

    public bool GetDisponible() { return _disponible; }
    public void SetDisponible(bool valor) { _disponible = valor; }

}
}


