using Libreria.LogicaNegocio.ValueObjects.ValueAutor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Autor
    {
        public int Id { get; set; }

        public AutorNombreCompleto NombreCompleto { get; set; }

        public Pais Pais{ get; set; }
    }
}
