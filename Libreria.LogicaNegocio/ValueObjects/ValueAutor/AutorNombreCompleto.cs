using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Libreria.LogicaNegocio.ValueObjects.ValueAutor
{
    [ComplexType]

    public record AutorNombreCompleto
    {
        public string Nombre { get; init; }
        public string Apellido { get; init; }



    }
}
