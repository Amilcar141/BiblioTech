using System;

namespace BiblioTech.Models
{
    public class Categoria
    {
        
        private int    _idCategoria;
        private string _nombreCategoria;

        // Constructor 
        public Categoria()
        { _nombreCategoria = ""; } 

        
        public int  GetIdCategoria()             
        {   return _idCategoria;}

        public void SetIdCategoria(int id)    
        { _idCategoria = id; }

        public string GetNombreCategoria()       
        { return _nombreCategoria;  }
        public void   SetNombreCategoria(string nombreCategoria) 
        { _nombreCategoria = nombreCategoria;  }

        public override string ToString()
        {return _nombreCategoria; }
    }
}
